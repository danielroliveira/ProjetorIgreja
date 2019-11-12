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

namespace CamadaUI.Harpa
{
	public partial class frmHarpaHistorico : Modals.frmModNoBorder
	{
		private List<clHistoricoHino> HistoricoList;
		private frmHarpa _formOrigem;
		private HarpaBLL hBLL;

		private int rowHeight = 32;
		private Color BackupRowBackColor;

		// BORDER RECTANGLE
		private Rectangle rect;
		private Timer tmr = new Timer();

		#region NEW | GET

		// SUB NEW
		// =============================================================================
		public frmHarpaHistorico(frmHarpa formOrigem)
		{
			InitializeComponent();

			_formOrigem = formOrigem;
			hBLL = new HarpaBLL(formOrigem.DBPath);
			GetHistorico();
			ConfiguraDataGrid();

			int L = _formOrigem.Width;
			Point ptLocation = new Point(L - Width, 100);
			
			Location = ptLocation;
			// Size = new Size(Width, formOrigem.Size.Height - 155);

			Size = new Size(Width, 32);
			tmr.Interval = 1;
			tmr.Tick += Tmr_Tick;

			_formOrigem.pnlHistorico.Visible = false;
			btnFechar.Visible = false;
		}

		// ON SHOW
		// =============================================================================
		private void frmHarpaHistorico_Shown(object sender, EventArgs e)
		{
			// find hino in listagem
			clHarpaHino HinoAtual = _formOrigem.EstrofeAtual;

			foreach (DataGridViewRow row in dgvListagem.Rows)
			{
				clHistoricoHino hist = (clHistoricoHino)row.DataBoundItem;
				if (HinoAtual.IDHino == hist.IDHino) // if finded select
				{
					row.Selected = true;
				}
			}
		}

		// LOAD FORM: RESIZE FORM AND RECREATE BORDER
		// =============================================================================
		private void frmHarpaHistorico_Load(object sender, EventArgs e)
		{
			dgvListagem.ScrollBars = ScrollBars.None;
			//tmr.Start();
			Height = _formOrigem.Height - 155;
			btnFechar.Visible = true;
			dgvListagem.ScrollBars = ScrollBars.Vertical;
		}

		// GET HISTORICO
		// =============================================================================
		private void GetHistorico()
		{
			try
			{
				// Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				HistoricoList = hBLL.GetHistorico();

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
			// COLUNA HINO
			clnID.DataPropertyName = "IDHino";
			clnID.Resizable = DataGridViewTriState.False;
			clnID.Visible = true;
			clnID.ReadOnly = true;
			clnID.DefaultCellStyle.Format = "000";
			clnID.SortMode = DataGridViewColumnSortMode.NotSortable;
			clnID.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

			// COLUNA TITULO
			clnTitulo.DataPropertyName = "Titulo";
			clnTitulo.Resizable = DataGridViewTriState.False;
			clnTitulo.Visible = true;
			clnTitulo.ReadOnly = true;
			clnTitulo.SortMode = DataGridViewColumnSortMode.NotSortable;
			clnTitulo.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

			// --- adiciona as colunas editadas
			dgvListagem.Columns.AddRange(new DataGridViewColumn[] {clnID, clnTitulo});
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
			else if(e.KeyCode == Keys.Delete)
			{
				e.Handled = true;
				DeletarHistorico();
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
			clHistoricoHino hist = (clHistoricoHino)dgvListagem.SelectedRows[0].DataBoundItem;
			_formOrigem.GetEstrofesHinoByID((int)hist.IDHino);
		}

		private void DeletarHistorico()
		{
			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				if(dgvListagem.SelectedRows.Count == 0)
				{
					return;
				}

				clHistoricoHino hist = (clHistoricoHino)dgvListagem.SelectedRows[0].DataBoundItem;
				hBLL.DeleteHistoricoByID(hist.IDHistorico);

				// GET ITEM LIST
				GetHistorico();
				dgvListagem.DataSource = HistoricoList;
			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Excluir Histórico..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}
		}

		#endregion

		#region BUTTONS FUNCTION

		// PRESS ESC TO CLOSE
		// =============================================================================
		private void frmHarpaHistorico_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				e.Handled = true;
				btnClose_Click(sender, e);
			}
		}

		// CLOSE FORM
		// =============================================================================
		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}


		#endregion
		
		#region RESIZE FORM AND CREATE BORDER

		// TIMER TICK RESIZE FORM
		// =============================================================================
		private void Tmr_Tick(object sender, EventArgs e)
		{
			Height += 30;

			if (Height >= _formOrigem.Height - 155)
			{
				Height = _formOrigem.Height - 155;
				btnFechar.Visible = true;
				dgvListagem.ScrollBars = ScrollBars.Vertical;
				tmr.Stop();
			}
		}

		// ON RESIZE FORM
		private void frmHarpaHistorico_Resize(object sender, EventArgs e)
		{
			Refresh();
		}

		// ON PAINT CREATE BORDER
		private void frmHarpaHistorico_Paint(object sender, PaintEventArgs e)
		{
			rect = new Rectangle(0, 0, ClientSize.Width - 1, ClientSize.Height - 1);
			e.Graphics.DrawRectangle(new Pen(Color.SlateGray, 3),
									 rect);
		}

		#endregion

	}
}
