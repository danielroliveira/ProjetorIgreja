using System;
using System.Windows.Forms;

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
	}
}
