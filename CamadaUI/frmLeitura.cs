using CamadaBLL;
using CamadaDTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using static CamadaUI.Modals.AbrirDialogMessage;

namespace CamadaUI
{
	public partial class frmLeitura : Form
	{
		#region OPEN
		// ================================================================================================

		private byte _verAtual;
		private byte _capituloAtual;
		private byte _IDLivroAtual;
		private byte _IDLinguagemAtual;
		
		private clVersiculo Versiculo;
		private bool NavDisabled;

		private byte verMax;
		List<clVersiculo> verList = null;

		// VOID NEW
		public frmLeitura()
		{
			InitializeComponent();

			pnlTop.BackColor = Properties.Settings.Default.PanelTopColor;
			lblLivro.BackColor = pnlInfo.BackColor;

			GetVersiculos(1, 1, 1, 1);

		}

		// PROPERTY VERSICULO ATUAL
		public byte VerAtual
		{
			get => _verAtual;
			set
			{
				if (value > verMax)
				{
					AbrirDialog("Já estamos no ÚLTIMO versículo deste capítulo...", 
						"Último Versiculo", 
						Modals.frmMessage.DialogType.OK, 
						Modals.frmMessage.DialogIcon.Information);
					value = verMax;
				}

				_verAtual = value;
				Versiculo = verList[_verAtual - 1];
				txtEscritura.Text = Versiculo.Escritura;
				lblLivro.Text = $"{Versiculo.Livro} {Versiculo.Capitulo}:{Versiculo.Versiculo}";
				lblNavegacao.Text = $"Ver. {Versiculo.Versiculo} de {verMax}";

				CheckNavButtonsState();
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

		// GET LIST VERSICULOS
		private void GetVersiculos(byte IDLinguagem, byte IDLivro, byte Capitulo, byte Versiculo)
		{
			try
			{
				string DBPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"ProjetorDB.mdb");

				VersiculoBLL vBLL = new VersiculoBLL(DBPath);

				verList = vBLL.GetVersiculoList(IDLinguagem, IDLivro, Capitulo);
				verMax = (byte)verList.Count;
				VerAtual = Versiculo;
				_capituloAtual = Capitulo;
				_IDLivroAtual = IDLivro;
				_IDLinguagemAtual = IDLinguagem;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		#endregion

		#region BUTTONS
		// ================================================================================================

		// CLOSE FORM
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

		#region NAVEGACAO VERSICULOS
		// ================================================================================================

		// LAST
		private void btnLast_Click(object sender, EventArgs e)
		{
			if (verMax != VerAtual)	VerAtual = verMax;
			else
				AbrirDialog("Já estamos no ÚLTIMO versículo deste capítulo...",
					"Último Versiculo",
					Modals.frmMessage.DialogType.OK,
					Modals.frmMessage.DialogIcon.Information);
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
				AbrirDialog("Já estamos no PRIMEIRO versículo deste capítulo...",
							"Último Versiculo",
							Modals.frmMessage.DialogType.OK,
							Modals.frmMessage.DialogIcon.Information);
			else VerAtual -= 1;
		}

		// FIRST
		private void btnFirst_Click(object sender, EventArgs e)
		{
			if (VerAtual == 1)
				AbrirDialog("Já estamos no PRIMEIRO versículo deste capítulo...",
							"Último Versiculo",
							Modals.frmMessage.DialogType.OK,
							Modals.frmMessage.DialogIcon.Information);
			else VerAtual = 1;
		}

		#endregion

		private void frmLeitura_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Up)
			{
				e.Handled = true;
				btnLast_Click(sender, e);
			}
			else if(e.KeyCode == Keys.Left)
			{
				e.Handled = true;
				btnPrev_Click(sender, e);
			}
			else if (e.KeyCode == Keys.Right)
			{
				e.Handled = true;
				btnNext_Click(sender, e);
			}
			else if (e.KeyCode == Keys.Down)
			{
				e.Handled = true;
				btnFirst_Click(sender, e);
			}
			else if (e.KeyCode == Keys.Escape)
			{
				e.Handled = true;
				btnFechar_Click(sender, e);
			}
		}

		private void frmLeitura_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			e.IsInputKey = true;
		}

		private void btnMinimizer_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}
	}

}
