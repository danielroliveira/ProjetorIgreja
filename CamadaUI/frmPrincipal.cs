using System;
using System.Windows.Forms;
using CamadaUI.Escritura;
using static CamadaUI.Utilidades;

namespace CamadaUI
{
	public partial class frmPrincipal : Form
	{
		public frmPrincipal()
		{
			InitializeComponent();
			pnlTop.BackColor = Properties.Settings.Default.PanelTopColor;
		}

		private void btnSair_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnMinimizer_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		private void btnBiblia_Click(object sender, EventArgs e)
		{
			frmLeitura f = new frmLeitura();
			f.Show();
			Visible = false;
		}

		private void frmPrincipal_Load(object sender, EventArgs e)
		{
			mnuPrincipal.Focus();
			//btnBiblia.Select();
		}

		private void btnHarpa_Click(object sender, EventArgs e)
		{
			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				Form f = new Harpa.frmHarpa();
				f.Show();
				Visible = false;

			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Abrir o formulário de Hinos..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}

		}

		private void btnLouvores_Click(object sender, EventArgs e)
		{
			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				Form f = new Louvor.frmLouvorLista();
				f.Show();
				Visible = false;
			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Abrir o formulário de Louvores..." + "\n" +
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
