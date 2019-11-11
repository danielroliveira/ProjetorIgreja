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
	public partial class frmConfigGeral : CamadaUI.Modals.frmModConfig
	{
		string db = FuncoesGlobais.DBPath();
		LouvorBLL lBLL;
		HarpaBLL hBLL;
		VersiculoBLL vBLL;

		// SUB NEW
		public frmConfigGeral()
		{
			lBLL = new LouvorBLL(db);
			hBLL = new HarpaBLL(db);
			vBLL = new VersiculoBLL(db);
			InitializeComponent();
		}

		// CLOSE
		private void btnClose_Click(object sender, EventArgs e)
		{
			frmConfig f = Application.OpenForms.OfType<frmConfig>().FirstOrDefault();
			f.FormNoPanelClosed(this);
		}

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

		#endregion

	}
}
