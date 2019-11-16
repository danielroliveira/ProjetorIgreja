using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CamadaUI.FuncoesGlobais;

namespace CamadaUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

			// check and create Config XML
			if(!VerificaConfigXML())
			{
				CriarConfigXML();
			}

            Application.Run(new frmPrincipal());
        }
	}
}
