namespace CamadaDTO
{
	public class clVersiculo
	{
		public int? IDVersiculo { get; set; }
		public byte? IDLivro { get; set; }
		public string Livro { get; set; }
		public byte? Capitulo { get; set; }
		public byte? Versiculo { get; set; }
		public byte IDLinguagem { get; set; }
		public byte Testamento { get; set; }
		public string Escritura { get; set; }

		public clVersiculo()
		{
			Testamento = 1; // define testamento AT
			IDLivro = 1; // define Gênesis
			Capitulo = 1;
			Versiculo = 1;
			IDLinguagem = 1; // define RC
		}
	}
}
