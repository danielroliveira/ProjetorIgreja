using CamadaBLL;
using CamadaDTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using static CamadaUI.Utilidades;

namespace CamadaUI.Escritura
{
	public partial class frmLeitura : Form
	{
		private VersiculoBLL vBLL = null;
		private byte _verAtual;
		private byte _capituloAtual;
		private clLivro _LivroAtual;
		private byte _IDLinguagemAtual;

		public clVersiculo Versiculo;
		private bool NavDisabled;
		public string DBPath;

		private byte verMax;
		private List<clVersiculo> verList = null;
		private List<clLinguagem> LinguagemList = null;
		public List<clLivro> listLivros = null;

		#region OPEN AND PROPERTIES
		// ================================================================================================

		// VOID NEW
		public frmLeitura()
		{
			InitializeComponent();

			this.DoubleBuffered = true;
			pnlTop.BackColor = Properties.Settings.Default.PanelTopColor;
			lblLivro.BackColor = pnlInfo.BackColor;

			// GET DADOS
			DBPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"ProjetorDB.mdb");
			vBLL = new VersiculoBLL(DBPath);
			GetDadosInicial();

			// selecionar a fonte
			// ---------------------------------------------------------------------------------------------
			//txtEscritura.Font = new Font("Verdana", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtEscritura.Font = new Font("Ezra SIL", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtEscritura_SizeChanged(txtEscritura, new EventArgs());

		}

		// ON SHOW
		private void frmLeitura_Shown(object sender, EventArgs e)
		{
			// send first PreviewKey
			SendKeys.Send("{LEFT}");
		}

		// GET INICIAL: linguagens + livros + versiculoinicial
		private void GetDadosInicial()
		{
			try
			{
				// Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				// GET LIST LINGUAGENS
				LinguagemList = vBLL.GetLinguagemList();

				// GET LIST LIVROS
				listLivros = vBLL.GetLivroList();

				// GET Versiculo Inicial
				string ultID = FuncoesGlobais.ObterDefault("IDVersiculoUltimo");

				if(ultID != string.Empty)
				{
					clVersiculo ultVer = vBLL.GetVersiculoByID(Convert.ToInt32(ultID));
					if(ultVer != null)
						GetVersiculos(ultVer.IDLinguagem, (byte)ultVer.IDLivro, (byte)ultVer.Capitulo, (byte)ultVer.Versiculo);
					else
						GetVersiculos(1, 1, 1, 1);
				}
				else // if not finded
				{
					GetVersiculos(1, 1, 1, 1);
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

		// PROPERTY VERSICULO ATUAL
		private byte VerAtual
		{
			get => _verAtual;
			set
			{
				if (value > verMax)
				{
					AbrirDialog("Já estamos no ÚLTIMO versículo deste capítulo...",
						"Último Versiculo",
						DialogType.OK,
						DialogIcon.Information);
					value = verMax;
				}

				_verAtual = value;
				Versiculo = verList[_verAtual - 1];

				_capituloAtual = (byte)Versiculo.Capitulo;
				_LivroAtual = listLivros.Find(l => l.IDLivro == (byte)Versiculo.IDLivro);
				_IDLinguagemAtual = Versiculo.IDLinguagem;
							   
				txtEscritura.Text = Versiculo.Escritura;
				lblLivro.Text = $"{Versiculo.Livro} {Versiculo.Capitulo}:{Versiculo.Versiculo}";
				lblNavegacao.Text = $"Ver. {Versiculo.Versiculo} de {verMax}";

				lblLinguagem.Text = LinguagemList.Find(x => x.IDLinguagem == _IDLinguagemAtual).Linguagem;

				CheckNavButtonsState();
				SaveLastVersiculo();
			}
		}

		// CHECK AND CHANGE NAV BUTTONS STATE (ENABLED / DISABLED)
		private void CheckNavButtonsState()
		{
			if (VerAtual >= verMax || VerAtual <= 1) // disabled buttons
			{
				NavDisabled = true;

				if (VerAtual >= verMax)
				{
					btnNext.Enabled = false;
					btnNext.Image = Properties.Resources.Next_32px_disabled;
					btnLast.Enabled = false;
					btnLast.Image = Properties.Resources.Last_32px_disabled;
					btnPrev.Enabled = true;
					btnPrev.Image = Properties.Resources.Previous_32px;
					btnFirst.Enabled = true;
					btnFirst.Image = Properties.Resources.First_32px;

				}
				else if (VerAtual <= 1)
				{
					btnNext.Enabled = true;
					btnNext.Image = Properties.Resources.Next_32px;
					btnLast.Enabled = true;
					btnLast.Image = Properties.Resources.Last_32px;

					btnPrev.Enabled = false;
					btnPrev.Image = Properties.Resources.Previous_32px_disabled;
					btnFirst.Enabled = false;
					btnFirst.Image = Properties.Resources.First_32px_disabled;
				};
			}
			else if (NavDisabled) // else: enabled buttons
			{
				btnNext.Enabled = true;
				btnLast.Enabled = true;
				btnPrev.Enabled = true;
				btnFirst.Enabled = true;

				btnPrev.Image = Properties.Resources.Previous_32px;
				btnFirst.Image = Properties.Resources.First_32px;
				btnNext.Image = Properties.Resources.Next_32px;
				btnLast.Image = Properties.Resources.Last_32px;
				NavDisabled = false;
			}
		}

		#endregion

		#region GET DATA

		// GET LIST VERSICULOS
		// =============================================================================
		public void GetVersiculos(byte IDLinguagem, byte IDLivro, byte Capitulo, byte Versiculo)
		{
			try
			{
				// Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;
				// Get LIST DB
				VersiculoBLL vBLL = new VersiculoBLL(DBPath);
				verList = vBLL.GetVersiculoList(IDLinguagem, IDLivro, Capitulo);
				// Define Max
				verMax = (byte)verList.Count;
				//Define NEW VersiculoAtual;
				VerAtual = Versiculo;
				// Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		#endregion

		#region BUTTONS
		//*********************************************************************************************************

		// PROCURAR NOVO VERSICULO
		// =============================================================================
		private void btnLinguagens_Click(object sender, EventArgs e)
		{
			clVersiculo verOrigem = Versiculo ?? new clVersiculo();

			using (frmEscrituraEscolher frm = new frmEscrituraEscolher(verOrigem, this))
			{
				frm.ShowDialog();
				if (frm.DialogResult == DialogResult.OK)
				{
					verList = frm.ListVersiculos;
					verMax = (byte)verList.Count;
					VerAtual = (byte)frm.SelVersiculo.Versiculo;

					// add in HISTORICO if selected different versiculo
					if(verOrigem.IDVersiculo != frm.SelVersiculo.IDVersiculo)
					{
						try
						{
							vBLL.AddHistorico((int)frm.SelVersiculo.IDVersiculo, DBPath);
						}
						catch (Exception ex)
						{
							AbrirDialog("Um exceção ocorreu ao salvar Histórico \n" + ex.Message,
								"Exceção", DialogType.OK, DialogIcon.Exclamation);
						}
					}
				}
			};
		}

		// OPEN MENU LINGUAGENS ON CLICK LBL LINGUAGEM
		// =============================================================================
		private void lblLinguagem_Click(object sender, EventArgs e)
		{
			mnuLinguagens.Show(lblLinguagem, new Point(lblLinguagem.Width, lblLinguagem.Height));
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
		private void txtEscritura_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}

		// RESIZE TEXTFONT SIZE ESCRITURA
		private void txtEscritura_SizeChanged(object sender, EventArgs e)
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

			// create a graphics object for this form
			using (Graphics gfx = this.CreateGraphics())
			{
				// Get the size given the string and the font
				stringSize = gfx.MeasureString(tb.Text, tb.Font);
				//test how many rows
				int rows = (int)((double)tb.Height / (stringSize.Height));
				if (rows == 0)
				{
					return;
				}

				double areaAvailable = rows * stringSize.Height * tb.Width;
				double areaRequired = stringSize.Width * stringSize.Height * 1.1;

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

		#region NAVEGACAO VERSICULOS / CAPITULOS
		//*********************************************************************************************************

		// LAST
		private void btnLast_Click(object sender, EventArgs e)
		{
			if (verMax != VerAtual)
			{
				VerAtual = verMax;
			}
			else
			{
				AbrirDialog("Já estamos no ÚLTIMO versículo deste capítulo...",
					"Último Versiculo",
					DialogType.OK,
					DialogIcon.Information);
			}
		}

		// NEXT
		private void btnNext_Click(object sender, EventArgs e)
		{
			VerAtual += 1;
		}

		// PREV
		private void btnPrev_Click(object sender, EventArgs e)
		{
			if (VerAtual == 1)
			{
				AbrirDialog("Já estamos no PRIMEIRO versículo deste capítulo...",
							"Último Versiculo",
							DialogType.OK,
							DialogIcon.Information);
				//txtEscritura.SelectionLength = 0;
				btnNext.Focus();
			}
			else
			{
				VerAtual -= 1;
			}
		}

		// FIRST
		private void btnFirst_Click(object sender, EventArgs e)
		{
			if (VerAtual == 1)
			{
				AbrirDialog("Já estamos no PRIMEIRO versículo deste capítulo...",
							"Último Versiculo",
							DialogType.OK,
							DialogIcon.Information);
				//txtEscritura.SelectionLength = 0;
				btnNext.Focus();
			}
			else
			{
				VerAtual = 1;
			}
		}

		// SHORTCUTS NAVEGACAO BY VERSICULOS
		// =============================================================================
		private void frmLeitura_KeyDown(object sender, KeyEventArgs e)
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
			else if (e.KeyCode == Keys.End)
			{
				e.Handled = true;
				btnLast_Click(sender, e);
			}
			else if (e.KeyCode == Keys.Home)
			{
				e.Handled = true;
				btnFirst_Click(sender, e);
			}
			else if (e.KeyCode == Keys.Escape)
			{
				e.Handled = true;
				btnFechar_Click(sender, e);
			}
			else if (e.KeyCode == Keys.PageUp)
			{
				e.Handled = true;
				NextCapitulo();
			}
			else if (e.KeyCode == Keys.PageDown)
			{
				e.Handled = true;
				PrevCapitulo();
			}
			else if (e.KeyCode == Keys.P)
			{
				e.Handled = true;
				btnLinguagens_Click(sender, e);
			}
			else if (e.KeyCode == Keys.H)
			{
				e.Handled = true;
				OpenHistorico();
			}

		}

		// PROXIMO CAPITULO
		// =============================================================================
		private void NextCapitulo()
		{
			byte maxCapitulos = _LivroAtual.Capitulos;

			if(Versiculo.Capitulo < maxCapitulos)
			{
				int proxVersiculo = Convert.ToInt16(Versiculo.Capitulo) + 1;
				GetVersiculos(Versiculo.IDLinguagem, (byte)Versiculo.IDLivro, (byte)proxVersiculo, 1);
			}
			else
			{
				AbrirDialog("Já estamos no ULTIMO capítulo do livro de: " + _LivroAtual.Livro.ToUpper(),
							"Último Capítulo",
							DialogType.OK,
							DialogIcon.Information);
			}

		}

		// ANTERIOR CAPITULO
		// =============================================================================
		private void PrevCapitulo()
		{
			byte maxCapitulos = _LivroAtual.Capitulos;

			if (Versiculo.Capitulo > 1)
			{
				int prevVersiculo = Convert.ToInt16(Versiculo.Capitulo) - 1;
				GetVersiculos(Versiculo.IDLinguagem, (byte)Versiculo.IDLivro, (byte)prevVersiculo, 1);
			}
			else
			{
				AbrirDialog("Já estamos no PRIMEIRO capítulo do livro de: " + _LivroAtual.Livro.ToUpper(),
							"Primeiro Capítulo",
							DialogType.OK,
							DialogIcon.Information);
			}

		}

		#endregion

		#region LINGUAGENS

		private void miLinguagem_Click(object sender, EventArgs e)
		{
			ToolStripMenuItem menu = (ToolStripMenuItem)sender;
			byte IDLing = Convert.ToByte(menu.Tag);
			GetVersiculos(IDLing, (byte)Versiculo.IDLivro , (byte)Versiculo.Capitulo, (byte)Versiculo.Versiculo);
		}

		private void mnuLinguagens_Opening(object sender, System.ComponentModel.CancelEventArgs e)
		{

			ContextMenuStrip cms = (ContextMenuStrip)sender;

			foreach (ToolStripMenuItem item in cms.Items)
			{
				if (Convert.ToByte(item.Tag) == _IDLinguagemAtual)
					item.BackColor = Color.Moccasin;
				else
					item.BackColor = Color.WhiteSmoke;
			}
		}

		#endregion

		#region OTHER FUNCTIONS

		// OPEN HISTORICO FORM
		private void OpenHistorico()
		{
			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				pnlHistorico.Width = 450;
				pnlHistorico.Location = new Point(ClientSize.Width - 450, 100);

				using (frmHistorico frm = new frmHistorico(this))
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
				AbrirDialog("Uma exceção ocorreu ao Abrir o histórico de Leituras..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}
		}

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
		private void SaveLastVersiculo()
		{
			FuncoesGlobais.SaveDefault("IDVersiculoUltimo", Versiculo.IDVersiculo.ToString());
		}

		private void frmLeitura_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			e.IsInputKey = true;
		}

		#endregion

		private void btnHistorico_Click(object sender, EventArgs e)
		{
			OpenHistorico();
		}

		private void label1_Click(object sender, EventArgs e)
		{
			OpenHistorico();
		}
	}

}
