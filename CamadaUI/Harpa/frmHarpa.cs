using CamadaBLL;
using CamadaDTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using static CamadaUI.Utilidades;

namespace CamadaUI.Harpa
{
	public partial class frmHarpa : Form
	{
		private HarpaBLL hBLL = null;
		private BindingSource bindEstrofe = new BindingSource();
		private List<clHinoEstrofe> estrofeList = null;
		private clHinoEstrofe coroEstrofe = null;
		private clHinoEstrofe _EstrofeAtual;

		private bool NavDisabled;
		public string DBPath;
		private bool HinoEscolhidoAdded = false; // to previne ADD again

		#region OPEN AND PROPERTIES
		// ================================================================================================

		// VOID NEW
		public frmHarpa()
		{
			InitializeComponent();

			this.DoubleBuffered = true;
			pnlTop.BackColor = Properties.Settings.Default.PanelTopColor;
			lblHinoTitulo.BackColor = pnlInfo.BackColor;

			// GET DADOS
			DBPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"ProjetorDB.mdb");
			hBLL = new HarpaBLL(DBPath);
			GetDadosInicial();
			
			// selecionar a fonte
			// ---------------------------------------------------------------------------------------------
			//txtEscritura.Font = new Font("Verdana", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtEstrofe.Font = new Font("Ezra SIL", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtEstrofe_SizeChanged(txtEstrofe, new EventArgs());

		}
		
		// ON SHOW
		private void frmHarpa_Shown(object sender, EventArgs e)
		{
			// send first PreviewKey
			SendKeys.Send("{LEFT}");
		}

		// GET INICIAL: Hino e Estrofes
		private void GetDadosInicial()
		{
			try
			{
				// Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				// GET Hino Inicial
				string ultID = FuncoesGlobais.ObterDefault("IDHinoUltimo");

				if(ultID != string.Empty)
				{
					GetEstrofesHinoByID(Convert.ToInt32(ultID));
				}
				else
				{
					GetEstrofesHinoByID(1);
				}
			}
			catch (Exception ex)
			{
				AbrirDialog("Um exceção ocorreu ao obter os Dados Iniciais " + "\n" +
							ex.Message,
							"Exceção Inesperada",
							DialogType.OK,
							DialogIcon.Exclamation);
			}
			finally
			{
				// Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}
		}

		// PROPERTY ESTROFE ATUAL
		public clHinoEstrofe EstrofeAtual
		{
			get => _EstrofeAtual;
			set
			{
				_EstrofeAtual = value;
				txtEstrofe.Text = _EstrofeAtual.Estrofe;
				CheckNavButtonsState();

				// controla Label Navegacao
				if(coroEstrofe == null)
				{
					if (_EstrofeAtual.EstrofeOrdem == estrofeList.Count)
					{
						lblNavegacao.Text = "FINAL";
					}
					else
					{
						lblNavegacao.Text = $"Estrofe {_EstrofeAtual.EstrofeOrdem} de {estrofeList.Count}";
					}
				}
				else
				{
					if (_EstrofeAtual.IsCoro)
					{
						if (bindEstrofe.Position == estrofeList.Count -1 )
						{
							lblNavegacao.Text = "FINAL";
						}
						else
						{
							lblNavegacao.Text = $"Coro {bindEstrofe.Position + 1} de {estrofeList.Count}";
						}
					}
					else
					{
						lblNavegacao.Text = $"Estrofe {_EstrofeAtual.EstrofeOrdem} de {estrofeList.Count}";
					}
				}

				// SELECIONA E MARCA A ESTROFE NO PAINEL
				EstrofeSelected();

				// add Escolhido Count if Last Estrofe
				if (!_EstrofeAtual.IsCoro)
				{
					if(_EstrofeAtual.EstrofeOrdem == estrofeList.Count && !HinoEscolhidoAdded)
					{
						EscolhidoCountAdd(); // update DB
						HinoEscolhidoAdded = true; // to previne add again
					}
				}
			}
		}

		// CHECK AND CHANGE NAV BUTTONS STATE (ENABLED / DISABLED)
		private void CheckNavButtonsState()
		{
			if (bindEstrofe.Position >= estrofeList.Count - 1) // disabled buttons
			{
				if ((coroEstrofe != null && EstrofeAtual.IsCoro) || (coroEstrofe == null)  )
				{
					NavDisabled = true;

					if (bindEstrofe.Position >= estrofeList.Count - 1)
					{
						btnNext.Enabled = false;
						btnNext.Image = Properties.Resources.Next_32px_disabled;
						btnPrev.Enabled = true;
						btnPrev.Image = Properties.Resources.Previous_32px;
					}
				}
			}
			else if (bindEstrofe.Position == 0)
			{
				if (!EstrofeAtual.IsCoro) // IS NOT CORO
				{
					NavDisabled = true;

					btnNext.Enabled = true;
					btnNext.Image = Properties.Resources.Next_32px;
					btnPrev.Enabled = false;
					btnPrev.Image = Properties.Resources.Previous_32px_disabled;
				}
				else // IS CORO
				{
					btnNext.Enabled = true;
					btnPrev.Enabled = true;
					btnPrev.Image = Properties.Resources.Previous_32px;
					btnNext.Image = Properties.Resources.Next_32px;
					NavDisabled = false;
				}
			}
			else if (NavDisabled) // else: enabled buttons
			{
				btnNext.Enabled = true;
				btnPrev.Enabled = true;
				btnPrev.Image = Properties.Resources.Previous_32px;
				btnNext.Image = Properties.Resources.Next_32px;
				NavDisabled = false;
			}
		}

		#endregion

		#region GET DATA

		// GET LIST OF ESTROFES BY HINO ID
		// =============================================================================
		public void GetEstrofesHinoByID(int IDHino)
		{
			try
			{
				// Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				// Get LIST DB
				HarpaBLL hBLL = new HarpaBLL(DBPath);
				coroEstrofe = null;
				HinoEscolhidoAdded = false;
				estrofeList = hBLL.GetEstrofesListByID(IDHino);

				// Define a Estrofe do Coro
				if (estrofeList.Exists(estrofe => estrofe.IsCoro))
				{
					coroEstrofe = estrofeList.Find(estrofe => estrofe.IsCoro);
					// remove coro from list
					estrofeList.Remove(coroEstrofe);
				}

				// define Hino Titulo
				lblHinoTitulo.Text = estrofeList[0].Titulo;
				lblHinoNumero.Text = $"Harpa Cristã {estrofeList[0].IDHino:D3}";

				// define databind
				bindEstrofe.DataSource = estrofeList;
				bindEstrofe.Position = 0;

				// fill panel Estrofes Buttons
				PainelItensInserir();

				// define Strofe Atual as first strofe
				EstrofeAtual = (clHinoEstrofe)bindEstrofe.Current;

				// Save Last Hino in CONFIG
				SaveConfigLastHino();

				// Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}
			catch (Exception ex)
			{
				AbrirDialog("Um exceção ocorreu ao obter as Estrofes " + "\n" +
							ex.Message,
							"Exceção Inesperada",
							DialogType.OK,
							DialogIcon.Exclamation);
			}
		}

		#endregion

		#region BUTTONS
		//*********************************************************************************************************

		// ABRIR PROCURA
		//-------------------------------------------------------------------------------------------------
		private void btnProcura_Click(object sender, EventArgs e)
		{
			ProcurarHino();
		}

		// ABRIR PROCURA
		// =============================================================================
		private void ProcurarHino()
		{
			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				int IDOrigem = EstrofeAtual.IDHino ?? 1;

				using (frmHarpaEscolher frm = new frmHarpaEscolher(this))
				{
					frm.ShowDialog();
					if(frm.DialogResult == DialogResult.OK)
					{
						GetEstrofesHinoByID((int)frm.HinoEscolhido.IDHino);
						
						// add in HISTORICO if selected different Hino
						if (IDOrigem != frm.HinoEscolhido.IDHino)
						{
							try
							{
								hBLL.AddHistorico((int)frm.HinoEscolhido.IDHino);
							}
							catch (Exception ex)
							{
								AbrirDialog("Um exceção ocorreu ao salvar Histórico \n" + ex.Message,
									"Exceção", DialogType.OK, DialogIcon.Exclamation);
							}
						}
					}
				}

			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Abrir formulário de procura..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}
		}

		// MINIMIZE
		// =============================================================================
		private void btnMinimizer_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		// CLOSE FORM
		// =============================================================================
		private void btnFechar_Click(object sender, EventArgs e)
		{
			Application.OpenForms["frmPrincipal"].Visible = true;
			Close();
		}

		#endregion

		#region FUNCTIONS
		// ================================================================================================

		// PREVINE SELECT TXT ESCRITURA
		private void txtEstrofe_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}

		// RESIZE TEXTFONT SIZE ESCRITURA
		private void txtEstrofe_SizeChanged(object sender, EventArgs e)
		{
			TextBox tb = sender as TextBox;
			if (tb.Height < 10)
			{
				return;
			}

			if (tb == null)
			{
				return;
			}

			if (tb.Text == "")
			{
				return;
			}


			SizeF stringSize;
			
			// AMPULHETA ON
			Cursor.Current = Cursors.WaitCursor;

			// return Original Font
			txtEstrofe.Font = new Font("Ezra SIL", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
			
			// create a graphics object for this form
			using (Graphics gfx = this.CreateGraphics())
			{
				// Get the size given the string and the font
				//stringSize = gfx.MeasureString(tb.Text, tb.Font);
				//stringSize = gfx.MeasureString(tb.Text.Split(new[] { '\r', '\n' })[0], tb.Font);
				stringSize = gfx.MeasureString(tb.Text.Replace("\r", " ").Replace("\n",""), tb.Font);

				//test how many rows
				int rows = (int)((double)tb.Height / (stringSize.Height));
				if (rows == 0)
				{
					return;
				}

				double areaAvailable = rows * stringSize.Height * tb.Width;
				double areaRequired = stringSize.Width * stringSize.Height * 1.3;

				if (areaAvailable / areaRequired > 1.1)
				{
					while (areaAvailable / areaRequired > 1.1)
					{
						//tb.Font = new Font(tb.Font.FontFamily, tb.Font.Size * 1.1F);
						tb.Font = new Font(tb.Font.FontFamily, tb.Font.Size + 0.5F);

						stringSize = gfx.MeasureString(tb.Text, tb.Font);

						// recalc areaAvaiable
						rows = (int)((double)tb.Height / (stringSize.Height));
						areaAvailable = rows * stringSize.Height * tb.Width;

						areaRequired = stringSize.Width * stringSize.Height * 1.1;
					}
				}
				else
				{
					while (areaRequired * 1.1 > areaAvailable)
					{
						//tb.Font = new Font(tb.Font.FontFamily, tb.Font.Size / 1.1F);
						tb.Font = new Font(tb.Font.FontFamily, tb.Font.Size - 0.5F);
						stringSize = gfx.MeasureString(tb.Text, tb.Font);

						// recalc areaAvaiable
						rows = (int)((double)tb.Height / (stringSize.Height));
						areaAvailable = rows * stringSize.Height * tb.Width;

						areaRequired = stringSize.Width * stringSize.Height * 1.1;
					}
				}
			}

			// Ampulheta OFF
			Cursor.Current = Cursors.Default;

		}

		#endregion

		#region NAVEGACAO ESTROFES / HINOS
		//*********************************************************************************************************

		// NEXT
		private void btnNext_Click(object sender, EventArgs e)
		{
			if (bindEstrofe.Position < estrofeList.Count -1 ) // MENOR
			{
				if(coroEstrofe == null) // NOT HAVE CORO
				{
					bindEstrofe.Position += 1;
					EstrofeAtual = (clHinoEstrofe)bindEstrofe.Current;
				}
				else // HAVE CORO
				{
					if (EstrofeAtual.IsCoro) // IS CORO
					{
						bindEstrofe.Position += 1;
						EstrofeAtual = (clHinoEstrofe)bindEstrofe.Current;
					}
					else // NOT IS CORO
					{
						EstrofeAtual = coroEstrofe;
					}
				}
			}
			else if(bindEstrofe.Position == estrofeList.Count - 1)
			{
				if (coroEstrofe == null) // NOT HAVE CORO
				{
					AbrirDialog("Fim do Hino...", "Fim");
				}
				else // HAVE CORO
				{
					if (EstrofeAtual.IsCoro) // IS CORO
					{
						AbrirDialog("Fim do Hino...", "Fim");
					}
					else // NOT IS CORO
					{
						EstrofeAtual = coroEstrofe;
					}
				}
			}
		}

		// PREV
		private void btnPrev_Click(object sender, EventArgs e)
		{
			if (bindEstrofe.Position > 0) // MAIOR
			{
				if (coroEstrofe == null) // NOT HAVE CORO
				{
					bindEstrofe.Position -= 1;
					EstrofeAtual = (clHinoEstrofe)bindEstrofe.Current;
				}
				else // HAVE CORO
				{
					if (EstrofeAtual.IsCoro) // IS CORO
					{
						EstrofeAtual = (clHinoEstrofe)bindEstrofe.Current;
					}
					else // NOT IS CORO
					{
						bindEstrofe.Position -= 1;
						EstrofeAtual = coroEstrofe;
					}
				}
			}
			else if (bindEstrofe.Position == 0)
			{
				if (coroEstrofe == null) // NOT HAVE CORO
				{
					AbrirDialog("Início do Hino...", "Início");
				}
				else // HAVE CORO
				{
					if (!EstrofeAtual.IsCoro) // not IS CORO
					{
						AbrirDialog("Início do Hino...", "Início");
					}
					else // IS CORO
					{
						EstrofeAtual = (clHinoEstrofe)bindEstrofe.Current;
					}
				}
			}
		}

		// SHORTCUTS NAVEGACAO BY ESTROFES
		// =============================================================================
		private void frmHarpa_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Right)
			{
				e.Handled = true;
				btnNext_Click(sender, e);
			}
			else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Down)
			{
				e.Handled = true;
				btnPrev_Click(sender, e);
			}
			else if (e.KeyCode == Keys.Escape)
			{
				e.Handled = true;
				btnFechar_Click(sender, e);
			}
			else if (e.KeyCode == Keys.PageUp)
			{
				e.Handled = true;
				NextHino();
			}
			else if (e.KeyCode == Keys.PageDown)
			{
				e.Handled = true;
				PrevHino();
			}
			else if (e.KeyCode == Keys.P)
			{
				e.Handled = true;
				ProcurarHino();
			}
			else if (e.KeyCode == Keys.H)
			{
				e.Handled = true;
				OpenHistorico();
			}
		}

		// PROXIMO CAPITULO
		// =============================================================================
		private void NextHino()
		{
			int IDHinoAtual = (int)_EstrofeAtual.IDHino;

			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				int MaxID = hBLL.GetMaxIDHinos();

				if(IDHinoAtual == MaxID)
				{
					AbrirDialog("Nós já estamos no último Hino da Harpa Cristã...",
						"Último Hino");
					return;
				}

				GetEstrofesHinoByID(IDHinoAtual + 1);
				
				btnNext.Focus();

			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao ir para o próximo Hino da Harpa..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}
		}

		// ANTERIOR CAPITULO
		// =============================================================================
		private void PrevHino()
		{
			int IDHinoAtual = (int)_EstrofeAtual.IDHino;

			try
			{
				if (IDHinoAtual == 1)
				{
					AbrirDialog("Nós já estamos no Primeiro Hino da Harpa Cristã...",
						"Primeiro Hino");
					return;
				}

				GetEstrofesHinoByID(IDHinoAtual - 1);
				
				btnNext.Focus();

				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;
			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao ir para o Hino Anterior da Harpa..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}
		}

		#endregion

		#region OTHER FUNCTIONS

		private void Tmr_Tick(object sender, EventArgs e)
		{
			if(pnlHistorico.Width <= 220)
			{
				pnlHistorico.Width = 220;
				Timer tmr = (Timer)sender;
				tmr.Stop();
			}

			pnlHistorico.Width -= 5;
			pnlHistorico.Location = new Point(pnlHistorico.Location.X + 5, pnlHistorico.Location.Y);
			pnlHistorico.Refresh();
		}

		// SAVE THE LAST VERSICULO ON CONFIG
		private void SaveConfigLastHino()
		{
			FuncoesGlobais.SaveDefault("IDHinoUltimo", _EstrofeAtual.IDHino.ToString());
		}

		// ADD ESCOLHIDO COUNT OF HINO
		private	void EscolhidoCountAdd()
		{
			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				// --- ADD DB
				hBLL.EscolhidoCountAdd((int)_EstrofeAtual.IDHino);

			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Adicionar selecionado..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}

		}

		private void frmHarpa_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			e.IsInputKey = true;
		}

		#endregion

		#region PAINEL ITEMS

		private void PainelItensInserir()
		{
			pnlItems.Controls.Clear();

			for (int i = 0; i < estrofeList.Count ; i++)
			{

				Button btnEstrofe = new ButtonEstrofe()
				{
					Name = $"btnEstrofe{i + 1}",
					TabIndex = i,
					Text = $"{i + 1}",
					Tag = $"{i + 1}"
				};

				btnEstrofe.Click += new EventHandler(btnEstrofe_Click);
				btnEstrofe.KeyDown += frmHarpa_KeyDown;
				btnEstrofe.PreviewKeyDown += frmHarpa_PreviewKeyDown;

				// add btn at panel
				pnlItems.Controls.Add(btnEstrofe);

			};

			if(coroEstrofe != null)
			{
				Button btnEstrofe = new ButtonEstrofe(80)
				{
					Name = $"btnEstrofeCoro",
					TabIndex = estrofeList.Count,
					Text = $"Coro",
					Tag = 0
				};

				btnEstrofe.Click += new EventHandler(btnEstrofe_Click);
				btnEstrofe.KeyDown += frmHarpa_KeyDown;
				btnEstrofe.PreviewKeyDown += frmHarpa_PreviewKeyDown;

				pnlItems.Controls.Add(btnEstrofe);
			}

			// move label
			pnlItems.Refresh();
			lblEstrofes.Location = new Point(pnlItems.Location.X - 115, lblEstrofes.Location.Y);

		}


		private class ButtonEstrofe : MBGlassStyleButton.MBGlassButton
		{
			public ButtonEstrofe(int width = 49)
			{
			BackColor = Color.Transparent;
			BaseColor = Color.FromArgb(211, 211, 211);
			BaseStrokeColor = Color.FromArgb(192, 192, 192);
			FlatAppearance.BorderSize = 0;
			FlatStyle = FlatStyle.Flat;
			Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			ImageSize = new Size(24, 24);
			Location = new Point(5, 5);
			Margin = new Padding(5, 0, 0, 0);
			MenuListPosition = new Point(0, 0);
			Name = "btnEstrofe";
			OnColor = Color.FromArgb(255, 214, 78);
			OnStrokeColor = Color.FromArgb(196, 177, 118);
			PressColor = Color.FromArgb(255, 128, 0);
			PressStrokeColor = Color.FromArgb(128, 64, 0);
			Size = new Size(width, 35);
			TabIndex = 0;
			Text = "";
			UseVisualStyleBackColor = false;
			}

		}

		private void btnEstrofe_Click(object sender, EventArgs e)
		{
			MBGlassStyleButton.MBGlassButton btn = (MBGlassStyleButton.MBGlassButton)sender;
			
			// get ESTROFE ID by button TAG
			byte IDEstrofe = Convert.ToByte(btn.Tag);

			// define new position of Binding
			bindEstrofe.Position = IDEstrofe - 1;

			// define NEW selected Estrofe
			if(IDEstrofe != 0)
				EstrofeAtual = estrofeList.Find(x => x.EstrofeOrdem == IDEstrofe);
			else
				EstrofeAtual = coroEstrofe;
		}

		private void EstrofeSelected()
		{
			MBGlassStyleButton.MBGlassButton btnEstrofe = null;

			// Descobre qual deve ser o selected button
			if (EstrofeAtual.IsCoro)
			{
				btnEstrofe = (MBGlassStyleButton.MBGlassButton)pnlItems.Controls[ "btnEstrofeCoro" ];
			}
			else
			{
				string btnName = $"btnEstrofe{ EstrofeAtual.EstrofeOrdem }";
				btnEstrofe = (MBGlassStyleButton.MBGlassButton)pnlItems.Controls[btnName];
			}

			// REMOVE ESPECIAL COLOR FROM ALL BTN
			foreach (Control control in pnlItems.Controls)
			{
				MBGlassStyleButton.MBGlassButton btn = (MBGlassStyleButton.MBGlassButton)control;
				btn.BaseColor = Color.FromArgb(211, 211, 211);
				btn.BaseStrokeColor = Color.FromArgb(192, 192, 192);
				btn.Enabled = true;
			}

			// PUT SELECTED COLOR
			btnEstrofe.BaseColor = Color.SandyBrown;
			btnEstrofe.BaseStrokeColor = Color.FromArgb(100, 244, 164, 96);
			btnEstrofe.Enabled = false;
		}

		#endregion

		#region PANEL HISTORICO

		private void btnHistorico_Click(object sender, EventArgs e)
		{
			OpenHistorico();
		}

		private void label1_Click(object sender, EventArgs e)
		{
			OpenHistorico();
		}

		// OPEN HISTORICO FORM
		private void OpenHistorico()
		{
			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				pnlHistorico.Width = 450;
				pnlHistorico.Location = new Point(ClientSize.Width - 450, 100);

				using (frmHarpaHistorico frm = new frmHarpaHistorico(this))
				{
					frm.ShowDialog();
				}

				pnlHistorico.Visible = true;
				Timer tmr = new Timer();
				tmr.Interval = 1;
				tmr.Tick += Tmr_Tick;
				tmr.Start();
			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Abrir o histórico de Hinos..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}
		}

		#endregion

	}

}
