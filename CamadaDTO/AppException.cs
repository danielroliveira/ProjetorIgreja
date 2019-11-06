using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaDTO
{
	//==========================================================================================
	// APP EXCEPTION
	//==========================================================================================
	public class AppException : Exception
	{
		public AppException(string message) 
			: base(message)
		{}

		public AppException(string message, Exception inner )
			: base(message, inner)
		{}
	}
}
