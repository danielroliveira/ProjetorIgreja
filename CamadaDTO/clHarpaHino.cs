namespace CamadaDTO
{
	public class clHarpaHino
	{
		public int? IDHino { get; set; }
		public string Titulo { get; set; }
		public byte? Tom { get; set; }

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
		}
	}
}
