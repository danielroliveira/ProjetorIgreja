using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaDTO
{
	public class clLouvor : IEditableObject
	{
		#region NEW | STRUCT

		struct StructData
		{
			internal int IDLouvor;
			internal string Titulo;
			internal string ProjecaoPath;
			internal short? IDCategoria; // string Categoria
			internal short EscolhidoCount;
			internal byte Favorito;
			internal bool FileOK;
			internal bool Ativo;
			internal byte? Tom;
		}

		private StructData myData;
		private StructData backupData;
		private bool inTxn = false;

		// SUB NEW
		public clLouvor(int ID) : base()
		{
			myData = new StructData();
			myData.IDLouvor = ID;
			myData.Titulo = "";
			myData.FileOK = true;
			myData.Ativo = true;
			myData.EscolhidoCount = 0;
		}

		#endregion

		#region IMPLEMENTS IEDITABLEOBJECT

		void IEditableObject.BeginEdit()
		{
			if (!inTxn)
			{
				backupData = myData;
				inTxn = true;
			}
		}

		void IEditableObject.CancelEdit()
		{
			if (inTxn)
			{
				myData = backupData;
				inTxn = false;
			}
		}

		void IEditableObject.EndEdit()
		{
			if (inTxn)
			{
				backupData = new StructData();
				inTxn = false;
			}
		}

		#endregion

		#region FUNCTIONS

		public event AlteradoHandler Alterado;
		public delegate void AlteradoHandler();

		public override string ToString()
		{
			return Titulo;
		}

		public bool RegistroAlterado
		{
			get => inTxn;
		}

		#endregion

		#region PROPERTIES

		// IDLouvorFolder
		// ---------------------------------------------------------------------------
		public int IDLouvor
		{
			get => myData.IDLouvor;
			set => myData.IDLouvor = value;
		}

		// Property Titulo
		//------------------------------------------------------
		public string Titulo
		{
			get => myData.Titulo;
			set
			{
				if (value != myData.Titulo)
				{
					Alterado?.Invoke();
				}
				myData.Titulo = value;
			}
		}

		// Property ProjecaoPath
		//------------------------------------------------------
		public string ProjecaoPath
		{
			get => myData.ProjecaoPath;
			set
			{
				if (value != myData.ProjecaoPath)
				{
					Alterado?.Invoke();
				}
				myData.ProjecaoPath = value;
			}
		}

		// Property ProjecaoPath
		//------------------------------------------------------
		public string ProjecaoFileName
		{
			get => Path.GetFileName(ProjecaoPath);
		}

		// Property IDCategoria
		//------------------------------------------------------
		public short? IDCategoria
		{
			get => myData.IDCategoria;
			set
			{
				if (value != myData.IDCategoria)
				{
					Alterado?.Invoke();
				}
				myData.IDCategoria = value;
			}
		}

		// Property Categoria
		//------------------------------------------------------
		public string Categoria { get; set; }


		// Property EscolhidoCount
		//------------------------------------------------------
		public short EscolhidoCount
		{
			get => myData.EscolhidoCount;
			set
			{
				if (value != myData.EscolhidoCount)
				{
					Alterado?.Invoke();
				}
				myData.EscolhidoCount = value;
			}
		}

		// Property Favorito
		//------------------------------------------------------
		public byte Favorito
		{
			get => myData.Favorito;
			set
			{
				if (value != myData.Favorito)
				{
					Alterado?.Invoke();
				}
				myData.Favorito = value;
			}
		}

		// Property FileOK
		//------------------------------------------------------
		public bool FileOK
		{
			get => myData.FileOK;
			set
			{
				if (value != myData.FileOK)
				{
					Alterado?.Invoke();
				}
				myData.FileOK = value;
			}
		}

		// Property Ativo
		//------------------------------------------------------
		public bool Ativo
		{
			get => myData.Ativo;
			set
			{
				if (value != myData.Ativo)
				{
					Alterado?.Invoke();
				}
				myData.Ativo = value;
			}
		}

		// Property Tom
		//------------------------------------------------------
		public byte? Tom
		{
			get => myData.Tom;
			set
			{
				if (value != myData.Tom)
				{
					Alterado?.Invoke();
				}
				myData.Tom = value;
			}
		}

		// Property TomCifra
		//------------------------------------------------------
		public string TomCifra
		{
			get
			{

				string Cifra;

				switch (Tom)
				{
					case 1:
						Cifra = "A | Am";
						break;
					case 2:
						Cifra = "Bb | Bbm";
						break;
					case 3:
						Cifra = "B | Bm";
						break;
					case 4:
						Cifra = "C | Cm";
						break;
					case 5:
						Cifra = "C# | C#m";
						break;
					case 6:
						Cifra = "D | Dm";
						break;
					case 7:
						Cifra = "Eb | Ebm";
						break;
					case 8:
						Cifra = "E | Em";
						break;
					case 9:
						Cifra = "F | Fm";
						break;
					case 10:
						Cifra = "F# | F#m";
						break;
					case 11:
						Cifra = "G | Gm";
						break;
					case 12:
						Cifra = "Ab | Abm";
						break;
					default:
						Cifra = "...";
						break;
				}

				return Cifra;
			}
		}

		#endregion
	}
}
