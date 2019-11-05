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

		#region HINO

		// GET HINO LIST
		// =============================================================================
		public List<clHarpaHino> GetHinosList(int IDHino = 0, string Titulo = "")
		{
			try
			{
				AcessoDados db = new AcessoDados(_dataBasePath);
				DataTable dt = new DataTable();

				string query = "SELECT IDHino, Titulo, Tom, Escolhido FROM tblHinosHarpa";

				dt = db.ExecutarConsulta(CommandType.Text, query);

				List<clHarpaHino> list = new List<clHarpaHino>();
				
				if (dt.Rows.Count == 0)
					return list;

				int MaxEscolhido = GetMaxCountEscolhido();

				foreach (DataRow row in dt.Rows)
				{
					list.Add(ConvertRowInClHarpaHino(row, MaxEscolhido));
				}

				return list;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// GET MAX COUNT
		// =============================================================================
		public int GetMaxCountEscolhido()
		{
			try
			{
				AcessoDados db = new AcessoDados(_dataBasePath);
				DataTable dt = new DataTable();

				string query = "SELECT Max(Escolhido) AS Maximo FROM tblHinosHarpa;";

				dt = db.ExecutarConsulta(CommandType.Text, query);

				List<clHarpaHino> list = new List<clHarpaHino>();

				if (dt.Rows.Count == 0)
					return 0;

				return (short)dt.Rows[0]["Maximo"];

			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// CONVERT DT IN CLASS HARPA HINO
		// =============================================================================
		private clHarpaHino ConvertRowInClHarpaHino(DataRow r, int MaxCount)
		{
			clHarpaHino versiculo = new clHarpaHino(MaxCount)
			{
				IDHino = (int)r["IDHino"],
				Titulo = (string)r["Titulo"],
				Tom = (byte)r["Tom"],
				Escolhido = (short)r["Escolhido"]
			};

			return versiculo;
		}

		// ADD HINO COUNT ESCOLHIDO
		// =============================================================================
		public void EscolhidoCountAdd(int IDHino)
		{
			try
			{
				AcessoDados db = new AcessoDados(_dataBasePath);
				db.LimparParametros();
				db.AdicionarParametros("@IDHino", IDHino);

				string query = "UPDATE tblHinosHarpa SET Escolhido = [Escolhido]+1 WHERE IDHino = @IDHino;";

				db.ExecutarManipulacao(CommandType.Text, query);
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

		#endregion

		#region ESTROFE

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

		#endregion

		#region HISTORICO

		// ADD HISTORICO
		// =============================================================================
		public void AddHistorico(int IDHino, string DBPath)
		{
			try
			{
				AcessoDados db = new AcessoDados(DBPath);
				db.AdicionarParametros("@IDHino", IDHino);

				string query = "INSERT INTO tblHinosHistorico(IDHino) VALUES (@IDHino)";

				db.ExecutarManipulacao(CommandType.Text, query);

			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// GET HISTORICO
		// =============================================================================
		public List<clHistoricoHino> GetHistorico()
		{
			try
			{
				AcessoDados db = new AcessoDados(_dataBasePath);
				DataTable dt = new DataTable();

				string query = "SELECT * FROM qryHinosHistorico " +
					"ORDER BY IDHistorico DESC";

				dt = db.ExecutarConsulta(CommandType.Text, query);

				List<clHistoricoHino> list = new List<clHistoricoHino>();

				if (dt.Rows.Count == 0)
					return list;

				foreach (DataRow r in dt.Rows)
				{
					clHistoricoHino versiculo = new clHistoricoHino()
					{
						IDHistorico = (int)r["IDHistorico"],
						HistoricoData = (DateTime)r["HistoricoData"],
						IDHino = (int)r["IDHino"],
						Titulo = (string)r["Titulo"],
						Tom = (byte)r["Tom"],
						Escolhido = (short)r["Escolhido"]
					};

					list.Add(versiculo);
				}

				return list;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// DELETE HISTORICO
		// =============================================================================
		public void DeleteHistoricoByID(int IDHistorico, string DBPath)
		{
			try
			{
				AcessoDados db = new AcessoDados(DBPath);

				db.LimparParametros();
				db.AdicionarParametros("@IDHistorico", IDHistorico);
				string query = "DELETE IDHistorico FROM tblHinosHistorico WHERE IDHistorico = @IDHistorico";

				db.ExecutarManipulacao(CommandType.Text, query);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// CLEAR HISTORICO
		// =============================================================================
		public void ClearHistorico(string DBPath)
		{
			try
			{
				AcessoDados db = new AcessoDados(DBPath);

				string query = "DELETE * FROM tblHinosHistorico";

				db.ExecutarManipulacao(CommandType.Text, query);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		#endregion

	}
}
