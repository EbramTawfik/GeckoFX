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

			// In order to use Components.classes etc we need to enable certan privileges. 
			GeckoPreferences.User["capability.principal.codebase.p0.granted"] = "UniversalXPConnect";
			GeckoPreferences.User["capability.principal.codebase.p0.id"] = "file://";
			GeckoPreferences.User["capability.principal.codebase.p0.subjectName"] = "";
			GeckoPreferences.User["security.fileuri.strict_origin_policy"] = false;

		
			//var unusedPtr = GlobalJSContextHolder.JSContext;
			//Console.WriteLine("Global JSContext is {0}", unusedPtr);
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

				// TODO: work out how to return C# string.
				return null;
			}

			public string Query(string aCommand, string aParameters)
			{
				return null;
			}
		}

		[Test]
		[Ignore("Disable test when upgrading to firefox 29")]
		public void JavaScriptToCSharpCallBack()
		{						
			// Note: Firefox 17 removed enablePrivilege #546848 - refactored test so that javascript to create "@mozillazine.org/example/priority;1" is now executated by AutoJsContext 

			// Register a C# COM Object

			const string ComponentManagerCID = "91775d60-d5dc-11d2-92fb-00e09805570f";
			nsIComponentRegistrar mgr = (nsIComponentRegistrar)Xpcom.GetObjectForIUnknown((IntPtr)Xpcom.GetService(new Guid(ComponentManagerCID)));
			Guid aClass = new Guid("a7139c0e-962c-44b6-bec3-aaaaaaaaaaab");
			mgr.RegisterFactory(ref aClass, "Example C sharp com component", "@geckofx/mysharpclass;1", new MyCSharpComClassFactory());

			// In order to use Components.classes etc we need to enable certan privileges. 
			GeckoPreferences.User["capability.principal.codebase.p0.granted"] = "UniversalXPConnect";
			GeckoPreferences.User["capability.principal.codebase.p0.id"] = "file://";
			GeckoPreferences.User["capability.principal.codebase.p0.subjectName"] = "";
			GeckoPreferences.User["security.fileuri.strict_origin_policy"] = false;

#if PORT
			browser.JavascriptError += (x, w) => Console.WriteLine(w.Message);
#endif

			string inithtml = "<html><body></body></html>";

			string initialjavascript =
				"var myClassInstance = Components.classes['@geckofx/mysharpclass;1'].createInstance(Components.interfaces.nsICommandHandler); myClassInstance.exec('hello', 'world');";

			// Create temp file to load 
			var tempfilename = Path.GetTempFileName();
			tempfilename += ".html";
			using (TextWriter tw = new StreamWriter(tempfilename))
			{
				tw.WriteLine(inithtml);
				tw.Close();
			}

			browser.Navigate(tempfilename);
			browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
			File.Delete(tempfilename);

			using (var context = new AutoJSContext(GlobalJSContextHolder.BackstageJSContext))
			{
				string result = String.Empty;
				bool success = context.EvaluateScript(initialjavascript, out result);				
				Console.WriteLine("success = {1} result = {0}", result, success);
			}

			// Test the results
			Assert.AreEqual(MyCSharpComClass._execCount, 1);
			Assert.AreEqual(MyCSharpComClass._aCommand, "hello");
			Assert.AreEqual(MyCSharpComClass._aParameters, "world");
		}
		#endregion

		#region CSharpInvokingJavascriptComObjects

		public class MyCSharpClassThatContainsXpComJavascriptObjectsFactory : nsIFactory
		{
			public IntPtr CreateInstance(nsISupports aOuter, ref Guid iid)
			{
				var obj = new MyCSharpClassThatContainsXpComJavascriptObjects();
				return Marshal.GetIUnknownForObject(obj);
			}

			public void LockFactory(bool @lock)
			{

			}
		}

		/// <summary>
		/// TODO: currenly I am abusing the nsIWebPageDescriptor interface just to make the CurrentDescriptor attribute return the nsIComponentRegistrar
		/// This allows my to dynamically register javascript xpcom factories.
		/// </summary>
		public class MyCSharpClassThatContainsXpComJavascriptObjects : nsIWebPageDescriptor
		{

			public void LoadPage(nsISupports aPageDescriptor, uint aDisplayType)
			{
				throw new NotImplementedException();
			}

			public nsISupports GetCurrentDescriptorAttribute()
			{
				const string ComponentManagerCID = "91775d60-d5dc-11d2-92fb-00e09805570f";
				nsIComponentRegistrar mgr = (nsIComponentRegistrar)Xpcom.GetObjectForIUnknown((IntPtr)Xpcom.GetService(new Guid(ComponentManagerCID)));
				return (nsISupports)mgr;
			}
		}

		[Test]		
		[Ignore("Disable test when upgrading to firefox 29")]
		public void CSharpInvokingJavascriptComObjects()
		{
			// Note: Firefox 17 removed enablePrivilege #546848 - refactored test so that javascript to create "@mozillazine.org/example/priority;1" is now executated by AutoJsContext 

			// Register a C# COM Object

			// TODO would be nice to get nsIComponentRegistrar the xpcom way with CreateInstance
			// ie Xpcom.CreateInstance<nsIComponentRegistrar>(...
			Guid aClass = new Guid("a7139c0e-962c-44b6-bec3-aaaaaaaaaaac");
			var factory = new MyCSharpClassThatContainsXpComJavascriptObjectsFactory();
			Xpcom.ComponentRegistrar.RegisterFactory(ref aClass, "Example C sharp com component", "@geckofx/myclass;1", factory);

			// In order to use Components.classes etc we need to enable certan privileges. 
			GeckoPreferences.User["capability.principal.codebase.p0.granted"] = "UniversalXPConnect";
			GeckoPreferences.User["capability.principal.codebase.p0.id"] = "file://";
			GeckoPreferences.User["capability.principal.codebase.p0.subjectName"] = "";
			GeckoPreferences.User["security.fileuri.strict_origin_policy"] = false;

#if PORT
			browser.JavascriptError += (x, w) => Console.WriteLine("Message = {0}", w.Message);
#endif

			string intialPage = "<html><body></body></html>";				

			string initialjavascript =				
				"var myClassInstance = Components.classes['@geckofx/myclass;1'].createInstance(Components.interfaces.nsIWebPageDescriptor);" +
				"var reg = myClassInstance.currentDescriptor.QueryInterface(Components.interfaces.nsIComponentRegistrar);" +
				"Components.utils.import(\"resource://gre/modules/XPCOMUtils.jsm\"); " +
				"const nsISupportsPriority = Components.interfaces.nsISupportsPriority;" +
				"const nsISupports = Components.interfaces.nsISupports;" +
				"const CLASS_ID = Components.ID(\"{1C0E8D86-B661-40d0-AE3D-CA012FADF170}\");" +
				"const CLASS_NAME = \"My Supports Priority Component\";" +
				"const CONTRACT_ID = \"@mozillazine.org/example/priority;1\";" +
				"function MyPriority() {" +
				"	this._priority = nsISupportsPriority.PRIORITY_LOWEST;" +
				"};" +
				"MyPriority.prototype = {" +
				"  _priority: null," +

				"  get priority() { return this._priority; }," +
				"  set priority(aValue) { this._priority = aValue; }," +

				"  adjustPriority: function(aDelta) {" +
				"	this._priority += aDelta;" +
				"  }," +

				"  QueryInterface: function(aIID)" +
				"  { " +
				"	/*if (!aIID.equals(nsISupportsPriority) &&    " +
				"		!aIID.equals(nsISupports))" +
				"	  throw Components.results.NS_ERROR_NO_INTERFACE;*/" +
				"	return this;" +
				"  }" +
				"};" +
				"" +
				"var MyPriorityFactory = {" +
				"  createInstance: function (aOuter, aIID)" +
				"  { " +
				"	if (aOuter != null)" +
				"	  throw Components.results.NS_ERROR_NO_AGGREGATION; " +
				"	return (new MyPriority()).QueryInterface(aIID);" +
				"  }" +
				"};" +
				"" +
				"var MyPriorityModule = {" +
				"  _firstTime: true," +
				"  registerSelf: function(aCompMgr, aFileSpec, aLocation, aType)" +
				"  {" +
				"	aCompMgr = aCompMgr.QueryInterface(Components.interfaces.nsIComponentRegistrar);" +
				"	aCompMgr.registerFactory(CLASS_ID, CLASS_NAME, CONTRACT_ID, MyPriorityFactory);" +
				"  }," +
				"" +
				"  unregisterSelf: function(aCompMgr, aLocation, aType)" +
				"  {" +
				"	aCompMgr = aCompMgr.QueryInterface(Components.interfaces.nsIComponentRegistrar);" +
				"	aCompMgr.unregisterFactoryLocation(CLASS_ID, aLocation);        " +
				"  }," +
				"" +
				"  getClassObject: function(aCompMgr, aCID, aIID)" +
				"  {alert('hi');" +
				"	if (!aIID.equals(Components.interfaces.nsIFactory))" +
				"	  throw Components.results.NS_ERROR_NOT_IMPLEMENTED;" +
				"" +
				"	if (aCID.equals(CLASS_ID))" +
				"	  return MyPriorityFactory;" +
				"" +
				"	throw Components.results.NS_ERROR_NO_INTERFACE;" +
				"  }," +
				"" +
				"  canUnload: function(aCompMgr) { return true; }" +
				"};" +
				"MyPriorityModule.registerSelf(reg);" +
				"";				

			// Create temp file to load 
			var tempfilename = Path.GetTempFileName();
			tempfilename += ".html";
			using (TextWriter tw = new StreamWriter(tempfilename))
			{
				tw.WriteLine(intialPage);
				tw.Close();
			}

			browser.Navigate(tempfilename);
			browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();

			using (var context = new AutoJSContext(GlobalJSContextHolder.BackstageJSContext))
			{
				string result = String.Empty;				
				var success = context.EvaluateScript(initialjavascript, out result);				
				Console.WriteLine("success = {0} result = {1}", success, result);				
			}		

			File.Delete(tempfilename);

			// Create instance of javascript xpcom objects
			var p = Xpcom.CreateInstance<nsISupportsPriority>("@mozillazine.org/example/priority;1");
			Assert.NotNull(p);

			// test invoking method of javascript xpcom object.
			Assert.AreEqual(20, p.GetPriorityAttribute());

			Xpcom.ComponentRegistrar.UnregisterFactory(ref aClass, factory);			
		}
				
		#endregion
	}
}
