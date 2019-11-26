using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;


namespace CamadaUI
{
	public class ZipFileFunc
	{
		public bool CreateZipFromDirectory()
		{
			string zipPath = @"c:\users\exampleuser\start.zip";
			string extractPath = @"c:\users\exampleuser\extract";
			string newFile = @"c:\users\exampleuser\NewFile.txt";

			using (ZipArchive archive = ZipFile.Open(zipPath, ZipArchiveMode.Update))
			{
				archive.CreateEntryFromFile(newFile, "NewEntry.txt");
				archive.ExtractToDirectory(extractPath);
			}

			return true;

		}
	}
}
