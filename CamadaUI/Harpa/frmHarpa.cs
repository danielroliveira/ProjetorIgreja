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
		private int CountEstrofes;
		private bool HaveCoro;

		private bool NavDisabled;
		public string DBPath;

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
			bindEstrofe.CurrentChanged += BindEstrofe_CurrentChanged;
			GetDadosInicial();
			
			// selecionar a fonte
			// ---------------------------------------------------------------------------------------------
			//txtEscritura.Font = new Font("Verdana", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtEstrofe.Font = new Font("Ezra SIL", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtEstrofe_SizeChanged(txtEstrofe, new EventArgs());

		}

		private void BindEstrofe_CurrentChanged(object sender, EventArgs e)
		{
			clHinoEstrofe curEstrofe = (clHinoEstrofe)bindEstrofe.Current;
			txtEstrofe.Text = curEstrofe.Estrofe;
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

		// PROPERTY VERSICULO ATUAL
		/*private byte VerAtual
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
							   
				txtEstrofe.Text = Versiculo.Escritura;
				lblHinoTitulo.Text = $"{Versiculo.Livro} {Versiculo.Capitulo}:{Versiculo.Versiculo}";
				lblNavegacao.Text = $"Ver. {Versiculo.Versiculo} de {verMax}";

				lblHinoNumero.Text = LinguagemList.Find(x => x.IDLinguagem == _IDLinguagemAtual).Linguagem;

				CheckNavButtonsState();
				SaveLastVersiculo();
			}
		}*/

		// CHECK AND CHANGE NAV BUTTONS STATE (ENABLED / DISABLED)
		private void CheckNavButtonsState()
		{
			/*if (VerAtual >= verMax || VerAtual <= 1) // disabled buttons
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
			}*/
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
				estrofeList = hBLL.GetEstrofesListByID(IDHino);
				// define databind
				bindEstrofe.DataSource = estrofeList;
				// Define Max
				CountEstrofes = (byte)estrofeList.Count;
				//Define Estrofe Inicial;
				bindEstrofe.Position = 0;
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

		// NEXT
		private void btnNext_Click(object sender, EventArgs e)
		{
			bindEstrofe.Position += 1;
		}

		// PREV
		private void btnPrev_Click(object sender, EventArgs e)
		{
			if (bindEstrofe.Position == 0)
			{
				AbrirDialog("Já estamos na PRIMEIRA ESTROFE deste HINO...",
							"Primeira Estrofe",
							DialogType.OK,
							DialogIcon.Information);
				//txtEscritura.SelectionLength = 0;
				btnNext.Focus();
			}
			else
			{
				bindEstrofe.Position -= 1;
			}
		}

		// SHORTCUTS NAVEGACAO BY VERSICULOS
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
		}

		// PROXIMO CAPITULO
		// =============================================================================
		private void NextHino()
		{
			/* byte maxCapitulos = _LivroAtual.Capitulos;

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
			} */

		}

		// ANTERIOR CAPITULO
		// =============================================================================
		private void PrevHino()
		{
			/* byte maxCapitulos = _LivroAtual.Capitulos;

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
			*/
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
		private void SaveLastVersiculo()
		{
			clHinoEstrofe est = (clHinoEstrofe)bindEstrofe.Current;
			FuncoesGlobais.SaveDefault("IDHinoUltimo", est.IDHino.ToString());
		}

		private void frmHarpa_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			e.IsInputKey = true;
		}

		#endregion

	}

}
