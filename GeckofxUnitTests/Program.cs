using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using Gecko;

namespace GeckofxUnitTests
{
	class Program
	{
		[STAThread]
		static void Main(string[] args)
		{
			string prefix = Xpcom.IsLinux ? "--" : "/";
			string nothread = prefix + "nothread";
			string domain = prefix + "domain=None";
			
			string[] my_args = { Assembly.GetExecutingAssembly().Location, nothread, domain };

			int returnCode = NUnit.ConsoleRunner.Runner.Main(my_args);

			if (returnCode != 0)
				Console.Beep();
		}
	}
}
