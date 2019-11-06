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

		// CONVERT DT IN CLASS LOUVOR
		// =============================================================================
		private clLouvor ConvertRowInClLouvor(DataRow r)
		{
			clLouvor louvor = new clLouvor((int)r["IDLouvor"])
			{
				Titulo = (string)r["Titulo"],
				ProjecaoPath = (string)r["ProjecaoPath"],
				IDCategoria = r["IDCategoria"] == DBNull.Value ? null : (byte?)r["IDCategoria"],
				Categoria = r["Categoria"] == DBNull.Value ? string.Empty : (string)r["Categoria"],
				EscolhidoCount = (short)r["EscolhidoCount"],
				Favorito = (byte)r["Favorito"],
				FileOK = (bool)r["FileOK"],
				Ativo = (bool)r["Ativo"],
				Tom = r["Tom"] == DBNull.Value ? null : (byte?)r["Tom"],
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
		public DataTable GetFoldersList()
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

	}
}
