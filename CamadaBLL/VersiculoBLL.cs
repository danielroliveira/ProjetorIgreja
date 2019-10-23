using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDAL;
using CamadaDTO;

namespace CamadaBLL
{
	public class VersiculoBLL
	{
		private string _dataBasePath;

		// NEW
		public VersiculoBLL(string dataBasePath)
		{
			_dataBasePath = dataBasePath;
		}

		// GET VERSICULO LIST
		public List<clVersiculo> GetVersiculoList
			(
			byte IDLinguagem, 
			byte IDLivro, 
			byte Capitulo 
			)
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
					"Capitulo = @Capitulo";

				dt = db.ExecutarConsulta(CommandType.Text, query);

				List<clVersiculo> list = new List<clVersiculo>();

				if (dt.Rows.Count == 0) return list;

				foreach (DataRow row in dt.Rows)
				{
					list.Add(ConvertRowInClass(row));
				}

				return list;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// CONVERT DT IN CLASS
		private clVersiculo ConvertRowInClass(DataRow r)
		{
			clVersiculo versiculo = new clVersiculo()
			{
				IDVersiculo = (int)r["IDVersiculo"],
				IDLivro = (byte)r["IDLivro"],
				Livro = (string)r["Livro"],
				Capitulo = (byte)r["Capitulo"],
				Versiculo = (byte)r["Versiculo"],
				IDLinguagem = (byte)r["IDLinguagem"],
				Escritura = (string)r["Escritura"]
			};

			return versiculo;

		}

	}
}
