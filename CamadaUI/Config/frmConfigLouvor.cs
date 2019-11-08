using CamadaBLL;
using CamadaDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static CamadaUI.Utilidades;

namespace CamadaUI.Config
{
	public partial class frmConfigLouvor : CamadaUI.Modals.frmModConfig
	{
		LouvorBLL lBLL = new LouvorBLL(FuncoesGlobais.DBPath());
		DataTable dtCategoria;
		DataTable dtLouvorFolder;
		int? EditRowNumber = null;

		#region SUB NEW | OPEN

		public frmConfigLouvor()
		{
			InitializeComponent();
			GetFoldersDT();
			GetCategoriasDT();
		}

		#endregion

		#region GET DB DATA

		private void GetFoldersDT()
		{
			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				dtLouvorFolder = lBLL.GetFoldersDT();
				lstPastas.DataSource = dtLouvorFolder;

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

		// GET CURRENT DB LIST LOUVORES
		// =============================================================================
		private List<clLouvor> GetLouvores()
		{
			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				// Get
				return lBLL.GetLouvorList();

			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Obter a lista de Louvores..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
				throw ex;
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}
		}

		#endregion

		#region FOLDER INSERT REMOVE

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
			{
				return;
			}

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

		#endregion

		#region CATEGORIA

		// BTN INSERIR CATEGORIA
		// =============================================================================
		private void btnInserirCategoria_Click(object sender, EventArgs e)
		{
			dtCategoria.Rows.Add(dtCategoria.NewRow());
			lstCategorias.Items[lstCategorias.Items.Count - 1].BeginEdit();
		}

		// BEFORE LABEL EDIT GET THE NUMBER OF EDITED DATAROW
		// =============================================================================
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
		// =============================================================================
		private void lstCategorias_AfterLabelEdit(object sender, ComponentOwl.BetterListView.BetterListViewLabelEditEventArgs eventArgs)
		{
			// get entry value
			string newCat = eventArgs.Label.Trim();

			// check if is empty string value
			if (newCat == string.Empty)
			{
				if (EditRowNumber == null)
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
			{
				newCat = newCat.Substring(0, 99);
			}

			// check if is valid categoria name
			foreach (DataRow row in dtCategoria.Rows)
			{
				if (EditRowNumber == null)
				{
					if ((string)row[1] == newCat && row.RowState != DataRowState.Added)
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

		// INSERT CATEGORIA
		// =============================================================================
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

		// UPDATE CATEGORIA
		// =============================================================================
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

		// REMOVE CATEGORIA
		// =============================================================================
		private void btnRemoverCategoria_Click(object sender, EventArgs e)
		{
			DialogResult resp = AbrirDialog("Você tem certeza que deseja Remover a categoria: \n\n" +
				lstCategorias.SelectedItems[0].Text.ToUpper() + "\n\n" +
				"A categoria será removida também de todos os louvores vinculados a ela...",
				"Remover Categoria?", DialogType.SIM_NAO, DialogIcon.Question, DialogDefaultButton.Second);

			if (resp == DialogResult.No)
			{
				return;
			}

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

		#endregion
		
		// PESQUISA PASTAS DE LOUVORES
		// =============================================================================
		private void btnPesquisaLouvores_Click(object sender, EventArgs e)
		{
			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				if( dtLouvorFolder.Rows.Count == 0)
				{
					AbrirDialog("Não existem pastas inseridas nas lista para realizar a pesquisa... \n" +
						"Favor inserir pelo menos uma pasta de pesquisa.",
						"Sem pastas de pesquisa", DialogType.OK, DialogIcon.Exclamation);
					return;
				}

				// Create new list louvor
				List<clLouvor> newListLouvor = new List<clLouvor>();

				// --- make a list of louvor files in FOLDERS
				foreach (DataRow row in dtLouvorFolder.Rows)
				{
					string path = (string)row["LouvorFolder"];

					// verifica a existencia do DIR
					if (Directory.Exists(path))
					{
						List<clLouvor> getListLouvor = GetListOfFilesProjecao(path);

						if (getListLouvor != null)
						{
							newListLouvor.AddRange(getListLouvor);
						}
					}
					else
					{
						AbrirDialog("A pasta: " + path + "\n não foi encontrada no computador... \n" +
							"Favor verificar se foi removida ou transferida.", "Pasta não encontrada", DialogType.OK, DialogIcon.Exclamation);
					}
				}

				// --- get List of current Louvores in BD
				List<clLouvor> curLouvoresList = GetLouvores();

				// --- compare TWO lists and remove duplicated files
				foreach (clLouvor louvor in curLouvoresList)
				{
					clLouvor dupLouvor = newListLouvor.Find(l => l.ProjecaoPath == louvor.ProjecaoPath);
					newListLouvor.Remove(dupLouvor);
				}

				// --- check found quantity and ask user
				int foundCount = newListLouvor.Count;

				if(foundCount == 0)
				{
					AbrirDialog("Não foi encontrado nenhum novo arquivo de projeção de louvor.",
						"Pesquisar");
					return;
				}

				DialogResult resp = AbrirDialog($"Foram encontrados {foundCount: 00} novas projeções... \n" +
					"Deseja inserir as novas projeções encontradas no Banco de Dados?",
					"Novas Projeções", DialogType.SIM_NAO, DialogIcon.Question);

				if(resp == DialogResult.No)	return;
				
				// --- insert NEW found louvores
				pgbLouvores.Maximum = foundCount;
				pgbLouvores.Visible = true;

				// --- check Last/Max ID Louvor
				int maxID = 0;
				if(curLouvoresList.Count > 0)
				{
					maxID = curLouvoresList.Max(l => l.IDLouvor);
				}
				maxID += 1;

				// Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				foreach (clLouvor louvor in newListLouvor)
				{
					try
					{
						louvor.IDLouvor = maxID;
						lBLL.InsertLouvor(louvor);
						maxID += 1;
					}
					catch (AppException ex)
					{
						AbrirDialog(ex.Message, "Duplicado");
					}

					pgbLouvores.Value += 1;
				}

				pgbLouvores.Visible = false;

				// Ampulheta OFF
				Cursor.Current = Cursors.Default;

			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Salvar Registros de Louvores..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}
		}

		// GET ALL FILES ON A DIRECTORY AND RETURN A LIST
		// =============================================================================
		public List<clLouvor> GetListOfFilesProjecao(string drivePath)
		{
			// verifica a existencia do DIR
			if (!Directory.Exists(drivePath))
			{
				return null;
			}

			List<clLouvor> list = new List<clLouvor>();

			// go through all files and insert in list
			foreach (string dirPath in Directory.GetDirectories(drivePath))
			{
				GetListOfFilesProjecao(dirPath);
			}

			DirectoryInfo dir = new DirectoryInfo(drivePath);

			int numFiles = dir.GetFiles().Length;
			int ID = 1;
			bool avisoArquivo = true; // avisa se ext PPT ou PPTX

			foreach (FileInfo file in dir.GetFiles())
			{
				if ((file.Extension == ".pps" || file.Extension == ".ppsx") && !file.Name.Contains("~"))
				{
					clLouvor louvor = new clLouvor(ID);
					int extL = file.Extension.Length;
					int nameL = file.Name.Length;
					louvor.Titulo = file.Name.Remove(nameL - extL);
					louvor.ProjecaoPath = file.FullName;
					louvor.IDLouvor = ID;
					ID += 1;
					list.Add(louvor);
				}
				else if ((file.Extension == ".ppt" || file.Extension == ".pptx") && avisoArquivo)
				{
					AbrirDialog("Existem arquivos 'PPT' ou 'PPTX' na pasta \n" + 
						drivePath + "\n" +
						"Essas projeções não serão incluídas. \n" +
						"Favor converter todos os arquivos em 'PPS' ou 'PPSX' ", "Atenção");
					avisoArquivo = false;
				}
			}
			return list;
		}

		// CLOSE FORM
		// =============================================================================
		private void btnClose_Click(object sender, EventArgs e)
		{
			frmConfig f = Application.OpenForms.OfType<frmConfig>().FirstOrDefault();
			f.FormNoPanelClosed(this);
		}

	}
}
