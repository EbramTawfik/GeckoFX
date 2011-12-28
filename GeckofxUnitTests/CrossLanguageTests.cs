using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Windows.Forms;
using Gecko;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.IO;

namespace GeckofxUnitTests
{
	[TestFixture]
	internal class CrossLanguageTests
	{
		private GeckoWebBrowser browser;

		[SetUp]
		public void BeforeEachTestSetup()
		{
			Xpcom.Initialize(XpComTests.XulRunnerLocation);
			browser = new GeckoWebBrowser();
			var unused = browser.Handle;
			Assert.IsNotNull(browser);
		}

		[TearDown]
		public void AfterEachTestTearDown()
		{
			browser.Dispose();
		}
		
		#region JavaScriptToCSharpCallBack
		public class MyCSharpComClassFactory : nsIFactory
		{
			public IntPtr CreateInstance(nsISupports aOuter, ref Guid iid)
			{
				var obj = new MyCSharpComClass();
				return Marshal.GetIUnknownForObject(obj);
			}

			public void LockFactory(bool @lock)
			{

			}
		}

		// if you want you use a custom com interface one has to register it with firefox
		// see interfaces in https://developer.mozilla.org/en/Chrome_Registration#manifest
		// to produce a xpt file one has to convert a idl file to xpt.
		public class MyCSharpComClass : nsICommandHandler
		{
			public static int _execCount = 0;
			public static string _aCommand;
			public static string _aParameters;

			public string Exec(string aCommand, string aParameters)
			{
				_execCount++;
				_aCommand = aCommand;
				_aParameters = aParameters;

				// TODO: wouk out how to return C# string.
				return null;
			}

			public string Query(string aCommand, string aParameters)
			{
				return null;
			}
		}

		[Test]
		public void JavaScriptToCSharpCallBack()
		{
			// Register a C# COM Object

			// TODO would be nice to get nsIComponentRegistrar the xpcom way with CreateInstance
			// ie Xpcom.CreateInstance<nsIComponentRegistrar>(...
			Guid aClass = new Guid("a7139c0e-962c-44b6-bec3-aaaaaaaaaaab");
			Xpcom.ComponentRegistrar.RegisterFactory(ref aClass, "Example C sharp com component", "@geckofx/myclass;1", new MyCSharpComClassFactory());

			// In order to use Components.classes etc we need to enable certan privileges. 
			GeckoPreferences.User["capability.principal.codebase.p0.granted"] = "UniversalXPConnect";
			GeckoPreferences.User["capability.principal.codebase.p0.id"] = "file://";
			GeckoPreferences.User["capability.principal.codebase.p0.subjectName"] = "";
			GeckoPreferences.User["security.fileuri.strict_origin_policy"] = false;

			string initialjavascript =
				"<script type=\"text/javascript\">" +
				"netscape.security.PrivilegeManager.enablePrivilege('UniversalXPConnect');" +
				"var myClassInstance = Components.classes['@geckofx/myclass;1'].createInstance(Components.interfaces.nsICommandHandler);" +
				"myClassInstance.exec('hello', 'world');" +
				"</script>";

			// Create temp file to load 
			var tempfilename = Path.GetTempFileName();
			tempfilename += ".html";
			using (TextWriter tw = new StreamWriter(tempfilename))
			{
				tw.WriteLine(initialjavascript);
				tw.Close();
			}

			browser.Navigate(tempfilename);
			browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
			File.Delete(tempfilename);

			// Test the results
			Assert.AreEqual(MyCSharpComClass._execCount, 1);
			Assert.AreEqual(MyCSharpComClass._aCommand, "hello");
			Assert.AreEqual(MyCSharpComClass._aParameters, "world");
		}
		#endregion
	}
}