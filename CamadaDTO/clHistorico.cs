﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaDTO
{
	public class clHistorico: clVersiculo
	{
		public int IDHistorico { get; set; }
		public DateTime HistoricoData { get; set; }
		public string Sigla { get; set; }
		public string Abreviacao { get; set; }

		public string Referencia {
			get	{return $"{Abreviacao} {Capitulo}:{Versiculo} {Sigla}";}
		}
	}
}
