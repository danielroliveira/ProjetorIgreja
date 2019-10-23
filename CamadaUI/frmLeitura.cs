using CamadaBLL;
using CamadaDTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CamadaUI
{
	public partial class frmLeitura : Form
	{

		private byte _verAtual;
		private byte _capituloAtual;
		private byte _IDLivroAtual;
		private byte _IDLinguagemAtual;

		private byte verTotal;
		List<clVersiculo> verList = null;

		// VOID NEW
		public frmLeitura()
		{
			InitializeComponent();

			pnlTop.BackColor = Properties.Settings.Default.PanelTopColor;
			
			GetVersiculos(1,1,1,1);
			
		}

		// CLOSE FORM
		private void btnFechar_Click(object sender, EventArgs e)
		{
			Application.OpenForms["frmPrincipal"].Visible = true;
			Close();
		}

		// GET LIST VERSICULOS
		private void GetVersiculos(byte IDLinguagem, byte IDLivro, byte Capitulo, byte Versiculo)
		{
			try
			{
				string DBPath = @"D:\Projetos\ProjetorIgreja\Database\ProjetorDB.MDB";
				VersiculoBLL vBLL = new VersiculoBLL(DBPath);

				verList = vBLL.GetVersiculoList(IDLinguagem, IDLivro, Capitulo);
				verTotal = (byte)verList.Count;
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

		// RESIZE TEXTFONT SIZE ESCRITURA
		private void txtEscritura_SizeChanged(object sender, EventArgs e)
		{
			TextBox tb = sender as TextBox;
			if (tb.Height < 10) return;
			if (tb == null) return;
			if (tb.Text == "") return;
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
					return;

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

		private void btnNext_Click(object sender, EventArgs e)
		{
			VerAtual += 1;
		}

		private void btnPrev_Click(object sender, EventArgs e)
		{
			if (VerAtual == 1) return;
			VerAtual -= 1;
		}

		private void txtEscritura_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}

		// PROPERTY VERSICULO ATUAL
		public byte VerAtual
		{
			get => _verAtual;
			set
			{
				if(value > verTotal) value = verTotal;
				
				_verAtual = value;
				txtEscritura.Text = verList[_verAtual - 1].Escritura;
			}
		}
			



	}
}
