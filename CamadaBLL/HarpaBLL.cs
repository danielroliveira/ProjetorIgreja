using System;
using System.Collections.Generic;
using System.Data;
using CamadaDAL;
using CamadaDTO;

namespace CamadaBLL
{
	public class HarpaBLL
	{
		private string _dataBasePath;

		// NEW
		// =============================================================================
		public HarpaBLL(string dataBasePath)
		{
			_dataBasePath = dataBasePath;
		}

		// GET HINO LIST
		// =============================================================================
		public List<clHarpaHino> GetHinosList()
		{
			try
			{
				AcessoDados db = new AcessoDados(_dataBasePath);
				DataTable dt = new DataTable();

				string query = "SELECT IDHino, Titulo, Tom FROM tblHinosHarpa";

				dt = db.ExecutarConsulta(CommandType.Text, query);

				List<clHarpaHino> list = new List<clHarpaHino>();

				if (dt.Rows.Count == 0)
					return list;

				foreach (DataRow row in dt.Rows)
				{
					list.Add(ConvertRowInClHarpaHino(row));
				}

				return list;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		
		// CONVERT DT IN CLASS HARPA HINO
		// =============================================================================
		private clHarpaHino ConvertRowInClHarpaHino(DataRow r)
		{
			clHarpaHino versiculo = new clHarpaHino()
			{
				IDHino = (int)r["IDHino"],
				Titulo = (string)r["Titulo"],
				Tom = (byte)r["Tom"]
			};

			return versiculo;
		}

		// GET LIST HINO ESTROFE BY ID HINO
		// =============================================================================
		public List<clHinoEstrofe> GetEstrofesListByID(int IDHino)
		{
			try
			{
				AcessoDados db = new AcessoDados(_dataBasePath);
				DataTable dt = new DataTable();

				db.LimparParametros();
				db.AdicionarParametros("@IDHino", IDHino);

				string query = "SELECT * FROM tblHinosHarpa WHERE IDHino = @IDHino";

				dt = db.ExecutarConsulta(CommandType.Text, query);

				List<clHinoEstrofe> lstEstrofes = new List<clHinoEstrofe>();

				if (dt.Rows.Count == 0)
					return lstEstrofes;

				string Letra = (string)dt.Rows[0]["Letra"];
				string Titulo = (string)dt.Rows[0]["Titulo"];
				byte Tom = (byte)dt.Rows[0]["Tom"];

				// SEPARATE ESTROFES FROM LETRA
				char div = "[".ToCharArray()[0];
				string[] Estrofes = Letra.Split(div);

				foreach (string est in Estrofes)
				{
					if(est.Length > 0)
					{
						char divEnd = "]".ToCharArray()[0];
						string[] NumberLetra = est.Split(divEnd);

						bool IsChorus = NumberLetra[0] == "chorus";

						int EstrofeOrdem = IsChorus ? 0 : Convert.ToInt32( NumberLetra[0]);
						string Estrofe = NumberLetra[1].Trim();

						lstEstrofes.Add(new clHinoEstrofe()
						{
							Estrofe = Estrofe,
							IsCoro = IsChorus,
							IDHino = IDHino,
							EstrofeOrdem = IsChorus ? 0 : EstrofeOrdem,
							Titulo = Titulo,
							Tom = Tom,
							Repeticao = 1
						});
					}
				}

				return lstEstrofes;

			}
			catch (Exception ex)
			{
				throw ex;
			}

		}

		// GET THE ID OF LAST OR MAX IDHINO
		// =============================================================================
		public int GetMaxIDHinos()
		{
			try
			{
				AcessoDados db = new AcessoDados(_dataBasePath);
				DataTable dt = new DataTable();

				string query = "SELECT Max(IDHino) AS MaxID FROM tblHinosHarpa;";

				dt = db.ExecutarConsulta(CommandType.Text, query);

				List<clHarpaHino> list = new List<clHarpaHino>();

				if (dt.Rows.Count == 0)
					throw new Exception("Não houve possibilidade de consultar o último valor de IDHino");

				object ID = dt.Rows[0][0];

				return Convert.ToInt32(ID);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

	}
}
