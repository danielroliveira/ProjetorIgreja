using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static CamadaUI.Utilidades;
using CamadaBLL;

namespace CamadaUI.Config
{
	public partial class frmConfigLouvor : CamadaUI.Modals.frmModConfig
	{
		LouvorBLL lBLL = new LouvorBLL(FuncoesGlobais.DBPath());
		DataTable dtCategoria;
		int? EditRowNumber = null;

		public frmConfigLouvor()
		{
			InitializeComponent();
			GetFoldersDT();
			GetCategoriasDT();
		}

		private void GetFoldersDT()
		{
			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				lstPastas.DataSource = lBLL.GetFoldersDT();
			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Obter a Listagem de Pastas de Pesquisa..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}

		}

		private void GetCategoriasDT()
		{
			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;
				dtCategoria = lBLL.GetLouvorCategoriaDT();
				lstCategorias.DataSource = dtCategoria;
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


		private void btnClose_Click(object sender, EventArgs e)
		{
			frmConfig f = Application.OpenForms.OfType<frmConfig>().FirstOrDefault();
			f.FormNoPanelClosed(this);
		}

		private void btnInserirFolder_Click(object sender, EventArgs e)
		{
			string path = "";

			// GET NEW FOLDER
			using (FolderBrowserDialog FBDiag = new FolderBrowserDialog()
			{
				Description = "Pasta das Projeções",
				SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
			})
			{
				DialogResult result = FBDiag.ShowDialog();
				if (result == DialogResult.OK)
				{
					path = FBDiag.SelectedPath;
				}
				else
				{
					return;
				}
			}

			// INSERT
			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				// insert in DB
				lBLL.InsertFolder(path);

				// get
				GetFoldersDT();
			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Inserir nova pasta de pesquisa..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}
		}

		private void btnRemoverFolder_Click(object sender, EventArgs e)
		{
			if (lstPastas.SelectedItems.Count == 0)
			{
				AbrirDialog("Favor selecionar o item da listagem que você deseja Remover...",
					"Selecionar Item");
				return;
			}

			DialogResult resposta = AbrirDialog("Você tem certeza que deseja remover a pasta de pesquisa de Louvores: \n" +
			   lstPastas.SelectedItems[0].Text + "?",
			   "Remover Pasta de Pesquisa", DialogType.SIM_NAO,
			   DialogIcon.Question, DialogDefaultButton.Second);

			if (resposta != DialogResult.Yes)
				return;

			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				// DELETE in DB
				lBLL.DeleteFolderByID((int)lstPastas.SelectedItems[0].Value);

				// get
				GetFoldersDT();
			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Remover Pasta de Pesquisa..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}

		}

		private void btnInserirCategoria_Click(object sender, EventArgs e)
		{
			dtCategoria.Rows.Add(dtCategoria.NewRow());
			lstCategorias.Items[lstCategorias.Items.Count - 1].BeginEdit();
		}

		// BEFORE LABEL EDIT GET THE NUMBER OF EDITED DATAROW
		private void lstCategorias_BeforeLabelEdit(object sender, ComponentOwl.BetterListView.BetterListViewLabelEditCancelEventArgs eventArgs)
		{
			if (eventArgs.Label != "")
			{
				foreach (DataRow row in dtCategoria.Rows)
				{
					if ((string)row[1] == eventArgs.Label)
					{
						EditRowNumber = dtCategoria.Rows.IndexOf(row);
					}
				}
			}
			else
			{
				EditRowNumber = null;
			}
		}
		
		// SAVE OR UPDATE REGISTRY
		private void lstCategorias_AfterLabelEdit(object sender, ComponentOwl.BetterListView.BetterListViewLabelEditEventArgs eventArgs)
		{
			// get entry value
			string newCat = eventArgs.Label.Trim();

			// check if is empty string value
			if (newCat == string.Empty)
			{
				if(EditRowNumber == null)
				{
					dtCategoria.Rows[dtCategoria.Rows.Count - 1].Delete();
					return;
				}
				else
				{
					// message
					AbrirDialog("A categoria não pode ficar vazia...",
						"Categoria", DialogType.OK, DialogIcon.Exclamation);
					// return old value
					dtCategoria.Rows[(int)EditRowNumber].RejectChanges();
					lstCategorias.SelectedItems[0].Text = (string)dtCategoria.Rows[(int)EditRowNumber][1];
					// cancel editing and return
					EditRowNumber = null;
					return;
				}
			}

			// check if new Categoria has until 100 Caracteres
			if (newCat.Length > 100)
				newCat = newCat.Substring(0, 99);

			// check if is valid categoria name
			foreach (DataRow row in dtCategoria.Rows)
			{
				if (EditRowNumber == null)
				{
					if ((string)row[1] == newCat && row.RowState != DataRowState.Added )
					{
						AbrirDialog("Já existe uma categoria de Louvor com esse mesmo nome...",
							"Categoria repetida", DialogType.OK, DialogIcon.Exclamation);
						dtCategoria.Rows[dtCategoria.Rows.Count - 1].Delete();
						return;
					}
				}
				else
				{
					if (row[1].ToString().ToUpper() == newCat.ToUpper() && !row.Equals(dtCategoria.Rows[(int)EditRowNumber]))
					{
						AbrirDialog("Já existe uma categoria de Louvor com esse mesmo nome...",
							"Categoria repetida", DialogType.OK, DialogIcon.Exclamation);
						// return old value
						dtCategoria.Rows[(int)EditRowNumber].RejectChanges();
						lstCategorias.SelectedItems[0].Text = (string)dtCategoria.Rows[(int)EditRowNumber][1];
						EditRowNumber = null;
						return;
					}
				}
			}

			// TRY TO SAVE
			if (EditRowNumber == null) // SAVE NEW
			{
				int newID = SaveNewCategoria(newCat);

				// check if is empty ID value
				if (newID == 0)
				{
					dtCategoria.Rows[dtCategoria.Rows.Count - 1].Delete();
					return;
				}

				dtCategoria.Rows[dtCategoria.Rows.Count - 1][0] = newID;
				dtCategoria.Rows[dtCategoria.Rows.Count - 1].AcceptChanges();
			}
			else // UPDATE
			{
				UpdateCategoria((short)eventArgs.SubItem.Value, newCat);
				dtCategoria.Rows[(int)EditRowNumber].AcceptChanges();
				EditRowNumber = null;
			}

		}

		private int SaveNewCategoria(string Categoria)
		{
			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				// SAVE
				int newID = lBLL.InsertCategoria(Categoria);
				return newID;
			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Salvar a nova Categoria..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
				return 0;
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}
		}

		private void UpdateCategoria(short IDCategoria, string Categoria)
		{
			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				// SAVE
				lBLL.UpdateCategoria(IDCategoria, Categoria);
			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Salvar a Categoria..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}
		}

		private void btnRemoverCategoria_Click(object sender, EventArgs e)
		{
			DialogResult resp = AbrirDialog("Você tem certeza que deseja Remover a categoria: \n\n" +
				lstCategorias.SelectedItems[0].Text.ToUpper() + "\n\n" +
				"A categoria será removida também de todos os louvores vinculados a ela...",
				"Remover Categoria?", DialogType.SIM_NAO, DialogIcon.Question, DialogDefaultButton.Second);

			if (resp == DialogResult.No)
				return;

			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				// DELETE
				lBLL.DeleteCategoriaByID((short)lstCategorias.SelectedItems[0].Value);

				// GET DADOS
				GetCategoriasDT();
			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Remover a Categoria..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}
		}
	}
}
