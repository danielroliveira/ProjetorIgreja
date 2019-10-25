using CamadaBLL;
using CamadaDTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static CamadaUI.Utilidades;

namespace CamadaUI.Escritura
{
	public partial class frmEscrituraEscolher : Modals.frmModFinBorder
	{

		private byte _IDTestamento;
		private clLivro _Livro = null;
		private List<clLivro> listLivros = null;
		private string _DBPath;

		// SUB NEW
		public frmEscrituraEscolher(string DBPath, byte Testamento = 1, byte IDLivro = 1)
		{
			InitializeComponent();

			// define o path do DB
			_DBPath = DBPath;
			// Get List of Livros
			GetLivrosList();
			// Define Testamento
			IDTestamento = Testamento;
		}

		// GET LIVROS LIST
		private void GetLivrosList()
		{
			try
			{
				VersiculoBLL vBLL = new VersiculoBLL(_DBPath);
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
		}

		// PROPERTY ID TESTAMENTO
		private byte IDTestamento
		{
			get => _IDTestamento;
			set
			{

				if (_IDTestamento != value)
				{
					if (value == 1)
					{
						btnAntigoTestamento.BackColor = Color.SlateGray;
						btnAntigoTestamento.InnerBorderColor = Color.SlateGray;
						btnAntigoTestamento.ShineColor = Color.Linen;
						btnAntigoTestamento.ForeColor = Color.Black;

						btnNovoTestamento.BackColor = Color.LightGray;
						btnNovoTestamento.InnerBorderColor = Color.DarkGray;
						btnNovoTestamento.ShineColor = Color.White;
						btnNovoTestamento.ForeColor = Color.DimGray;

					}
					else
					{
						btnAntigoTestamento.BackColor = Color.LightGray;
						btnAntigoTestamento.InnerBorderColor = Color.DarkGray;
						btnAntigoTestamento.ShineColor = Color.White;
						btnAntigoTestamento.ForeColor = Color.DimGray;

						btnNovoTestamento.BackColor = Color.SlateGray;
						btnNovoTestamento.InnerBorderColor = Color.SlateGray;
						btnNovoTestamento.ShineColor = Color.Linen;
						btnNovoTestamento.ForeColor = Color.Black;
					}
				}


				_IDTestamento = value;
			}
		}

		private void btnAntigoTestamento_Click(object sender, EventArgs e)
		{
			IDTestamento = 1;
			pnlAT.Visible = true;
			pnlNT.Visible = false;
		}

		private void btnNovoTestamento_Click(object sender, EventArgs e)
		{
			IDTestamento = 2;
			pnlAT.Visible = false;
			pnlNT.Visible = true;
		}

		// CHANGE LIVRO SELECTED
		private void btnLivro_Click(object sender, EventArgs e)
		{
			Button btn = (Button)sender;

			// change the color of selected livro
			btn.BackColor = Color.NavajoWhite;
			if (_Livro != null && _Livro.IDLivro > 0)
			{
				if(pnlAT.Controls["btnLivro" + _Livro.IDLivro] != null)
				{
					Button oldBtn = (Button)pnlAT.Controls["btnLivro" + _Livro.IDLivro];
					oldBtn.BackColor = Color.White;
				}
				else
				{
					Button oldBtn = (Button)pnlNT.Controls["btnLivro" + _Livro.IDLivro];
					oldBtn.BackColor = Color.White;
				}

				/*if (IDTestamento == 1)
				{
				}
				else
				{
				}*/
			}

			// get LIVRO ID by button name
			string name = btn.Name;
			byte livro = Convert.ToByte(name.Substring(8));
			
			// define NEW selected Livro
			_Livro = listLivros.Find(x => x.IDLivro == livro);     //livro;
			lblVersiculo.Text = _Livro.Livro;
		}

		// CLOSE FORM
		private void btnClose_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
