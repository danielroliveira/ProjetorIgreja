using System;

namespace CamadaDTO
{
	public class clHistoricoVersiculo : clVersiculo
	{
		public int IDHistorico { get; set; }
		public DateTime HistoricoData { get; set; }
		public string Sigla { get; set; }
		public string Abreviacao { get; set; }

		public string Referencia
		{
			get => $"{Abreviacao} {Capitulo}:{Versiculo} {Sigla}";
		}

		public string HistoricoDataDesc
		{
			get => HistoricoUtil.HistoricoDataTexto(HistoricoData);
		}

	}

	public class clHistoricoHino : clHarpaHino
	{
		public int IDHistorico { get; set; }
		public DateTime HistoricoData { get; set; }

		public string HistoricoDataDesc
		{
			get => HistoricoUtil.HistoricoDataTexto(HistoricoData);
		}
	}

	public class clHistoricoLouvor : clLouvor
	{
		public clHistoricoLouvor(int IDLouvor) : base(IDLouvor)
		{ }

		public int IDHistorico { get; set; }
		public DateTime HistoricoData { get; set; }

		public string HistoricoDataDesc
		{
			get => HistoricoUtil.HistoricoDataTexto(HistoricoData);
		}
	}

	public static class HistoricoUtil
	{
		public static string HistoricoDataTexto(DateTime HistData)
		{
			DateTime Hoje = DateTime.Today;
			int DateDiff = (DateTime.Today - HistData).Days;

			if (DateDiff == 0)
			{
				return "Hoje";
			}
			else if (DateDiff == 1)
			{
				return "Ontem";
			}
			else if (DateDiff > 1 && DateDiff < 31)
			{
				return $"{DateDiff} dias";
			}
			else if (DateDiff >= 31 && DateDiff < 366)
			{
				int quant = Hoje.Month - HistData.Month;
				string txt = quant == 1 ? "mes" : "meses";
				return $"{quant} {txt}";
			}
			else if (DateDiff >= 366)
			{
				int quant = Hoje.Year - HistData.Year;
				string txt = quant == 1 ? "ano" : "anos";
				return $"{quant} {txt}";
			}
			else
			{
				return HistData.ToShortDateString();
			}
		}
	}

}
