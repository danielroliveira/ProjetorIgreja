using System;
using System.Drawing;
using System.Windows.Forms;
using CamadaUI.Escritura;
using static CamadaUI.Utilidades;
using static CamadaUI.FuncoesGlobais;

namespace CamadaUI
{
	public partial class frmPrincipal : Form
	{
		#region SUB NEW | LOAD

		// SUB NEW
		// =============================================================================
		public frmPrincipal()
		{
			InitializeComponent();

			pnlTop.BackColor = Properties.Settings.Default.PanelTopColor;
			lblTitulo.Text = AplicacaoTitulo;

			foreach (Control control in this.Controls)
			{
				MdiClient client = control as MdiClient;
				if (!(client == null))
				{
					//client.BackgroundImage = Properties.Resources.Logo_FAES_cinza_PNG_Borda;

					//Image cachorro = Image.FromFile("E:\\Desktop\\faes.png");
					//Image cachorro = Image.FromFile("E:\\Desktop\\j0424399.jpg");

					//Image cachorro = Properties.Resources.notamusical_16;
					this.BackgroundImageLayout = ImageLayout.Zoom;
					//client.BackColor = Color.FromArgb(195, 240, 123);

					client.BackgroundImage = Properties.Resources.Logo_FAES_cinza_PNG_Borda;
					//picFundo.BackColor = Color.Red;
				}
			}

		}

		// LOAD
		// =============================================================================
		private void frmPrincipal_Load(object sender, EventArgs e)
		{
			mnuPrincipal.Focus();
			//btnBiblia.Select();
		}

		public string AplicacaoTitulo
		{
			get
			{
				return ObterDefault("IgrejaTitulo");
			}
			set
			{
				lblTitulo.Text = value;
				SaveConfigValorNode("IgrejaTitulo", value);
			}
		}
		
		#endregion

		#region BUTTONS

		// APPLICATION EXIT
		// =============================================================================
		private void btnSair_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// APPLICATION MINIMIZE
		// =============================================================================
		private void btnMinimizer_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		// OPEN ESCRITURA
		// =============================================================================
		private void btnBiblia_Click(object sender, EventArgs e)
		{
			frmLeitura f = new frmLeitura();
			f.Show();
			Visible = false;
		}

		// OPEN HARPA
		// =============================================================================
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

		// OPEN LOUVORES
		// =============================================================================
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

		// OPEN CONFIG
		// =============================================================================
		private void btnConfig_Click(object sender, EventArgs e)
		{
			try
			{
				// --- Ampulheta ON
				Cursor.Current = Cursors.WaitCursor;

				Form f = new Config.frmConfig(this);
				MenuEnabled(false);
				f.MdiParent = this;
				f.Show();
			}
			catch (Exception ex)
			{
				AbrirDialog("Uma exceção ocorreu ao Abrir o formulário de Configuração..." + "\n" +
							ex.Message, "Exceção", DialogType.OK, DialogIcon.Exclamation);
			}
			finally
			{
				// --- Ampulheta OFF
				Cursor.Current = Cursors.Default;
			}
		}

		#endregion

		#region OTHER FUNCTIONS

		public void MenuEnabled(bool IsEnabled)
		{
			mnuPrincipal.Enabled = IsEnabled;
			btnConfig.Enabled = IsEnabled;
		}
		
		#endregion
	}
}
