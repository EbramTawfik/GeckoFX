using System;
using System.IO;
using System.Collections;
using System.Linq;
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
			DirectoryInfo[] dirs = d.GetDirectories("xulrunner-2.0", SearchOption.TopDirectoryOnly);

			if (dirs.Length == 0)
				return null;

			return dirs.OrderBy(x => x.Name).Last().FullName;
		}

		private static string GetXULRunnerLocationWindows()
		{
			var programFiles = Environment.GetFolderPath( Environment.SpecialFolder.ProgramFiles );

			string[] folderSearch = new string[] { "Mozilla Firefox", "Mozilla Firefox 10" };

			return folderSearch.Select( t => Path.Combine( programFiles, t ) ).FirstOrDefault( Directory.Exists );
		}

		public static string GetXULRunnerLocation()
		{
			return Xpcom.IsLinux
				? GetXULRunnerLocationLinux()
				: GetXULRunnerLocationWindows();
		}
	}
}
