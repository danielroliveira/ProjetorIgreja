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
using System.Drawing.Drawing2D;

namespace CamadaUI.Louvor
{
	public partial class frmLouvorEditar : CamadaUI.Modals.frmModFinBorder
	{
		clLouvor _louvor;
		Form _formOrigem;
		LouvorBLL lBLL = new LouvorBLL(FuncoesGlobais.DBPath());
		BindingSource bindLouvor = new BindingSource();

		#region SUB NEW | OPEN

		public frmLouvorEditar(clLouvor louvor, Form formOrigem)
		{
			InitializeComponent();
			_formOrigem = formOrigem;
			_louvor = louvor;
			PreencheDataBindings();
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

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
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

		private void lblProjecaoPath_TextChanged(object sender, EventArgs e)
		{
			ResizeFontLabel(lblProjecaoPath);
		}
	}
}
