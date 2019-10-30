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

namespace CamadaUI.Escritura
{
	public partial class frmHistorico : Modals.frmModFinBorder
	{
		private List<clHistorico> HistoricoList;
		private frmLeitura _formOrigem;

		private int rowHeight = 32;
		private Color BackupRowBackColor;

		#region NEW | GET

		// SUB NEW
		// =============================================================================
		public frmHistorico(frmLeitura formOrigem)
		{
			InitializeComponent();

			_formOrigem = formOrigem;
			GetHistorico();
			ConfiguraDataGrid();

			int L = _formOrigem.Width;
			Point ptLocation = new Point(L - Width, 100);
			
			Location = ptLocation;
			Size = new Size(Width, formOrigem.Size.Height - 155);
		}

		// ON SHOW
		// =============================================================================
		private void frmHistorico_Shown(object sender, EventArgs e)
		{
			// find versiculo in listagem
			clVersiculo verAtual = _formOrigem.Versiculo;

			foreach (DataGridViewRow row in dgvListagem.Rows)
			{
				clVersiculo histVer = (clVersiculo)row.DataBoundItem;
				if (verAtual.IDVersiculo == histVer.IDVersiculo) // if finded select
				{
					row.Selected = true;
				}
			}
		}

		// GET HISTORICO
		// =============================================================================
		private void GetHistorico()
		{
			try
			{
				// Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				VersiculoBLL vBLL = new VersiculoBLL(_formOrigem.DBPath);
				HistoricoList = vBLL.GetHistorico();

			}
			catch (Exception ex)
			{
				AbrirDialog("Ocorreu uma execeção ao obter a lista de Histórico \n" +
					ex.Message, "Excecão", DialogType.OK, DialogIcon.Exclamation);
			}
			finally
			{
				// Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}
		}

		#endregion

		#region DATAGRID FUNCTIONS

		private void ConfiguraDataGrid()
		{
			// --- limpa as colunas do datagrid
			dgvListagem.Columns.Clear();
			dgvListagem.AutoGenerateColumns = false;

			// altera as propriedades importantes
			dgvListagem.MultiSelect = false;
			dgvListagem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvListagem.ColumnHeadersVisible = false;
			dgvListagem.AllowUserToResizeRows = false;
			dgvListagem.AllowUserToResizeColumns = false;
			dgvListagem.RowHeadersVisible = false;
			dgvListagem.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dgvListagem.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dgvListagem.StandardTab = true;

			dgvListagem.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
			dgvListagem.RowHeadersWidth = rowHeight;
			dgvListagem.RowTemplate.Height = rowHeight;
			dgvListagem.RowTemplate.MinimumHeight = rowHeight;
		
			// --- configura o DataSource
			dgvListagem.DataSource = HistoricoList;

			// --- formata as colunas do datagrid
			FormataColunas_Itens();
		}

		private void FormataColunas_Itens()
		{
			// COLUNA ENDERECO
			clnReferencia.DataPropertyName = "Referencia";
			clnReferencia.Resizable = DataGridViewTriState.False;
			clnReferencia.Visible = true;
			clnReferencia.ReadOnly = true;
			//clnEndereco.DefaultCellStyle.Format = "0000";
			clnReferencia.SortMode = DataGridViewColumnSortMode.NotSortable;
			clnReferencia.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

			// COLUNA ESCRITURA
			clnEscritura.DataPropertyName = "Escritura";
			clnEscritura.Resizable = DataGridViewTriState.False;
			clnEscritura.Visible = true;
			clnEscritura.ReadOnly = true;
			clnEscritura.SortMode = DataGridViewColumnSortMode.NotSortable;
			clnEscritura.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

			// --- adiciona as colunas editadas
			dgvListagem.Columns.AddRange(new DataGridViewColumn[] {clnReferencia, clnEscritura});
		}


		private void dgvListagem_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex == -1) return;
			// --- backup actual color
			BackupRowBackColor = dgvListagem.Rows[e.RowIndex].DefaultCellStyle.BackColor;
			// --- change to new color
			dgvListagem.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightSteelBlue;
		}

		private void dgvListagem_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex == -1)
				return;
			// --- restore backuped color
			dgvListagem.Rows[e.RowIndex].DefaultCellStyle.BackColor = BackupRowBackColor;
		}

		private void dgvListagem_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				e.Handled = true;
				EscolherVersiculo();
			}
		}

		private void dgvListagem_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex == -1)
				return;
			EscolherVersiculo();
		}

		#endregion

		#region OTHER FUNCTIONS

		private void EscolherVersiculo()
		{
			clHistorico hist = (clHistorico)dgvListagem.SelectedRows[0].DataBoundItem;
			_formOrigem.GetVersiculos(hist.IDLinguagem, (byte)hist.IDLivro, (byte)hist.Capitulo, (byte)hist.Versiculo);
		}

		#endregion

		#region BUTTONS FUNCTION

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}


		#endregion

		// PRESS ESC TO CLOSE
		// =============================================================================
		private void frmHistorico_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				e.Handled = true;
				btnClose_Click(sender, e);
			}
		}

	}
}
