using System;
using System.IO;
using System.Collections;
using System.Linq;
namespace Skybound.Gecko
{
	/// <summary>
	/// Search /usr/lib directory for latest xulrunner.
	/// Currenly looks for xulrunner-1.9.2 variants in /usr/lib.
	/// returns null if xulrunner-1. directory isn't found.
	/// xulrunner doesn't come with a .pc file so I can't use pkg-config to find location of xulrunner.
	/// </summary>
	public static class XULRunnerLocator
	{
		public static string GetXULRunnerLocation()
		{
			if (!Xpcom.IsLinux)
				throw new ApplicationException("XULRunnerLocator only works on Linux.");
			
			if (!Directory.Exists("/usr/lib"))
				throw new ApplicationException("/usr/lib doesn't exist");
			
			DirectoryInfo d = new DirectoryInfo("/usr/lib");
			DirectoryInfo[] dirs = d.GetDirectories("xulrunner-1.9.2.*", SearchOption.TopDirectoryOnly);
			
			if (dirs.Length == 0)
				return null;
			
			if (dirs.Length == 1)
				return dirs[0].FullName;
						
			return dirs.OrderBy(x => x).First().FullName;						
		}
	}
}

