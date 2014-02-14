using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using Gecko;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GeckofxUnitTests
{
	class Program
	{
		[STAThread]
		static void Main(string[] args)
		{
			// Needed when single unittests are run
			// Xpcom.Initialize(XpComTests.XulRunnerLocation);
			OverrideX11ErrorHandler();
						
			string prefix = Xpcom.IsLinux ? "--" : "/";
			string nothread = prefix + "nothread";
			string domain = prefix + "domain=None";

			string[] my_args = { Assembly.GetExecutingAssembly().Location, nothread, domain, /*"/fixture=GeckofxUnitTests.CrossLanguageTests"*/ };

			int returnCode = NUnit.ConsoleRunner.Runner.Main(my_args); 

			if (returnCode != 0)
				Console.Beep();
				
			Xpcom.Shutdown();
		}
		
		#region Linux only - override the ErrorHandler to ignore X11 warnings/errors
		
		static void OverrideX11ErrorHandler()
		{
			if (!Xpcom.IsLinux)
			return;
		
			// Initalize the Display then override the X11 error handler.
			Form f = new Form();
			f.Show();
			Application.DoEvents();
			
			ErrorHandler = new XErrorHandler(HandleError);
			XSetErrorHandler(ErrorHandler);
		}
		
		static XErrorHandler ErrorHandler;
		
		[DllImport ("libX11", EntryPoint="XSetErrorHandler")]
		internal extern static IntPtr XSetErrorHandler(XErrorHandler error_handler);
		
		internal delegate int  XErrorHandler(IntPtr DisplayHandle, ref XErrorEvent error_event);
		
		[StructLayout(LayoutKind.Sequential)]
		internal struct XErrorEvent {
			internal int type;
			internal IntPtr display;
			internal IntPtr	resourceid;
			internal IntPtr	serial;
			internal byte error_code;
			internal int request_code;
			internal byte minor_code;
		}

		static int HandleError (IntPtr display, ref XErrorEvent error_event)
		{
			return 0;
		}
		#endregion
	}
}
