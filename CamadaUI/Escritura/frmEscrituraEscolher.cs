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
		private int _Etapa = 1;
		private List<clLivro> listLivros = null;
		private string _DBPath;

		public clVersiculo SelVersiculo = new clVersiculo();
		
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
						pnlAT.Visible = true;
						pnlNT.Visible = false;
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
						pnlAT.Visible = false;
						pnlNT.Visible = true;
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

		// PROPERTY LIVRO
		private clLivro Livro
		{
			get => _Livro;
			set
			{
				_Livro = value;
				lblVersiculo.Text = _Livro.Livro;

				pnlCapitulosItems.Controls.Clear();

				for (int i = 0; i < _Livro.Capitulos; i++)
				{

					Button btnCap = new Button(){
						FlatStyle = FlatStyle.Flat,
						Font = new Font("Geometr706 BlkCn BT", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0),
						Location = new Point(11, 3),
						Margin = new Padding(3, 3, 3, 3),
						Name = $"btnCap{i + 1}",
						Size = new Size(54, 30),
						TabIndex = i + 1,
						Text = $"{i + 1}",
						UseVisualStyleBackColor = true,
					};

					btnCap.FlatAppearance.BorderSize = 0;
					btnCap.FlatAppearance.MouseDownBackColor = Color.Wheat;
					btnCap.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
					btnCap.Click += new EventHandler(btnCap_Click);

					pnlCapitulosItems.Controls.Add(btnCap);
				};

				pnlAT.Visible = false;
				pnlNT.Visible = false;
				pnlCapitulos.Visible = true;
			}
		}

		public int Etapa
		{
			get => _Etapa;
			set
			{
				_Etapa = value;
				switch (_Etapa)
				{
					case 1: // busca LIVRO
						SelVersiculo.IDLivro = null;
						SelVersiculo.Capitulo = null;
						SelVersiculo.Versiculo = null;
						break;
					case 2: // busca CAPITULO

						break;
					case 3: // busca VERSICULO

						break;
					default:
						break;
				}
			}
		}

		private void btnAntigoTestamento_Click(object sender, EventArgs e)
		{
			IDTestamento = 1;
		}

		private void btnNovoTestamento_Click(object sender, EventArgs e)
		{
			IDTestamento = 2;
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
			}

			// get LIVRO ID by button name
			string name = btn.Name;
			byte IDLivro = Convert.ToByte(name.Substring(8));
			
			// define NEW selected Livro
			Livro = listLivros.Find(x => x.IDLivro == IDLivro);

		}

		// CLOSE FORM
		private void btnClose_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void btnCap_Click(object sender, EventArgs e)
		{

		}
	}
}
