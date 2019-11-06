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

		public frmConfigLouvor()
		{
			InitializeComponent();
			GetFoldersDT();
		}

		private void GetFoldersDT()
		{
			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				lstListagem.DataSource = lBLL.GetFoldersList();
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
			if(lstListagem.SelectedItems.Count == 0)
			{
				AbrirDialog("Favor selecionar o item da listagem que você deseja Remover...",
					"Selecionar Item");
				return;
			}
			
			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				// DELETE in DB
				lBLL.DeleteFolderByID((int)lstListagem.SelectedItems[0].Value);

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
	}
}
