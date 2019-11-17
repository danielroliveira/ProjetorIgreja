using CamadaBLL;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static CamadaUI.Utilidades;
using static CamadaUI.FuncoesGlobais;

namespace CamadaUI.Config
{
	public partial class frmConfigGeral : CamadaUI.Modals.frmModConfig
	{
		string db = FuncoesGlobais.DBPath();
		LouvorBLL lBLL;
		HarpaBLL hBLL;
		VersiculoBLL vBLL;

		#region SUB NEW | LOAD

		// SUB NEW
		public frmConfigGeral()
		{
			InitializeComponent();

			lBLL = new LouvorBLL(db);
			hBLL = new HarpaBLL(db);
			vBLL = new VersiculoBLL(db);

			txtIgrejaTitulo.Text = ObterDefault("IgrejaTitulo");
		}

		// LOAD
		private void frmConfigGeral_Load(object sender, EventArgs e)
		{
			txtIgrejaTitulo.Focus();
		}

		#endregion

		#region BUTTONS FUNCTION

		// LIMPAR HISTORICO LOUVOR
		// =============================================================================
		private void btnLimparHistoricoLouvor_Click(object sender, EventArgs e)
		{
			try
			{
				// ASK USER
				if (AbrirDialog("Deseja limpar o Histórico de LOUVOR?", "Tem Certeza?",
					 DialogType.SIM_NAO,
					 DialogIcon.Warning,
					 DialogDefaultButton.Second) == DialogResult.No)
				{
					return;
				}

				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;
				lBLL.ClearHistorico(FuncoesGlobais.DBPath());
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

		// LIMPAR HISTORICO HINOS
		// =============================================================================
		private void btnLimparHistoricoHinos_Click(object sender, EventArgs e)
		{
			try
			{
				// ASK USER
				if (AbrirDialog("Deseja limpar o Histórico de Hinos da Harpa?", "Tem Certeza?",
					 DialogType.SIM_NAO,
					 DialogIcon.Warning,
					 DialogDefaultButton.Second) == DialogResult.No)
				{
					return;
				}

				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;
				hBLL.ClearHistorico();
			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Limpar Histórico de Hinos..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}
		}

		// LIMPAR HISTORICO VERSICULOS
		// =============================================================================
		private void btnLimparHistoricoLeitura_Click(object sender, EventArgs e)
		{
			try
			{
				// ASK USER
				if (AbrirDialog("Deseja limpar o Histórico de Versículos Lidos?", "Tem Certeza?",
					 DialogType.SIM_NAO,
					 DialogIcon.Warning,
					 DialogDefaultButton.Second) == DialogResult.No)
				{
					return;
				}

				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				vBLL.ClearHistorico();

			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Limpar Histórico de Versículos..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}
		}

		// CLOSE
		// =============================================================================
		private void btnClose_Click(object sender, EventArgs e)
		{
			frmConfig f = Application.OpenForms.OfType<frmConfig>().FirstOrDefault();
			f.FormNoPanelClosed(this);
		}

		#endregion

		#region OTHER FUNCTIONS

		// CONVERT ALL PPT OR PPTX IN PPS FILE
		// =============================================================================
		private void btnConverterPPT_Click(object sender, EventArgs e)
		{
			string myPath = "";

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
					myPath = FBDiag.SelectedPath;
				}
				else
				{
					return;
				}
			}
			
			DirectoryInfo dir = new DirectoryInfo(myPath);

			// get number of PPT PPTX files
			int countFiles = dir.GetFiles("*.ppt").Length;
			countFiles += dir.GetFiles("*.pptx").Length;

			if(countFiles == 0)
			{
				AbrirDialog("Não foi encontrado nenhum arquivo PPT ou PPTX para converter...",
					"Conversão de Arquivos", DialogType.OK, DialogIcon.Exclamation);
				return;
			}

			// create new Directory to converted Files
			string convertedPath = myPath + "\\Convertidas";

			if (!Directory.Exists(convertedPath))
			{
				Directory.CreateDirectory(convertedPath);
			}

			// Ampulheta ON
			Cursor.Current = Cursors.WaitCursor;

			// inicia o progress bar
			pgbConfig.Value = 0;
			pgbConfig.Visible = true;
			pgbConfig.Maximum = countFiles;

			// copia os arquivos
			foreach (FileInfo file in dir.GetFiles())
			{
				if ((file.Extension == ".ppt" || file.Extension == ".pptx"))
				{
					string newFileFullName = $"{convertedPath}\\{Path.GetFileNameWithoutExtension(file.FullName)}.pps";
					file.CopyTo(newFileFullName, true);

					pgbConfig.Value += 1;
				}
			}

			// finaliza o progress bar
			pgbConfig.Visible = false;

			// Ampulheta OFF
			Cursor.Current = Cursors.Default;

			AbrirDialog("Arquivos convertidos com sucesso em:\n" +
				convertedPath, "Arquivos Convertidos");
		}

		#endregion

		private void txtIgrejaTitulo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			try
			{
				frmPrincipal f = Application.OpenForms.OfType<frmPrincipal>().FirstOrDefault();
				f.AplicacaoTitulo = txtIgrejaTitulo.Text;
			}
			catch (Exception ex)
			{
				AbrirDialog("Houve uma execeção ao salvar Config... \n" +
					ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
		}
		
	}
}
