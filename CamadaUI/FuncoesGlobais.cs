using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using static CamadaUI.Utilidades;

namespace CamadaUI
{
	public static class FuncoesGlobais
	{
		// CHECK IF EXIST CONFIG
		//==============================================================================================
		public static bool VerificaConfigXML()
		{
			string FindXML = Application.StartupPath + "\\Config.xml";

			if (File.Exists(FindXML))
				return true;
			else
				return false;
		}

		// CREATE CONFIG XML
		//==============================================================================================
		public static void CriarConfigXML()
		{
			try
			{
				new XDocument(
					new XElement("Configuracao",
						new XElement("DefaultValues",
							new XElement("IDVersiculoPadrao", "1"),
							new XElement("IDVersiculoUltimo", "1")
						)
					)
				)
				.Save("Config.xml");

			}
			catch (Exception ex)
			{
				AbrirDialog(ex.Message, "Exceção XML", 
					DialogType.OK, DialogIcon.Exclamation);
			}
		}
	}
}
