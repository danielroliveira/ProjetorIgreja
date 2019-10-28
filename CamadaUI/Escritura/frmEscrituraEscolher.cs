using CamadaBLL;
using CamadaDTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CamadaUI.Escritura
{
	public partial class frmEscrituraEscolher : Modals.frmModFinBorder
	{
		private byte _IDLinguagem;
		private byte _IDTestamento;
		private clLivro _Livro = null;
		private frmLeitura _formOrigem;
		private byte _Capitulo;

		private int _Etapa = 1; // etapas da escolha do versiculo
		public clVersiculo SelVersiculo = null; // versiculo escolhido
		public List<clVersiculo> ListVersiculos = null; // lista dos versiculos escolhidos

		#region NEW AND PROPERTIES

		// SUB NEW
		public frmEscrituraEscolher(clVersiculo versiculoInicial, frmLeitura formOrigem)
		{
			InitializeComponent();

			_formOrigem = formOrigem;
			// Define Linguagem Inicial
			_IDLinguagem = versiculoInicial.IDLinguagem;
			// Define Testamento Inicial
			IDTestamento = versiculoInicial.Testamento;
			// Mark Inicial Livro
			if(versiculoInicial != null && versiculoInicial.IDLivro > 0)
				MarkLivro((byte)versiculoInicial.IDLivro);
			// Define Etapa
			Etapa = 1;
		}

		// PROPERTY ETAPAS DA ESCOLHA DO VERSICULO
		// =============================================================================
		public int Etapa
		{
			get => _Etapa;
			set
			{
				_Etapa = value;
				switch (_Etapa)
				{
					case 1: // buscando LIVRO
						SelVersiculo = new clVersiculo();
						SelVersiculo.Testamento = IDTestamento;
						pnlCapitulos.Visible = false;
						btnAntigoTestamento.Visible = true;
						btnNovoTestamento.Visible = true;
						lblVersiculo.Text = "Escolha o Livro";

						if (IDTestamento == 1)
						{
							pnlAT.Visible = true;
							pnlNT.Visible = false;
						}
						else
						{
							pnlAT.Visible = false;
							pnlNT.Visible = true;
						}

						SelVersiculo.IDLivro = null;
						SelVersiculo.Capitulo = null;
						SelVersiculo.Versiculo = null;
						break;

					case 2: // buscando CAPITULO
						SelVersiculo.IDLivro = _Livro.IDLivro;
						SelVersiculo.Livro = _Livro.Livro;
						lblVersiculo.Text = _Livro.Livro;
						lblPanelCapTitulo.Text = "Escolha o Capítulo";

						pnlAT.Visible = false;
						pnlNT.Visible = false;
						pnlCapitulos.Visible = true;
						btnAntigoTestamento.Visible = false;
						btnNovoTestamento.Visible = false;

						break;

					case 3: // buscando VERSICULO
						SelVersiculo.Capitulo = Capitulo;
						lblVersiculo.Text = $"{_Livro.Livro} cap. {_Capitulo}";
						lblPanelCapTitulo.Text = "Escolha o Versículo";

						pnlAT.Visible = false;
						pnlNT.Visible = false;
						pnlCapitulos.Visible = true;
						btnAntigoTestamento.Visible = false;
						btnNovoTestamento.Visible = false;
						break;

					default:
						Etapa = 1;
						break;
				}
			}
		}

		// PROPERTY ID TESTAMENTO
		// =============================================================================
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
		// =============================================================================
		private clLivro Livro
		{
			get => _Livro;
			set
			{
				_Livro = value;
				
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
			}
		}

		// PROPERTY CAPITULO
		// =============================================================================
		private byte Capitulo
		{
			get => _Capitulo;
			set
			{
				_Capitulo = value;
				// get DB list of versiculos
				GetVersiculos(_IDLinguagem, Livro.IDLivro, _Capitulo);

				// Clear buttons Versiculos
				pnlCapitulosItems.Controls.Clear();

				// Add List of Buttons Versiculos
				for (int i = 0; i < ListVersiculos.Count; i++)
				{

					Button btnCap = new Button()
					{
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
					btnCap.Click += new EventHandler(btnVersiculo_Click);

					pnlCapitulosItems.Controls.Add(btnCap);
				};
			}
		}

		#endregion

		#region GET DATA

		// GET LIST VERSICULOS
		// =============================================================================
		private void GetVersiculos(byte IDLinguagem, byte IDLivro, byte Capitulo)
		{
			try
			{
				// Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;
				// Get
				VersiculoBLL vBLL = new VersiculoBLL(_formOrigem.DBPath);
				ListVersiculos = vBLL.GetVersiculoList(IDLinguagem, IDLivro, Capitulo);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				// Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}	
		}

		#endregion

		#region BUTTONS FUNCTION

		// DEFINE TESTAMENTO
		// =============================================================================
		private void btnTestamento_Click(object sender, EventArgs e)
		{
			Button btn = sender as Button;

			if(btn.Name == "btnAntigoTestamento")
				IDTestamento = 1;
			else
				IDTestamento = 2;
		}

		// CHANGE LIVRO SELECTED
		// =============================================================================
		private void btnLivro_Click(object sender, EventArgs e)
		{
			Button btn = (Button)sender;

			// get LIVRO ID by button name
			string name = btn.Name;
			byte IDLivro = Convert.ToByte(name.Substring(8));
			MarkLivro(IDLivro);

			// define NEW selected Livro
			Livro = _formOrigem.listLivros.Find(x => x.IDLivro == IDLivro);
			Etapa = 2;
		}

		// CHANGE CAPITULO SELECTED
		// =============================================================================
		private void btnCap_Click(object sender, EventArgs e)
		{
			Button btn = (Button)sender;

			// change the color of selected livro
			btn.BackColor = Color.NavajoWhite;
			if (Capitulo > 0)
			{
				Button oldBtn = (Button)pnlCapitulosItems.Controls["btnCap" + Capitulo];
				if(oldBtn !=null && !btn.Equals(oldBtn))
					oldBtn.BackColor = Color.Transparent;
			}

			// get CAPITULO NUMBER by button name
			string name = btn.Name;
			Capitulo = Convert.ToByte(name.Substring(6));

			// get VERSICULO LIST
			Etapa = 3;
		}

		// SELECT VERSICULO
		// =============================================================================
		private void btnVersiculo_Click(object sender, EventArgs e)
		{
			Button btn = (Button)sender;

			// change the color of selected livro
			btn.BackColor = Color.NavajoWhite;

			// get CAPITULO NUMBER by button name
			string name = btn.Name;

			// define SEL Versiculo
			SelVersiculo = ListVersiculos.Find(v => v.Versiculo == Convert.ToByte(name.Substring(6)));
			DialogResult = DialogResult.OK;
		}

		// BTN VOLTAR ETAPA
		// =============================================================================
		private void btnVoltar_Click(object sender, EventArgs e)
		{
			if(Etapa == 1) // livro
			{
				btnClose_Click(sender, e);
			}
			else if(Etapa == 2) // capitulo
			{
				SelVersiculo.Capitulo = null;
				SelVersiculo.IDLivro = null;
				Etapa = 1;
			}
			else if(Etapa == 3) // versiculo
			{
				Livro = _formOrigem.listLivros.Find(l => l.IDLivro == SelVersiculo.IDLivro);
				SelVersiculo.Capitulo = null;
				Etapa = 2;

			}
		}

		// CLOSE FORM
		// ---------------------------------------------------------------------------
		private void btnClose_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		#endregion

		#region OTHER FUNCTIONS

		private void MarkLivro(byte IDLivro)
		{
			// change the color of selected livro
			foreach (Control button in pnlAT.Controls )
			{
				if(button.GetType().Equals(typeof(Button)) && button.Name == $"btnLivro{IDLivro}")
					button.BackColor = Color.NavajoWhite;
				else
					button.BackColor = Color.White;
			}

			foreach (Control button in pnlNT.Controls)
			{
				if (button.GetType().Equals(typeof(Button)) && button.Name == $"btnLivro{IDLivro}")
					button.BackColor = Color.NavajoWhite;
				else
					button.BackColor = Color.White;
			}
		}

		private void frmEscrituraEscolher_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				e.Handled = true;
				btnClose_Click(sender, e);
			}
		}

		#endregion

		private void frmEscrituraEscolher_Activated(object sender, EventArgs e)
		{
			Panel pnl = (Panel)_formOrigem.Controls["pnlTop"];
			pnl.BackColor = Color.Silver;
		}

		private void frmEscrituraEscolher_FormClosed(object sender, FormClosedEventArgs e)
		{
			Panel pnl = (Panel)_formOrigem.Controls["pnlTop"];
			pnl.BackColor = Properties.Settings.Default.PanelTopColor;
		}
	}
}
