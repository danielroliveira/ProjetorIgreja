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
	public partial class frmConfigHarpa : CamadaUI.Modals.frmModConfig
	{
		LouvorBLL lBLL = new LouvorBLL(FuncoesGlobais.DBPath());

		public frmConfigHarpa()
		{
			InitializeComponent();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			frmConfig f = Application.OpenForms.OfType<frmConfig>().FirstOrDefault();
			f.FormNoPanelClosed(this);
		}

	}
}
