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
		string PathBackupFolder = "";

		#region SUB NEW | OPEN

		public frmConfigLouvor()
		{
			InitializeComponent();
			GetFoldersDT();
			GetCategoriasDT();
		}

		private void frmConfigLouvor_Load(object sender, EventArgs e)
		{
			// get Backup Folder
			try
			{
				string backupFolder = FuncoesGlobais.ObterConfigValorNode("BackupFolder");
				if (backupFolder.Length > 0)
				{
					PathBackupFolder = backupFolder;
					lblPastaBackup.Text = backupFolder;
				}
				else
				{
					PathBackupFolder = "";
					lblPastaBackup.Text = "Definir Pasta...";
				}

				string backupAuto = FuncoesGlobais.ObterConfigValorNode("CopyAllNewFilesToBackup");
				if (backupAuto == string.Empty)
				{
					backupAuto = "false";
				}
				chkBackupAuto.Checked = Convert.ToBoolean(backupAuto);

			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Obter a pasta de Backup..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}

		}

		#endregion

		#region GET DB DATA

		// GET SOURCE FOLDERS OF LOUVORES
		// =============================================================================
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

		// GET CATEGORIAS OF LOUVORES
		// =============================================================================
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
				return lBLL.GetLouvorListAll();

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
			string newPath = "";

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
					newPath = FBDiag.SelectedPath;
				}
				else
				{
					return;
				}
			}

			int? IDFolder = null;

			// CHECK IF IS SUB FOLDER OF INSERTED FOLDER
			foreach (DataRow row in dtLouvorFolder.Rows)
			{
				string oldPath = (string)row["LouvorFolder"];

				// verifica a existencia do DIR
				if (newPath.Contains(oldPath))
				{
					AbrirDialog("A pasta: \n" + newPath + "\n já foi incluída... \n \n" +
						"Favor verificar se a pasta não é um subdiretório de outra pasta que já foi incluída.",
						"Pasta já inserida", DialogType.OK, DialogIcon.Exclamation);
					return;
				}
				else if (oldPath.Contains(newPath))
				{
					AbrirDialog("A pasta: \n" + newPath + "\n" +
						"É uma pasta superior a outra pasta já incluída.\n" +
						"A pasta anterior será substituída.",
						"Pasta Superior", DialogType.OK, DialogIcon.Exclamation);
					IDFolder = (int)row["IDLouvorFolder"];
				}
			}

			// INSERT OR UPDATE
			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				// insert or update in DB
				if (IDFolder == null)
				{
					lBLL.InsertFolder(newPath);
				}
				else
				{
					lBLL.UpdateFolder(newPath, (int)IDFolder);
				}

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

		#region PESQUISA FOLDERS

		// PESQUISA PASTAS DE LOUVORES
		// =============================================================================
		private void btnPesquisaLouvores_Click(object sender, EventArgs e)
		{
			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				//--- Check source FOLDERS
				// ---------------------------------------------------------------------------
				if (dtLouvorFolder.Rows.Count == 0)
				{
					AbrirDialog("Não existem pastas inseridas nas lista para realizar a pesquisa... \n" +
						"Favor inserir pelo menos uma pasta de pesquisa.",
						"Sem pastas de pesquisa", DialogType.OK, DialogIcon.Exclamation);
					return;
				}

				//--- Check if BACKUPFOLDER is Defined
				// ---------------------------------------------------------------------------
				if (PathBackupFolder.Length == 0 && Directory.Exists(PathBackupFolder))
				{
					AbrirDialog("Não é possível realizar a nova Pesquisa porque ainda não foi definida a pasta de Backup padrão... \n" +
						"Favor definir a pasta de Backup padrão...", "Pasta de Backup");
					return;
				}

				// Create new list louvor
				List<clLouvor> newListLouvor = CheckAllFoldersAndGetAllSlides();

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

				if (foundCount == 0)
				{
					AbrirDialog("Não foi encontrado nenhum novo arquivo de projeção de louvor.",
						"Pesquisar");
					return;
				}

				DialogResult resp = AbrirDialog($"Foram encontrados {foundCount: 00} novas projeções... \n" +
					"Deseja inserir as novas projeções encontradas no Banco de Dados?",
					"Novas Projeções", DialogType.SIM_NAO, DialogIcon.Question);

				if (resp == DialogResult.No)
				{
					return;
				}

				// --- insert NEW found louvores
				pgbLouvores.Maximum = foundCount;
				pgbLouvores.Visible = true;

				// --- check Last/Max ID Louvor
				int maxID = 0;
				if (curLouvoresList.Count > 0)
				{
					maxID = curLouvoresList.Max(l => l.IDLouvor);
				}
				maxID += 1;

				// Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				foreach (clLouvor louvor in newListLouvor)
				{
					bool inserido = false;
					int versao = 1;
					string titulo = louvor.Titulo;
					string FileRenamedTo = "";

					while (!inserido)
					{
						try
						{
							if (FileRenamedTo.Length > 0 && File.Exists(FileRenamedTo))
							{
								throw new AppException("");
							}

							louvor.IDLouvor = maxID;
							lBLL.InsertLouvor(louvor);
							inserido = true;
							maxID += 1;
						}
						catch (AppException)
						{
							string projPath = Path.GetDirectoryName(louvor.ProjecaoPath);
							string projExt = Path.GetExtension(louvor.ProjecaoPath);

							louvor.Titulo = $"{titulo}_versao_{versao: 00}";
							louvor.ProjecaoFileName = $"{louvor.Titulo}{projExt}";
							louvor.ProjecaoPath = $"{projPath}\\{louvor.ProjecaoFileName}";
							louvor.Ativo = 3;

							FileRenamedTo = louvor.ProjecaoPath;
						}

						versao += 1;
					}

					if (FileRenamedTo.Length > 0)
					{
						string OriginalFile = $"{Path.GetDirectoryName(louvor.ProjecaoPath)}\\{titulo}{Path.GetExtension(louvor.ProjecaoPath)}";
						File.Move(OriginalFile, FileRenamedTo);
					}

					pgbLouvores.Value += 1;
				}

				pgbLouvores.Visible = false;
				pgbLouvores.Value = 0;

				// Make automatic Backup
				if (chkBackupAuto.Checked)
				{
					BackupNewFiles(PathBackupFolder);
				}
				else
				{
					AbrirDialog("Não foi realizado o Backup automático porque Backup padrão não foi marcado... \n" +
						"Backup Padrão", "Pasta de Backup");
				}

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

		// CHECK ALL SOURCE FOLDERS LISTED AND GET LOUVOR PROJECTION
		// =============================================================================
		private List<clLouvor> CheckAllFoldersAndGetAllSlides()
		{
			// Create new list louvor
			List<clLouvor> list = new List<clLouvor>();
			List<clLouvor> dupList = new List<clLouvor>();
			List<string> SourceFolders = new List<string>();

			// --- make a list of louvor files in FOLDERS
			foreach (DataRow row in dtLouvorFolder.Rows)
			{
				string path = (string)row["LouvorFolder"];

				// verifica a existencia do DIR
				if (Directory.Exists(path))
				{
					SourceFolders.Add(path);
				}
				else
				{
					AbrirDialog("A pasta: " + path + "\n não foi encontrada no computador... \n" +
						"Favor verificar se foi removida ou transferida.", "Pasta não encontrada", DialogType.OK, DialogIcon.Exclamation);
				}
			}

			list = GetListOfSlidesSepareteDuplicated(SourceFolders, list, dupList);

			// MOVE DUPLICATED FILES to new FOLDER
			foreach (clLouvor dupFile in dupList)
			{
				FileInfo file = new FileInfo(dupFile.ProjecaoPath);

				file.MoveTo()

				System.Diagnostics.Debug.Print(dupFile.ProjecaoPath);

			}

			return list;
			
		}

		// GET LIST SLIDES FILES ON A DIRECTORY AND RETURN A LIST
		// =============================================================================
		private List<clLouvor> GetListOfSlidesSepareteDuplicated(List<string> SourceFolders, List<clLouvor> prevList, List<clLouvor> dupList)
		{

			List<string> dirPathsList = new List<string>();

			// create a list of ALL source FOLDERS and their SUBFOLDERS
			foreach (string findFolder in SourceFolders)
			{
				// seek in the first directory
				dirPathsList.Add(findFolder);
				dirPathsList.AddRange(Directory.GetDirectories(findFolder, "*", SearchOption.AllDirectories).ToList<string>());
			}

			// create a BIG list of ALL slides: PPT, PPTX, PPS, PPSX
			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				List<clLouvor> BigList = new List<clLouvor>();
				int initialID = 1;

				// go through all files and insert in list
				// clear all PPT or PPTX that exists correspondent PPS file
				foreach (string findDir in dirPathsList)
				{
					DirectoryInfo dir = new DirectoryInfo(findDir);

					// get all louvor in subdir path
					BigList.AddRange(GetSlidesOfDir(dir, initialID));
					initialID = BigList.Count + 1;
				}

				foreach (clLouvor item in BigList)
				{
					System.Diagnostics.Debug.Print(item.IDLouvor.ToString());
				}


				// add all PPS or PPSX files in PrevLista
				prevList.AddRange(BigList.FindAll(louvor => louvor.FileExtension == ".pps" || louvor.FileExtension == ".ppsx"));

				// check files PPT, PPTX if exists correspondent PPS or PPSX file
				List<clLouvor> PPTList = BigList.FindAll(louvor => louvor.FileExtension == ".ppt" || louvor.FileExtension == ".pptx");

				foreach (clLouvor PPTLouvor in PPTList)
				{
					if (prevList.Exists(l => l.Titulo.ToUpper() == PPTLouvor.Titulo.ToUpper()))
					{
						dupList.Add(PPTLouvor); // remove PPT or PPTX if there is PPS or PPSX
					}
					else
					{
						prevList.Add(PPTLouvor);
					}
				}

				// SEPARATE - remove of list all FILE NAME duplicated in list
				// ---------------------------------------------------------------------------
				prevList = RemoveDuplicatedItem(prevList, dupList);

				// CREATE | CONVERT PPS for all PPT or PPTX files
				// ---------------------------------------------------------------------------
				PPTList = prevList.FindAll(l => l.FileExtension == ".ppt" || l.FileExtension == ".pptx");

				foreach (clLouvor pptFile in PPTList)
				{
					// check if exist correspondent PPS or PPSX file with the same NAME
					FileInfo file = new FileInfo(pptFile.ProjecaoPath);

					// copy and convert file to PPS
					FileInfo newFile = file.CopyTo($"{Path.GetDirectoryName(pptFile.ProjecaoPath)}\\{pptFile.Titulo}.pps", true);

					// move old PPT to duplist
					dupList.Add(pptFile);

					// edit list clLouvor
					clLouvor louvor = prevList.Find(l => l.IDLouvor == pptFile.IDLouvor);
					louvor.ProjecaoPath = newFile.FullName;
					louvor.ProjecaoFileName = newFile.Name;
					louvor.Titulo = Path.GetFileNameWithoutExtension(newFile.FullName);
					louvor.FileExtension = newFile.Extension;
				}
			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao obter a lista de projeções da pasta..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}

			foreach (clLouvor item in prevList)
			{
				System.Diagnostics.Debug.Print(item.FileExtension);
			}

			return prevList;
		}

		// FIND DUPLICATED FILES AND RETURN PREFERED PPS OR PPSX FILES
		// =============================================================================
		private List<clLouvor> RemoveDuplicatedItem(List<clLouvor> prevList, List<clLouvor> duplicated)
		{
			// create new list
			List<clLouvor> newList = new List<clLouvor>();

			// group prevList for the same FileName

			var groups = prevList.GroupBy(x => x.Titulo.ToUpper(), x => x);

			foreach (IGrouping<string, clLouvor> group in groups)
			{
				if(group.Count() == 1)
				{
					newList.Add(group.First());
				}
				else
				{
					if(group.ToList().Exists(l => l.FileExtension == ".pps" || l.FileExtension == ".ppsx"))
					{
						clLouvor primeiro = group.First(l => l.FileExtension == ".pps" || l.FileExtension == ".ppsx");
						newList.Add(primeiro);
						duplicated.AddRange(group.ToList().FindAll(l => !l.Equals(primeiro)));
					}
					else // nao encontrou inclue o primeiro
					{
						clLouvor primeiro = group.First(l => l.FileExtension == ".ppt" || l.FileExtension == ".pptx");
						newList.Add(primeiro);
						duplicated.AddRange(group.ToList().FindAll(l => !l.Equals(primeiro)));
					}
				}
			}

			return newList;
		}

		// GET ALL PPS OR PPSX IN A FOLDER AND CONVERT PPT ==> PPS
		// =============================================================================
		private List<clLouvor> GetSlidesOfDir(DirectoryInfo dir, int initialID)
		{
			List<clLouvor> list = new List<clLouvor>();

			// Ampulheta ON
			Cursor.Current = Cursors.WaitCursor;

			// CONVERT all PPTX or PPT to PPS // GET files PPT or PPTX to convert in PPS
			// ---------------------------------------------------------------------------

			/*
			List<FileInfo> dirFiles = dir.GetFiles("*.ppt").ToList<FileInfo>();
			dirFiles.AddRange(dir.GetFiles("*.pptx").ToList<FileInfo>());
			
			foreach (FileInfo file in dirFiles)
			{
				// check if exist correspondent PPS or PPSX file with the same NAME
				string fileOnlyName = Path.GetFileNameWithoutExtension(file.FullName);

				if (!(File.Exists($"{file.DirectoryName}\\{fileOnlyName}.pps") || File.Exists($"{file.DirectoryName}\\{fileOnlyName}.ppsx")))
				{
					// copy and convert file to PPS
					file.CopyTo($"{file.DirectoryName}\\{fileOnlyName}.pps", true);
				}
			}

			*/

			// INSERT Files in LIST
			// ---------------------------------------------------------------------------
			foreach (FileInfo file in dir.GetFiles())
			{
				// create array of alowed extensions
				string[] FileExtensions = new string[]{
					".pps", ".ppsx" , ".ppt", ".pptx"
				};

				if (FileExtensions.Contains(file.Extension) && !file.Name.Contains("~"))
				{
					clLouvor louvor = new clLouvor(initialID);
					louvor.ProjecaoPath = file.FullName;
					louvor.ProjecaoFileName = file.Name;
					louvor.Titulo = Path.GetFileNameWithoutExtension(file.FullName);
					louvor.FileExtension = file.Extension;
					louvor.IDLouvor = initialID;
					initialID += 1;
					list.Add(louvor);
				}
			}

			return list;
		}

		// CREATE LIST OF PROJECTOR FILES WITHOUT DUPLICATION
		// =============================================================================
		/*
		private List<clLouvor> CreateFilesListNotDuplication()
		{
			// Create new list louvor
			List<clLouvor> newListLouvor = new List<clLouvor>();

			// --- make a list of louvor files in FOLDERS
			foreach (DataRow row in dtLouvorFolder.Rows)
			{
				string path = (string)row["LouvorFolder"];

				// verifica a existencia do DIR
				if (Directory.Exists(path))
				{
					List<clLouvor> getListLouvor = GetListOfSlides(path);

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

			foreach (clLouvor louvor in newListLouvor)
			{
				if(newListLouvor.Exists(l => Path.GetFileName(l.ProjecaoPath) == Path.GetFileName(louvor.ProjecaoPath) && l.ProjecaoPath != louvor.ProjecaoPath  ))
				{

				}
			}
		}
		*/


		// BACKUP OF NEW FILES
		// =============================================================================
		private void BackupNewFiles(string backupFolder)
		{
			/*
			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				// get all Files on Backup Folder
				// ---------------------------------------------------------------------------
				List<clLouvor> DirListLouvor = GetListOfSlides(backupFolder);

				// --- get List of current Louvores in BD
				List<clLouvor> curLouvoresList = GetLouvores();

				// --- compare TWO lists and remove duplicated files
				foreach (clLouvor Backuplouvor in DirListLouvor)
				{
					string FileName = Path.GetFileName(Backuplouvor.ProjecaoPath);
					
					clLouvor louvor = curLouvoresList.Find(l => Path.GetFileName(l.ProjecaoPath) == FileName);
					curLouvoresList.Remove(louvor);
				}

				int foundCount = curLouvoresList.Count();

				if(foundCount == 0)
				{
					AbrirDialog("Não existem novas projeções para Backup...", "Backup");
					return;
				}

				pgbLouvores.Maximum = foundCount;
				pgbLouvores.Visible = true;

				// copy to Backup Dir
				foreach (clLouvor louvor in curLouvoresList)
				{
					string FileName = Path.GetFileName(louvor.ProjecaoPath);
					File.Copy(louvor.ProjecaoPath, $"{backupFolder}\\{FileName}");

					pgbLouvores.Value += 1;
				}

				pgbLouvores.Visible = false;
				pgbLouvores.Value = 0;

				AbrirDialog("Backup relizado com sucesso! \n" +
					$"Foram copiadas {foundCount} novas projeções.", "Backup");

			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Realizar o Backup das novas projeções..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}
			*/
		}

		#endregion

		#region BUTTONS

		// DEFINIR PASTA BACKUP
		// =============================================================================
		private void btnPastaBackup_Click(object sender, EventArgs e)
		{
			try
			{
				string path = "";

				// CHECK IF EXISTS DEFAULT BACKUP FOLDER
				if (PathBackupFolder == string.Empty)
				{
					string defFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
					defFolder += "\\Projetor\\Louvor\\";

					if (Directory.Exists(defFolder))
					{
						path = defFolder;
					}
					else
					{
						DialogResult resp = AbrirDialog("Ainda não foi criada a pasta padrão para realizar o Backup das projeções. \n" +
							"Deseja criar a pasta de Backup padrão?",
							"Pasta de Backup",
							DialogType.SIM_NAO,
							DialogIcon.Question);

						if (resp == DialogResult.Yes)
						{
							Directory.CreateDirectory(defFolder);
							path = defFolder;
						}
						else
						{
							path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
						}
					}
				}
				else
				{
					if (!Directory.Exists(PathBackupFolder))
					{
						PathBackupFolder = "";
						btnPastaBackup_Click(sender, e);
						return;
					}
					else
					{
						path = PathBackupFolder;
					}
				}

				// get folder
				using (FolderBrowserDialog FBDiag = new FolderBrowserDialog()
				{
					Description = "Pasta de Backup das Projeções",
					SelectedPath = path,
					ShowNewFolderButton = true
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

				FuncoesGlobais.SaveConfigValorNode("BackupFolder", path);
				lblPastaBackup.Text = path;
				PathBackupFolder = path;

			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Salvar Pasta de Backup..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
		}

		// CLOSE FORM
		// =============================================================================
		private void btnClose_Click(object sender, EventArgs e)
		{
			frmConfig f = Application.OpenForms.OfType<frmConfig>().FirstOrDefault();
			f.FormNoPanelClosed(this);
		}


		#endregion

		// CHANGE BACKUP AUTOMATICO CHECKED
		// =============================================================================
		private void chkBackupAuto_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				FuncoesGlobais.SaveConfigValorNode("CopyAllNewFilesToBackup", chkBackupAuto.Checked.ToString());
			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Salvar o arquivo de configuração..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
		}

		// DO BACKUP ON FOLDER
		// =============================================================================
		private void btnBackupProjecoes_Click(object sender, EventArgs e)
		{
			string path = "";

			// GET NEW FOLDER
			using (FolderBrowserDialog FBDiag = new FolderBrowserDialog()
			{
				Description = "Local/Pasta de Backup",
				SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
			})
			{
				DialogResult result = FBDiag.ShowDialog();
				if (result == DialogResult.OK)
				{
					path = FBDiag.SelectedPath;
					path = $"{path}\\Projetor\\Louvor\\";
					Directory.CreateDirectory(path);
					BackupNewFiles(path);
				}
				else
				{
					return;
				}
			}

		}
	}
}
