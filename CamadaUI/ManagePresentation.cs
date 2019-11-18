using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.PowerPoint;
using Microsoft.Office.Core;
using System.IO;

namespace CamadaUI
{
	public class ManagePresentation
	{

		public void EditPresentation(string FileName)
		{
			Application ppApp = new Application();
			ppApp.Visible = MsoTriState.msoTrue;
			Presentations ppPresens = ppApp.Presentations;
			Presentation objPres = ppPresens.Open(FileName, MsoTriState.msoFalse, MsoTriState.msoFalse, MsoTriState.msoTrue);
			/*
			Slides objSlides = objPres.Slides;
			SlideShowWindows objSSWs;
			SlideShowSettings objSSS;
			
			//Run the Slide show
			objSSS = objPres.SlideShowSettings;
			objSSS.Run();
			objSSWs = ppApp.SlideShowWindows;

			while (objSSWs.Count >= 1)
				System.Threading.Thread.Sleep(100);
			
			*/
			//Close the presentation without saving changes and quit PowerPoint
			objPres.Close();
			ppApp.Quit();
		}

	}
}
