using System;
using System.Collections.Generic;
using System.Data;
using CamadaDAL;
using CamadaDTO;

namespace CamadaBLL
{
	public class LouvorBLL
	{
		private string _dataBasePath;

		// NEW
		// =============================================================================
		public LouvorBLL(string dataBasePath)
		{
			_dataBasePath = dataBasePath;
		}

		#region LOUVOR

		// GET LOUVOR LIST
		// =============================================================================
		public List<clLouvor> GetLouvorList(int IDHino = 0, string Titulo = "")
		{
			try
			{
				AcessoDados db = new AcessoDados(_dataBasePath);
				DataTable dt = new DataTable();

				string query = "SELECT * FROM qryLouvores ORDER BY Titulo";

				dt = db.ExecutarConsulta(CommandType.Text, query);

				List<clLouvor> list = new List<clLouvor>();

				if (dt.Rows.Count == 0)
					return list;

				foreach (DataRow row in dt.Rows)
				{
					list.Add(ConvertRowInClLouvor(row));
				}

				return list;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// INSERT LOUVOR IN DB
		// =============================================================================
		public void InsertLouvor(clLouvor louvor)
		{
			try
			{
				AcessoDados db = new AcessoDados(_dataBasePath);
				db.LimparParametros();
				db.AdicionarParametros("@IDLouvor", louvor.IDLouvor);
				db.AdicionarParametros("@Titulo", louvor.Titulo);
				db.AdicionarParametros("@ProjecaoPath", louvor.ProjecaoPath);

				string query = "INSERT INTO tblLouvores (IDLouvor, Titulo, ProjecaoPath) " +
					"VALUES (@IDLouvor, @Titulo, @ProjecaoPath);";

				db.ExecutarManipulacao(CommandType.Text, query);
			}
			catch (System.Data.OleDb.OleDbException ex)
			{
				if(ex.ErrorCode == -2147467259)
				{
					//return;
					throw new AppException("Louvor Duplicado: " + louvor.Titulo);
				}
				else
				{
					throw ex;
				}

			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// UPDATE LOUVOR IN DB
		// =============================================================================
		public void UpdateLouvor(clLouvor louvor)
		{
			try
			{
				AcessoDados db = new AcessoDados(_dataBasePath);
				db.LimparParametros();
				db.AdicionarParametros("@Titulo", louvor.Titulo);
				db.AdicionarParametros("@ProjecaoPath", louvor.ProjecaoPath);
				db.AdicionarParametros("@Favorito", louvor.Favorito);
				db.AdicionarParametros("@IDCategoria", (object)louvor.IDCategoria ?? DBNull.Value);
				db.AdicionarParametros("@Ativo", louvor.Ativo);
				db.AdicionarParametros("@EscolhidoCount", louvor.EscolhidoCount);
				db.AdicionarParametros("@Tom", (object)louvor.Tom ?? DBNull.Value);
				db.AdicionarParametros("@FileOK", louvor.FileOK);
				db.AdicionarParametros("@IDLouvor", louvor.IDLouvor);

				string query =
					"UPDATE tblLouvores SET " +
					"Titulo = @Titulo, " +
					"ProjecaoPath = @ProjecaoPath, " +
					"Favorito = @Favorito, " +
					"IDCategoria = @IDCategoria, " +
					"Ativo = @Ativo, " +
					"EscolhidoCount = @EscolhidoCount, " +
					"Tom = @Tom, " +
					"FileOK = @FileOK " +
					"WHERE IDLouvor = @IDLouvor;";

				db.ExecutarManipulacao(CommandType.Text, query);
			}
			catch (System.Data.OleDb.OleDbException ex)
			{
				if (ex.ErrorCode == -2147467259)
				{
					//return;
					throw new AppException("Esse Titulo de Louvor já foi utilizado: " + louvor.Titulo);
				}
				else
				{
					throw ex;
				}

			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// UPDATE LOUVOR TOM BY ID
		// =============================================================================
		public void UpdateTomLouvor(int IDLouvor, byte newTom)
		{
			try
			{
				AcessoDados db = new AcessoDados(_dataBasePath);
				db.LimparParametros();
				db.AdicionarParametros("@Tom", newTom);
				db.AdicionarParametros("@IDLouvor", IDLouvor);

				string query =
					"UPDATE tblLouvores SET " +
					"Tom = @Tom " +
					"WHERE IDLouvor = @IDLouvor;";

				db.ExecutarManipulacao(CommandType.Text, query);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// UPDATE LOUVOR ATIVO/INATIVO BY ID
		// =============================================================================
		public void UpdateAtivoLouvor(int IDLouvor, bool Ativo)
		{
			try
			{
				AcessoDados db = new AcessoDados(_dataBasePath);
				db.LimparParametros();
				db.AdicionarParametros("@Ativo", Ativo);
				db.AdicionarParametros("@IDLouvor", IDLouvor);

				string query =
					"UPDATE tblLouvores SET " +
					"Ativo = @Ativo " +
					"WHERE IDLouvor = @IDLouvor;";

				db.ExecutarManipulacao(CommandType.Text, query);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// UPDATE LOUVOR FILEOK BY ID
		// =============================================================================
		public void UpdateFileOKLouvor(int IDLouvor, bool FileOK)
		{
			try
			{
				AcessoDados db = new AcessoDados(_dataBasePath);
				db.LimparParametros();
				db.AdicionarParametros("@FileOK", FileOK);
				db.AdicionarParametros("@IDLouvor", IDLouvor);

				string query =
					"UPDATE tblLouvores SET " +
					"FileOK = @FileOK " +
					"WHERE IDLouvor = @IDLouvor;";

				db.ExecutarManipulacao(CommandType.Text, query);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// ADD ONE LOUVOR ESCOLHIDO BY ID
		// =============================================================================
		public void AddEscolhidoLouvor(int IDLouvor)
		{
			try
			{
				AcessoDados db = new AcessoDados(_dataBasePath);
				db.LimparParametros();
				db.AdicionarParametros("@IDLouvor", IDLouvor);

				string query =
					"UPDATE tblLouvores SET " +
					"EscolhidoCount = EscolhidoCount + 1 " +
					"WHERE IDLouvor = @IDLouvor;";

				db.ExecutarManipulacao(CommandType.Text, query);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// CONVERT DT IN CLASS LOUVOR
		// =============================================================================
		private clLouvor ConvertRowInClLouvor(DataRow r)
		{
			clLouvor louvor = new clLouvor((int)r["IDLouvor"])
			{
				Titulo = (string)r["Titulo"],
				ProjecaoPath = (string)r["ProjecaoPath"],
				IDCategoria = r["IDCategoria"] == DBNull.Value ? null : (short?)r["IDCategoria"],
				Categoria = r["Categoria"] == DBNull.Value ? string.Empty : (string)r["Categoria"],
				EscolhidoCount = (short)r["EscolhidoCount"],
				Favorito = (byte)r["Favorito"],
				FileOK = (bool)r["FileOK"],
				Ativo = (bool)r["Ativo"],
				Tom = r["Tom"] == DBNull.Value ? null : (byte?)r["Tom"]
			};

			return louvor;
		}

		// ADD LOUVOR COUNT ESCOLHIDO
		// =============================================================================
		public void EscolhidoCountAdd(int IDLouvor)
		{
			try
			{
				AcessoDados db = new AcessoDados(_dataBasePath);
				db.LimparParametros();
				db.AdicionarParametros("@IDLouvor", IDLouvor);

				string query = "UPDATE tblLouvores SET EscolhidoCount = [EscolhidoCount]+1 WHERE IDLouvor = @IDLouvor;";

				db.ExecutarManipulacao(CommandType.Text, query);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// GET THE ID OF LAST OR MAX IDLOUVOR
		// =============================================================================
		public int GetMaxIDLouvor()
		{
			try
			{
				AcessoDados db = new AcessoDados(_dataBasePath);
				DataTable dt = new DataTable();

				string query = "SELECT Max(IDLouvor) AS MaxID FROM tblLouvores;";

				dt = db.ExecutarConsulta(CommandType.Text, query);

				List<clLouvor> list = new List<clLouvor>();

				if (dt.Rows.Count == 0)
					throw new Exception("Não houve possibilidade de consultar o último valor de IDLouvor");

				object ID = dt.Rows[0][0];

				return Convert.ToInt32(ID);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		#endregion

		#region FOLDERS
		
		// GET LOUVOR FOLDERS LIST
		// =============================================================================
		public DataTable GetFoldersDT()
		{
			try
			{
				AcessoDados db = new AcessoDados(_dataBasePath);
				DataTable dt = new DataTable();

				string query = "SELECT * FROM tblLouvoresFolders ORDER BY IDLouvorFolder";

				return db.ExecutarConsulta(CommandType.Text, query);

			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// INSERT LOUVOR IN DB
		// =============================================================================
		public int InsertFolder(string folder)
		{
			try
			{
				AcessoDados db = new AcessoDados(_dataBasePath);
				db.LimparParametros();
				db.AdicionarParametros("@LouvorFolder", folder);

				string query = "INSERT INTO tblLouvoresFolders (LouvorFolder) " +
					"VALUES (@LouvorFolder);";

				db.ExecutarManipulacao(CommandType.Text, query);

				db.LimparParametros();
				query = "SELECT Max(IDLouvorFolder) AS Maximo FROM tblLouvoresFolders";
				DataTable dt = db.ExecutarConsulta(CommandType.Text, query);

				if (dt.Rows.Count == 0)
					return 0;

				return (int)dt.Rows[0][0];

			}
			catch (System.Data.OleDb.OleDbException ex)
			{
				if (ex.ErrorCode == -2147467259)
				{
					//return;
					throw new AppException("Essa pasta já foi inserida...");
				}
				else
				{
					throw ex;
				}

			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// DELETE FOLDER BY ID
		// =============================================================================
		public void DeleteFolderByID(int IDLouvorFolder)
		{
			try
			{
				AcessoDados db = new AcessoDados(_dataBasePath);

				db.LimparParametros();
				db.AdicionarParametros("@IDHistorico", IDLouvorFolder);
				string query = "DELETE IDLouvorFolder FROM tblLouvoresFolders WHERE IDLouvorFolder = @IDLouvorFolder";

				db.ExecutarManipulacao(CommandType.Text, query);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		#endregion

		#region CATEGORIAS

		// GET LOUVOR CATEGORIAS DT
		// =============================================================================
		public DataTable GetLouvorCategoriaDT()
		{
			try
			{
				AcessoDados db = new AcessoDados(_dataBasePath);
				DataTable dt = new DataTable();

				string query = "SELECT * FROM tblLouvoresCategorias ORDER BY Categoria";

				return db.ExecutarConsulta(CommandType.Text, query);

			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// INSERT CATEGORIA IN DB
		// =============================================================================
		public int InsertCategoria(string categoria)
		{
			try
			{
				AcessoDados db = new AcessoDados(_dataBasePath);

				// GET NEW ID
				db.LimparParametros();
				string query = "SELECT Max(IDCategoria) AS Maximo FROM tblLouvoresCategorias";
				DataTable dt = db.ExecutarConsulta(CommandType.Text, query);

				int maxID = 0;

				if (dt.Rows.Count == 0)
					maxID = 0;
				else
					maxID = (short)dt.Rows[0][0];

				if(maxID == 255) // check if not is a byte number
				{
					throw new AppException("O número máximo de categorias possíveis chegou ao limite...");
				}

				maxID += 1; // aumenta uma unidade no IDCategoria
								
				db.LimparParametros();
				db.AdicionarParametros("@IDCategoria", maxID);
				db.AdicionarParametros("@Categoria", categoria);

				query = "INSERT INTO tblLouvoresCategorias (IDCategoria, Categoria) " +
					"VALUES (@IDCategoria, @Categoria);";

				db.ExecutarManipulacao(CommandType.Text, query);

				return maxID;

			}
			catch (System.Data.OleDb.OleDbException ex)
			{
				if (ex.ErrorCode == -2147467259)
				{
					//return;
					throw new AppException("Essa categoria já foi inserida...");
				}
				else
				{
					throw ex;
				}

			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// UPDATE CATEGORIA BY ID AND CATEGORIA
		// =============================================================================
		public void UpdateCategoria(int IDCategoria, string Categoria)
		{
			try
			{
				AcessoDados db = new AcessoDados(_dataBasePath);

				// UPDATE category
				db.LimparParametros();
				db.AdicionarParametros("@Categoria", Categoria);
				db.AdicionarParametros("@IDCategoria", IDCategoria);

				string query = "UPDATE tblLouvoresCategorias SET Categoria = @Categoria WHERE IDCategoria = @IDCategoria";

				db.ExecutarManipulacao(CommandType.Text, query);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// DELETE CATEGORIA BY ID
		// =============================================================================
		public void DeleteCategoriaByID(int IDCategoria)
		{
			try
			{
				AcessoDados db = new AcessoDados(_dataBasePath);

				// Remove all louvor that it have this category
				db.LimparParametros();
				db.AdicionarParametros("@IDCategoria", IDCategoria);
				string query = "UPDATE tblLouvores SET IDCategoria = NULL WHERE IDCategoria = @IDCategoria;";

				db.ExecutarManipulacao(CommandType.Text, query);

				// delete category
				db.LimparParametros();
				db.AdicionarParametros("@IDCategoria", IDCategoria);
				query = "DELETE IDCategoria FROM tblLouvoresCategorias WHERE IDCategoria = @IDCategoria";

				db.ExecutarManipulacao(CommandType.Text, query);
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
		public void AddHistorico(int IDLouvor)
		{
			try
			{
				AcessoDados db = new AcessoDados(_dataBasePath);
				db.LimparParametros();
				db.AdicionarParametros("@IDLouvor", IDLouvor);

				// check the last IDLouvor add in historico
				string query = "SELECT TOP 1 IDLouvor FROM tblLouvoresHistorico ORDER BY IDHistorico DESC";
				DataTable dt = db.ExecutarConsulta(CommandType.Text, query);

				if(dt.Rows.Count > 0)
				{
					int LastID = (int)dt.Rows[0][0];
					if(LastID == IDLouvor) // check if is duplicated
					{
						return;
					}
				}

				// add in historico
				db.LimparParametros();
				db.AdicionarParametros("@IDLouvor", IDLouvor);
				query = "INSERT INTO tblLouvoresHistorico(IDLouvor) VALUES (@IDLouvor)";

				db.ExecutarManipulacao(CommandType.Text, query);

			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// GET HISTORICO
		// =============================================================================
		public List<clHistoricoLouvor> GetHistorico()
		{
			try
			{
				AcessoDados db = new AcessoDados(_dataBasePath);
				DataTable dt = new DataTable();

				string query = "SELECT * FROM qryLouvorHistorico " +
					"ORDER BY IDHistorico DESC";

				dt = db.ExecutarConsulta(CommandType.Text, query);

				List<clHistoricoLouvor> list = new List<clHistoricoLouvor>();

				if (dt.Rows.Count == 0)
					return list;

				foreach (DataRow r in dt.Rows)
				{
					clHistoricoLouvor louvor = new clHistoricoLouvor((int)r["IDLouvor"])
					{
						IDHistorico = (int)r["IDHistorico"],
						HistoricoData = (DateTime)r["HistoricoData"],
						Titulo = (string)r["Titulo"],
						Tom = r["Tom"] == DBNull.Value ? null : (byte?)r["Tom"],
						EscolhidoCount = (short)r["EscolhidoCount"]
					};

					list.Add(louvor);
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
				string query = "DELETE IDHistorico FROM tblLouvoresHistorico WHERE IDHistorico = @IDHistorico";

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

				string query = "DELETE * FROM tblLouvoresHistorico";

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
