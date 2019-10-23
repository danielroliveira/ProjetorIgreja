using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaDTO
{
	public class clVersiculo
	{
		public int IDVersiculo { get; set; }
		public byte IDLivro { get; set; }
		public string Livro { get; set; }
		public byte Capitulo { get; set; }
		public byte Versiculo { get; set; }
		public byte IDLinguagem { get; set; }
		public string Escritura { get; set; }
	}
}
