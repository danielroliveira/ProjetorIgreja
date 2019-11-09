using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CamadaDTO;
using CamadaBLL;
using static CamadaUI.Utilidades;

namespace CamadaUI.Louvor
{
	public partial class frmLouvorEditar : CamadaUI.Modals.frmModFinBorder
	{
		clLouvor _louvor;
		Form _formOrigem;
		LouvorBLL lBLL = new LouvorBLL(FuncoesGlobais.DBPath());
		BindingSource bindLouvor = new BindingSource();
		Image FavAtivo = Properties.Resources.favorite_64;
		Image FavDesativo = Properties.Resources.favorite_64_disable;
		private byte _Favorito;
		private bool _Ativo;

		#region SUB NEW | OPEN

		public frmLouvorEditar(clLouvor louvor, Form formOrigem)
		{
			InitializeComponent();
			_formOrigem = formOrigem;
			_louvor = louvor;
			PreencheDataBindings();
			_louvor.Alterado += _louvor_Alterado;

			Favorito = _louvor.Favorito;
			Ativo = _louvor.Ativo;
			bindLouvor.CancelEdit();

		}

		private void _louvor_Alterado()
		{
			btnSalvar.Enabled = true;
		}

		// PROPERTY ATIVO
		// =============================================================================
		private bool Ativo
		{
			get => _Ativo;
			set
			{
				_Ativo = value;
				if (_Ativo)
				{
					btnAtivo.Image = Properties.Resources.Switch_ON_PEQ;
					btnAtivo.Text = "Louvor Ativo";
				}
				else
				{
					btnAtivo.Image = Properties.Resources.Switch_OFF_PEQ;
					btnAtivo.Text = "Louvor Inativo";
				}
			}
		}

		#endregion

		#region DATABINDING

		// PREENCHE O DATABIND
		private void PreencheDataBindings()
		{
			bindLouvor.DataSource = _louvor;

			lblProjecaoPath.DataBindings.Add("Text", bindLouvor, "ProjecaoPath");
			txtTitulo.DataBindings.Add("Text", bindLouvor, "Titulo", true, DataSourceUpdateMode.OnPropertyChanged);
			lblEscolhidoCount.DataBindings.Add("Text", bindLouvor, "EscolhidoCount");
			
			// combos load
			CarregaComboCategoria();

			// handler Format DataBinding
			lblEscolhidoCount.DataBindings["Text"].Format += Format_EscolhidoCount;

		}

		private void Format_EscolhidoCount(object sender, ConvertEventArgs e)
		{
			if((short)e.Value == 0)
			{
				e.Value = "Nunca foi Escolhido";
			}
			else if((short)e.Value == 1)
			{
				e.Value = "01 Vez Escolhido";
			}
			else
			{
				e.Value = $"{e.Value} Vezes Escolhido";
			}
		}

		// PREENCHE O COMBO CATEGORIA
		private void CarregaComboCategoria()
		{

			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				cmbIDCategoria.DataSource = lBLL.GetLouvorCategoriaDT();
				cmbIDCategoria.ValueMember = "IDCategoria";
				cmbIDCategoria.DisplayMember = "Categoria";
				cmbIDCategoria.DataBindings.Add("SelectedValue", bindLouvor, "IDCategoria", true, DataSourceUpdateMode.OnPropertyChanged);
				
			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao obter a lista de categorias..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}

		}




		#endregion

		#region BUTTONS

		// BTN SALVAR
		private void btnSalvar_Click(object sender, EventArgs e)
		{
			// check size of Titulo
			// ---------------------------------------------------------------------------
			if(txtTitulo.Text.Trim().Length < 5)
			{
				AbrirDialog("O Título deve ter pelo menos CINCO caracteres...",
					"Título Inválido", DialogType.OK, DialogIcon.Exclamation);
				return;
			} else if (txtTitulo.Text.Length > 100)
			{
				AbrirDialog("O Título deve ter pelo no máximo 100 caracteres...",
					"Título Inválido", DialogType.OK, DialogIcon.Exclamation);
				return;
			}

			// Save Registry
			// ---------------------------------------------------------------------------
			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				if(_louvor.IDCategoria != null)
					_louvor.Categoria = cmbIDCategoria.Text;
				lBLL.UpdateLouvor(_louvor);
				bindLouvor.EndEdit();

				AbrirDialog("Registro de Louvor salvo com sucesso!", "Registro Salvo");

				// close
				DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Salvar o registro de Louvor..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}
		}

		// BTN ATIVO/INATIVO
		private void btnAtivo_Click(object sender, EventArgs e)
		{
			_louvor.Ativo = !_louvor.Ativo;
			Ativo = !Ativo;
		}

		// BTN FECHAR CANCELAR
		private void btnCancelar_Click(object sender, EventArgs e)
		{
			if(_louvor.RegistroAlterado)
				bindLouvor.CancelEdit();
			DialogResult = DialogResult.Cancel;
			Close();
		}

		#endregion

		#region OTHER FUNCTIONS

		private void lblProjecaoPath_TextChanged(object sender, EventArgs e)
		{
			ResizeFontLabel(lblProjecaoPath);
		}

		#endregion

		#region VISUAL AND DESIGN

		//Paint event handler for your Panel
		private void pnlFavorito_Paint(object sender, PaintEventArgs e)
		{
			Rectangle rect = new Rectangle(0, 0, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1);
			Pen pen = new Pen(Color.Silver, 2);
			e.Graphics.DrawRectangle(pen, rect);
		}

		#endregion
			   
		#region FAVORITOS PIC

		private byte Favorito {
			get => _Favorito;
			set
			{
				if(value == 1)
				{
					if(_Favorito == 1)
						value = 0;
				}

				_Favorito = value;
				_louvor.Favorito = value;

				switch (value)
				{
					case 0:
						pctFav1.Image = FavDesativo;
						pctFav2.Image = FavDesativo;
						pctFav3.Image = FavDesativo;
						pctFav4.Image = FavDesativo;
						pctFav5.Image = FavDesativo;
						break;
					case 1:
						pctFav1.Image = FavAtivo;
						pctFav2.Image = FavDesativo;
						pctFav3.Image = FavDesativo;
						pctFav4.Image = FavDesativo;
						pctFav5.Image = FavDesativo;
						break;
					case 2:
						pctFav1.Image = FavAtivo;
						pctFav2.Image = FavAtivo;
						pctFav3.Image = FavDesativo;
						pctFav4.Image = FavDesativo;
						pctFav5.Image = FavDesativo;
						break;
					case 3:
						pctFav1.Image = FavAtivo;
						pctFav2.Image = FavAtivo;
						pctFav3.Image = FavAtivo;
						pctFav4.Image = FavDesativo;
						pctFav5.Image = FavDesativo;
						break;
					case 4:
						pctFav1.Image = FavAtivo;
						pctFav2.Image = FavAtivo;
						pctFav3.Image = FavAtivo;
						pctFav4.Image = FavAtivo;
						pctFav5.Image = FavDesativo;
						break;
					case 5:
						pctFav1.Image = FavAtivo;
						pctFav2.Image = FavAtivo;
						pctFav3.Image = FavAtivo;
						pctFav4.Image = FavAtivo;
						pctFav5.Image = FavAtivo;
						break;
					default:
						pctFav1.Image = FavDesativo;
						pctFav2.Image = FavDesativo;
						pctFav3.Image = FavDesativo;
						pctFav4.Image = FavDesativo;
						pctFav5.Image = FavDesativo;
						break;
				}
			}
		}

		private void picFav_Click(object sender, EventArgs e)
		{
			try
			{
				Control pic = (Control)sender;
				Favorito = Convert.ToByte(pic.Tag);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				throw;
			}

		}

		#endregion

	}
}
