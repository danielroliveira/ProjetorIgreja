using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using static CamadaUI.Utilidades;
using CamadaDTO;

namespace CamadaUI
{
	public static class FuncoesGlobais
	{
		// GET PATH OF DATABASE
		//==============================================================================================
		public static string DBPath() {
			return Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"ProjetorDB.mdb");
		}

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
							new XElement("IDVersiculoPadrao", 1),
							new XElement("IDVersiculoUltimo", 1),
							new XElement("IDHinoUltimo", 1)
						),
						new XElement("Folders",
							new XElement("BackupFolder", ""),
							new XElement("CopyAllNewFilesToBackup", true)
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

		// GET CONFIG XML DEFAULT VALUE
		// =============================================================================
		public static string ObterDefault(string CampoDefault)
		{
			try
			{
				XmlDocument config = MyConfig();
				return config.SelectSingleNode("Configuracao").SelectSingleNode("DefaultValues").SelectSingleNode(CampoDefault).InnerText;
			}
			catch
			{
				return string.Empty;
			}
		}

		// GET CONFIG XML FILE
		// =============================================================================
		static XmlDocument MyConfig()
		{
			if (VerificaConfigXML())
			{
				XmlDocument myXML = new XmlDocument();
				try
				{
					myXML.Load(Application.StartupPath + "\\Config.xml");
					return myXML;
				}
				catch (Exception ex)
				{
					throw ex;
				}
			}
			else
			{
				return null;
			}
		}

		// OBTER VALOR DO NODE XML DO ARQUIVO CONFIGXML PELO NOME
		// =============================================================================
		public static string ObterConfigValorNode(string NodeName)
		{    
			XmlNodeList elemList = MyConfig().GetElementsByTagName(NodeName);
			string myValor = "";
               
			for (int i = 0; i < elemList.Count; i++)
			{
				myValor = elemList[i].InnerXml;
			}
        
			return myValor;
        
		}

		// SAVE CONFIG XML DEFAULT VALUE
		// =============================================================================
		public static bool SaveDefault(string CampoDefault, string NewValorDefault)
		{
			try
			{
				XmlDocument xmlConfig = MyConfig();
				XmlNode myNode = xmlConfig.SelectSingleNode("/Configuracao/DefaultValues/" + CampoDefault);

				if(myNode != null)
				{
					myNode.InnerText = NewValorDefault;
					xmlConfig.Save("Config.xml");
					return true;
				}
				else
				{
					throw new Exception("O XMLNode não foi encontrado...");
				}

			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// SAVE CONFIG NODE VALOR CONFIGXML PELO NOME
		// =============================================================================
		public static bool SaveConfigValorNode(string NodeName, string NodeValue)
		{
			try
			{
				XmlDocument xmlConfig = MyConfig();
				XmlNodeList elemList = xmlConfig.GetElementsByTagName(NodeName);

				if(elemList.Count > 0)
				{
					elemList[0].InnerXml = NodeValue;
					xmlConfig.Save("Config.xml");
				}
				else
				{
					throw new AppException("O xmlNode não foi encontrado...");
				}

				return true;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

	}
}
