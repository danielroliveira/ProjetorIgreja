using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace CamadaUI
{
	public class ZipFileFunc
	{
		// CREATE ZIP FROM DIRECTORY FILES
		// =============================================================================
		public bool CreateZipFromDirectory(string startPath, string zipPath)
		{
			try
			{
				ZipFile.CreateFromDirectory(startPath, zipPath);
				return true;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// EXTRACT FILE TO DIRECTORY
		// =============================================================================
		public bool ExtractFileToDirectory(string zipPath, string extractPath)
		{
			try
			{
				ZipFile.ExtractToDirectory(zipPath, extractPath);
				return true;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// INSERT FILE IN ZIP
		// =============================================================================
		public bool CreateZipAndInsertFiles(DirectoryInfo sourceFolder, string zipPath, ProgressBar bar)
		{
			try
			{
				using (ZipArchive archive = ZipFile.Open(zipPath, ZipArchiveMode.Create))
				{

					foreach (FileInfo file in sourceFolder.GetFiles())
					{
						// create array of alowed extensions
						string[] FileExtensions = new string[]{".pps", ".ppsx" , ".ppt", ".pptx"};

						if (FileExtensions.Contains(file.Extension) && !file.Name.Contains("~"))
						{
							archive.CreateEntryFromFile(file.FullName, Path.GetFileName(file.FullName));
							bar.Value += 1;
						}
					}
				}

				return true;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

	}
}
