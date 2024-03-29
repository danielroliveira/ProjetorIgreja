﻿using System;
using System.Collections.Generic;
using System.Data;
using CamadaDAL;
using CamadaDTO;

namespace CamadaBLL
{
	public class VersiculoBLL
	{
		private string _dataBasePath;

		// NEW
		// =============================================================================
		public VersiculoBLL(string dataBasePath)
		{
			_dataBasePath = dataBasePath;
		}

		#region VERSICULOS
		
		// GET VERSICULO LIST
		// =============================================================================
		public List<clVersiculo> GetVersiculoList
			(byte IDLinguagem, byte IDLivro, byte Capitulo)
		{
			try
			{
				AcessoDados db = new AcessoDados(_dataBasePath);
				DataTable dt = new DataTable();

				db.AdicionarParametros("@IDLinguagem", IDLinguagem);
				db.AdicionarParametros("@IDLivro", IDLivro);
				db.AdicionarParametros("@Capitulo", Capitulo);

				string query = "SELECT * FROM qryLeituraBiblica WHERE " +
					"IDLinguagem = @IDLinguagem AND " +
					"IDLivro = @IDLivro AND " +
					"Capitulo = @Capitulo " + 
					"ORDER BY Versiculo";

				dt = db.ExecutarConsulta(CommandType.Text, query);

				List<clVersiculo> list = new List<clVersiculo>();

				if (dt.Rows.Count == 0) return list;

				foreach (DataRow row in dt.Rows)
				{
					list.Add(ConvertRowInClVersiculo(row));
				}

				return list;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// GET VERSICULO BY ID
		// =============================================================================
		public clVersiculo GetVersiculoByID(int IDVersiculo)
		{
			try
			{
				AcessoDados db = new AcessoDados(_dataBasePath);
				DataTable dt = new DataTable();

				db.AdicionarParametros("@IDVersiculo", IDVersiculo);

				string query = "SELECT * FROM qryLeituraBiblica WHERE " +
					"IDVersiculo = @IDVersiculo ";

				dt = db.ExecutarConsulta(CommandType.Text, query);

				if (dt.Rows.Count == 0)
					throw new Exception("ID Versículo não encontrado...");

				return ConvertRowInClVersiculo(dt.Rows[0]);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// CONVERT DT IN CLASS VERSICULO
		// =============================================================================
		private clVersiculo ConvertRowInClVersiculo(DataRow r)
		{
			clVersiculo versiculo = new clVersiculo()
			{
				IDVersiculo = (int)r["IDVersiculo"],
				IDLivro = (byte)r["IDLivro"],
				Livro = (string)r["Livro"],
				Capitulo = (byte)r["Capitulo"],
				Versiculo = (byte)r["Versiculo"],
				IDLinguagem = (byte)r["IDLinguagem"],
				Escritura = (string)r["Escritura"],
				Testamento = (byte)r["Testamento"]
			};

			return versiculo;

		}

		#endregion
		
		#region HISTORICO

		// ADD HISTORICO
		// =============================================================================
		public void AddHistorico(int IDVersiculo, string DBPath)
		{
			try
			{
				AcessoDados db = new AcessoDados(DBPath);
				db.AdicionarParametros("@IDVersiculo", IDVersiculo);

				string query = "INSERT INTO tblBibliasHistorico(IDVersiculo) VALUES (@IDVersiculo)";

				db.ExecutarManipulacao(CommandType.Text, query);

			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// GET HISTORICO
		// =============================================================================
		public List<clHistoricoVersiculo> GetHistorico()
		{
			try
			{
				AcessoDados db = new AcessoDados(_dataBasePath);
				DataTable dt = new DataTable();

				string query = "SELECT * FROM qryBibliasHistorico " +
					"ORDER BY IDHistorico DESC";

				dt = db.ExecutarConsulta(CommandType.Text, query);

				List<clHistoricoVersiculo> list = new List<clHistoricoVersiculo>();

				if (dt.Rows.Count == 0)
					return list;

				foreach (DataRow r in dt.Rows)
				{
					clHistoricoVersiculo versiculo = new clHistoricoVersiculo()
					{
						IDHistorico = (int)r["IDHistorico"],
						HistoricoData = (DateTime)r["HistoricoData"],
						IDVersiculo = (int)r["IDVersiculo"],
						IDLivro = (byte)r["IDLivro"],
						Livro = (string)r["Livro"],
						Capitulo = (byte)r["Capitulo"],
						Versiculo = (byte)r["Versiculo"],
						IDLinguagem = (byte)r["IDLinguagem"],
						Escritura = (string)r["Escritura"],
						Testamento = (byte)r["Testamento"],
						Sigla = (string)r["Sigla"],
						Abreviacao = (string)r["Abreviacao"]
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
				string query = "DELETE IDHistorico FROM tblBibliasHistorico WHERE IDHistorico = @IDHistorico";

				db.ExecutarManipulacao(CommandType.Text, query);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// CLEAR HISTORICO
		// =============================================================================
		public void ClearHistorico()
		{
			try
			{
				AcessoDados db = new AcessoDados(_dataBasePath);

				string query = "DELETE * FROM tblBibliasHistorico";

				db.ExecutarManipulacao(CommandType.Text, query);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		#endregion

		#region LINGUAGENS

		// GET LINGUAGENS LIST
		// =============================================================================
		public List<clLinguagem> GetLinguagemList()
		{
			try
			{
				AcessoDados db = new AcessoDados(_dataBasePath);
				DataTable dt = new DataTable();

				string query = "SELECT * FROM tblLinguagens";

				dt = db.ExecutarConsulta(CommandType.Text, query);

				List<clLinguagem> list = new List<clLinguagem>();

				if (dt.Rows.Count == 0) return list;

				foreach (DataRow row in dt.Rows)
				{
					list.Add(ConvertRowInClLinguagem(row));
				}

				return list;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// CONVERT DT IN CLASS LINGUAGEM
		// =============================================================================
		private clLinguagem ConvertRowInClLinguagem(DataRow r)
		{
			clLinguagem ling = new clLinguagem()
			{
				IDLinguagem = (byte)r["IDLinguagem"],
				Linguagem = (string)r["Linguagem"],
				Sigla = (string)r["Sigla"]
			};

			return ling;
		}

		#endregion

		#region LIVROS

		// GET LIVROS LIST
		// =============================================================================
		public List<clLivro> GetLivroList()
		{
			try
			{
				AcessoDados db = new AcessoDados(_dataBasePath);
				DataTable dt = new DataTable();

				string query = "SELECT * FROM tblLivros";

				dt = db.ExecutarConsulta(CommandType.Text, query);

				List<clLivro> list = new List<clLivro>();

				if (dt.Rows.Count == 0) return list;

				foreach (DataRow row in dt.Rows)
				{
					list.Add(ConvertRowInClLivro(row));
				}

				return list;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// CONVERT DT IN CLASS LIVRO
		// =============================================================================
		private clLivro ConvertRowInClLivro(DataRow r)
		{
			clLivro livro = new clLivro()
			{
				IDLivro = (byte)r["IDLivro"],
				Livro = (string)r["Livro"],
				Abreviacao = (string)r["Abreviacao"],
				Capitulos = (byte)r["Capitulo"]
			};

			return livro;
		}

		#endregion

	}
}
