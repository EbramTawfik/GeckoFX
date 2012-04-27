using System;
using System.IO;
using System.Collections;
using System.Linq;
using System.Reflection;


namespace Gecko
{
	/// <summary>
	/// Search /usr/lib directory for the latest xulrunner.
	/// Currently looks for xulrunner-1.9.2 variants in /usr/lib.
	/// Returns null if no xulrunner-1.9.2 directory is found.
	/// xulrunner doesn't come with a .pc file so I can't use pkg-config to find location of xulrunner.
	/// </summary>
	public static class XULRunnerLocator
	{
		private static string GetXULRunnerLocationLinux()
		{
			if (!Directory.Exists("/usr/lib"))
				throw new ApplicationException("/usr/lib doesn't exist");

			DirectoryInfo d = new DirectoryInfo("/usr/lib");

			//review: This looks rather out of date: what should it be on Linux?

			DirectoryInfo[] dirs = d.GetDirectories("xulrunner-2.0", SearchOption.TopDirectoryOnly);

			if (dirs.Length == 0)
				return null;

			return dirs.OrderBy(x => x.Name).Last().FullName;
		}

		private static string GetXULRunnerLocationWindows()
		{
			//NB for shipping apps, we don't have a way to find their xulrunner, so they won't be running this code 
			//unless they depend on the customer installing a certain verion of Firefox and keeping it from auto-updating.
			//So this is more for unit tests and geckofx sample apps.
			
			//For unit tests, look for a xulrunner directory placed in the solution/PutXulRunnerFolderHere directory
			var solutionXulRunnerFolder = Path.Combine(DirectoryOfTheApplicationExecutable,
			                                           "../../../PutXulRunnerFolderHere/XulRunner/");			
			if (Directory.Exists(solutionXulRunnerFolder))
				return solutionXulRunnerFolder;

			 //for test app, we have to go up one more level
			solutionXulRunnerFolder = Path.Combine(DirectoryOfTheApplicationExecutable,
										   "../../../../PutXulRunnerFolderHere/XulRunner/");
			if (Directory.Exists(solutionXulRunnerFolder))
				return solutionXulRunnerFolder;

			//look for firefox itself

			string[] folderSearch = new string[] { solutionXulRunnerFolder, "Mozilla Firefox 12.0", "Mozilla Firefox 12", "Mozilla Firefox" };

			var programFiles = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
			return folderSearch.Select(t => Path.Combine(programFiles, t)).FirstOrDefault(Directory.Exists);
		}

		private static string DirectoryOfTheApplicationExecutable
		{
			get
			{
				string path;
				bool unitTesting = Assembly.GetEntryAssembly() == null;
				if (unitTesting)
				{
					path = new Uri(Assembly.GetExecutingAssembly().CodeBase).AbsolutePath;
					path = Uri.UnescapeDataString(path);
				}
				else
				{
					path = System.Windows.Forms.Application.ExecutablePath;
				}
				return Directory.GetParent(path).FullName;
			}
		}

		public static string GetXULRunnerLocation()
		{
			return Xpcom.IsLinux
				? GetXULRunnerLocationLinux()
				: GetXULRunnerLocationWindows();
		}
	}
}
