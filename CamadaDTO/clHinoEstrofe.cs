using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaDTO
{
	public class clHinoEstrofe: clHarpaHino
	{
		public int EstrofeOrdem { get; set; }
		public string Estrofe { get; set; }
		public bool IsCoro { get; set; }
		public int Repeticao { get; set; }

		// SUB NEW
		public clHinoEstrofe()
		{
			IsCoro = false;
			Repeticao = 0;
		}

	}
}
