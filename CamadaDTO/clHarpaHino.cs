namespace CamadaDTO
{
	public class clHarpaHino
	{
		public int? IDHino { get; set; }
		public string Titulo { get; set; }
		public byte? Tom { get; set; }
		public int? Escolhido { get; set; }
		private int CountMaxEscolhido { get;  set; }

		public string TomCifra
		{
			get {

				string Cifra;

				switch (Tom)
				{
					case 1:
						Cifra = "A";
						break;
					case 2:
						Cifra = "Bb";
						break;
					case 3:
						Cifra = "B";
						break;
					case 4:
						Cifra = "C";
						break;
					case 5:
						Cifra = "C#";
						break;
					case 6:
						Cifra = "D";
						break;
					case 7:
						Cifra = "Eb";
						break;
					case 8:
						Cifra = "E";
						break;
					case 9:
						Cifra = "F";
						break;
					case 10:
						Cifra = "F#";
						break;
					case 11:
						Cifra = "G";
						break;
					case 12:
						Cifra = "Ab";
						break;
					default:
						Cifra = "A";
						break;
				}

				return Cifra;
			}
		}

		// SUB NEW
		public clHarpaHino()
		{
			IDHino = 1; // define primeiro
			Tom = 1; // define A
			Escolhido = 0;
		}

		public byte Classificacao
		{
			get
			{
				double faixa = CountMaxEscolhido / 6;

				if (Escolhido < faixa) return 0;
				else if (Escolhido <= faixa * 2) return 1;
				else if (Escolhido <= faixa * 3) return 2;
				else if (Escolhido <= faixa * 4) return 3;
				else if (Escolhido <= faixa * 5) return 4;
				else if (Escolhido >= faixa * 5) return 5;
				else return 0;
			}
		}

		// SUB NEW
		public clHarpaHino(int _CountMaxEscolhido)
		{
			IDHino = 1; // define primeiro
			Tom = 1; // define A
			Escolhido = 0;
			CountMaxEscolhido = _CountMaxEscolhido;
		}
	}
}
