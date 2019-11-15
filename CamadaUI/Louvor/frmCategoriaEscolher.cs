using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CamadaBLL;
using static CamadaUI.Utilidades;

namespace CamadaUI.Louvor
{
	public partial class frmCategoriaEscolher : Modals.frmModFinBorder
	{
		LouvorBLL lBLL = new LouvorBLL(FuncoesGlobais.DBPath());
		public string CategoriaEscolhida;
		public short IDCategoriaEscolhida;

		public frmCategoriaEscolher()
		{
			InitializeComponent();
			GetCategoriasDT();
		}
		
		// GET CATEGORIAS OF LOUVORES
		// =============================================================================
		private void GetCategoriasDT()
		{
			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;
				lstCategorias.DataSource = lBLL.GetLouvorCategoriaDT();
			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Obter a Listagem de Categorias..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}

		}

		// BUTTON FECHAR | CANCELAR
		// =============================================================================
		private void btnCancelar_Click(object sender, EventArgs e)
		{
			IDCategoriaEscolhida = -1;
			CategoriaEscolhida = "";
			DialogResult = DialogResult.Cancel;
		}

		// BUTTON ESCOLHER
		// =============================================================================
		private void btnEscolher_Click(object sender, EventArgs e)
		{
			if (lstCategorias.SelectedItems.Count == 0)
			{
				AbrirDialog("Favor selecionar uma Categoria antes de pressionar Escolher...",
					"Selecione Categoria");
				return;
			}

			IDCategoriaEscolhida = (short)lstCategorias.SelectedItems[0].Value;
			CategoriaEscolhida = lstCategorias.SelectedItems[0].Text;
			DialogResult = DialogResult.OK;
		}

		// AO CLICAR ESCOLHER ITEM
		// =============================================================================
		private void lstCategorias_ItemActivate(object sender, ComponentOwl.BetterListView.BetterListViewItemActivateEventArgs eventArgs)
		{
			btnEscolher_Click(sender, new EventArgs());
		}

	}
}
