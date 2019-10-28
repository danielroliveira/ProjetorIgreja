﻿using CamadaBLL;
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
		private byte _verAtual;
		private byte _capituloAtual;
		private clLivro _LivroAtual;
		private byte _IDLinguagemAtual;

		private clVersiculo Versiculo;
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

			pnlTop.BackColor = Properties.Settings.Default.PanelTopColor;
			lblLivro.BackColor = pnlInfo.BackColor;
			DBPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"ProjetorDB.mdb");
			GetLinguagens();
			GetLivrosList();
			GetVersiculos(1, 1, 1, 1);

			// selecionar a fonte
			// ---------------------------------------------------------------------------------------------
			//txtEscritura.Font = new Font("Verdana", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtEscritura.Font = new Font("Ezra SIL", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtEscritura_SizeChanged(txtEscritura, new EventArgs());
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
		private void GetVersiculos(byte IDLinguagem, byte IDLivro, byte Capitulo, byte Versiculo)
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

		// GET LIVROS LIST
		// =============================================================================
		private void GetLivrosList()
		{
			try
			{
				// Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				VersiculoBLL vBLL = new VersiculoBLL(DBPath);
				listLivros = vBLL.GetLivroList();
			}
			catch (Exception ex)
			{
				AbrirDialog(
					"Um exceção ocorreu ao obter a Lista de Livros" +
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

		// GET LIST LINGUAGENS
		// =============================================================================
		private void GetLinguagens()
		{
			try
			{
				// Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				VersiculoBLL vBLL = new VersiculoBLL(DBPath);
				LinguagemList = vBLL.GetLinguagemList();

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

			using (Escritura.frmEscrituraEscolher frm = new Escritura.frmEscrituraEscolher(verOrigem, this))
			{
				frm.ShowDialog();
				if (frm.DialogResult == DialogResult.OK)
				{
					verList = frm.ListVersiculos;
					verMax = (byte)verList.Count;
					VerAtual = (byte)frm.SelVersiculo.Versiculo;
				}
			};


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
				txtEscritura.SelectionLength = 0;
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
				txtEscritura.SelectionLength = 0;
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

		private void frmLeitura_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			e.IsInputKey = true;
		}

		#endregion

		private void frmLeitura_Shown(object sender, EventArgs e)
		{
			// send first PreviewKey
			SendKeys.Send("{LEFT}");

		}
	}

}
