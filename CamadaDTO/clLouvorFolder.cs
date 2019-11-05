using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CamadaDTO
{
	public class clLouvorFolder : IEditableObject
	{
		#region NEW | STRUCT

		struct StructData
		{
			internal int IDLouvorFolder;
			internal string LouvorFolder;
		}

		private StructData myData;
		private StructData backupData;
		private bool inTxn = false;

		// SUB NEW
		public clLouvorFolder(int ID) : base()
		{
			myData = new StructData();
			myData.IDLouvorFolder = ID;
			myData.LouvorFolder = "";
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

		public delegate void AlteradoEventHandler();
		public event AlteradoEventHandler Alterado;

		public override string ToString()
		{
			return LouvorFolder;
		}
		
		public bool RegistroAlterado
		{
			get => inTxn;
		}

		#endregion

		#region PROPERTIES

		// IDLouvorFolder
		public int IDLouvorFolder
		{
			get => myData.IDLouvorFolder;
		}

		// LouvorFolder
		public string LouvorFolder
		{
			get => myData.LouvorFolder;
			set
			{
				if(value != myData.LouvorFolder)
				{
					Alterado();
				}
				myData.LouvorFolder = value;
			}
		}

		#endregion
	}
}
