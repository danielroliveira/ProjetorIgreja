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
	public partial class frmLouvorHistorico : Modals.frmModNoBorder
	{
		private List<clHistoricoLouvor> HistoricoList;
		private frmLouvorLista _formOrigem;
		private LouvorBLL lBLL = new LouvorBLL(FuncoesGlobais.DBPath());

		private int rowHeight = 32;
		private Color BackupRowBackColor;

		// BORDER RECTANGLE
		private Rectangle rect;
		private Timer tmr = new Timer();

		#region NEW | GET

		// SUB NEW
		// =============================================================================
		public frmLouvorHistorico(frmLouvorLista formOrigem)
		{
			InitializeComponent();

			_formOrigem = formOrigem;
			GetHistorico();
			ConfiguraDataGrid();

			int L = _formOrigem.Width;
			Point ptLocation = new Point(L - Width, 100);
			
			Location = ptLocation;
			// Size = new Size(Width, formOrigem.Size.Height - 155);

			Size = new Size(Width, 32);
			tmr.Interval = 1;
			tmr.Tick += Tmr_Tick;

			btnFechar.Visible = false;
		}

		// LOAD FORM: RESIZE FORM AND RECREATE BORDER
		// =============================================================================
		private void frmLouvorHistorico_Load(object sender, EventArgs e)
		{
			dgvListagem.ScrollBars = ScrollBars.None;
			tmr.Start();
			_formOrigem.pnlHistorico.Visible = false;
		}

		// GET HISTORICO
		// =============================================================================
		private void GetHistorico()
		{
			try
			{
				// Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				HistoricoList = lBLL.GetHistorico();

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
			clnID.DataPropertyName = "IDLouvor";
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
			clHistoricoLouvor hist = (clHistoricoLouvor)dgvListagem.SelectedRows[0].DataBoundItem;
			//_formOrigem.GetEstrofesHinoByID((int)hist.IDHino);
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

				clHistoricoLouvor hist = (clHistoricoLouvor)dgvListagem.SelectedRows[0].DataBoundItem;
				lBLL.DeleteHistoricoByID(hist.IDHistorico, _formOrigem.DBPath);

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

		// LIMPAR HISTORICO
		// =============================================================================
		private void btnLimpar_Click(object sender, EventArgs e)
		{
			try
			{
				// ASK USER
				if (AbrirDialog("Deseja limpar o Histórico?", "Tem Certeza?", 
					 DialogType.SIM_NAO, 
					 DialogIcon.Warning, 
					 DialogDefaultButton.Second) == DialogResult.No)
				{
					return;
				}

				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				if (dgvListagem.Rows.Count == 0) return;

				lBLL.ClearHistorico(_formOrigem.DBPath);

				// GET NEW LIST
				GetHistorico();
				dgvListagem.DataSource = HistoricoList;
			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Limpar Histórico..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}
		}

		// PRESS ESC TO CLOSE
		// =============================================================================
		private void frmLouvorHistorico_KeyDown(object sender, KeyEventArgs e)
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
				btnLimpar.Visible = true;
				tmr.Stop();
				dgvListagem.ScrollBars = ScrollBars.Vertical;
			}
		}

		// ON RESIZE FORM
		private void frmLouvorHistorico_Resize(object sender, EventArgs e)
		{
			Refresh();
		}

		// ON PAINT CREATE BORDER
		private void frmLouvorHistorico_Paint(object sender, PaintEventArgs e)
		{
			rect = new Rectangle(0, 0, ClientSize.Width - 1, ClientSize.Height - 1);
			e.Graphics.DrawRectangle(new Pen(Color.SlateGray, 3),
									 rect);
		}

		#endregion


	}
}
