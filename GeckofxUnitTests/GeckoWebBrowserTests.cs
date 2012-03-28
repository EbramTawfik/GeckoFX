using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Windows.Forms;
using Gecko;
using System.IO;
using System.Runtime.InteropServices;
using Gecko.DOM;

namespace GeckofxUnitTests
{
	[TestFixture]
	internal class GeckoWebBrowserTests
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


		public static string errorMessage = null;

		private class TestGeckoWebBrowser : GeckoWebBrowser
		{			
			protected override void Dispose(bool disposing)
			{
				if (disposing == false)
				{
					var currentThread = System.Threading.Thread.CurrentThread;					
					errorMessage = String.Format("Disposed called by GC {0} {1}", currentThread.ManagedThreadId, currentThread.ApartmentState);
					Console.WriteLine(errorMessage);
				}

				base.Dispose(disposing);
			}
		}

		[Test]		
		public void MissingDisposeTest_ControlIsNotYetCreated_DoesNotThrowExceptions()
		{
			var nonDisposedBrowser = new TestGeckoWebBrowser();

			nonDisposedBrowser = null;
			GC.Collect();
			GC.WaitForPendingFinalizers();
			
			Assert.IsTrue(errorMessage.Contains("Disposed called by"));
		}

		[Test]
		public void LoadHtml_SomeSimpleHtml_HtmlIsLoadedAndAccessableAfterNavigationFinished()
		{
			string innerHtml = "<div id=\"_lv5\">old value</div>";

			browser.LoadHtml("<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">"

			                 + "<html xmlns=\"http://www.w3.org/1999/xhtml\" >"

			                 + "<body>" + innerHtml + "</body></html>");

			browser.NavigateFinishedNotifier.NavigateFinished += (sender, e) =>
			                                                     	{
			                                                     		Assert.AreEqual(browser.Document.Body.InnerHtml, innerHtml);
			                                                     	};

			browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();

			Assert.AreEqual(browser.Document.Body.InnerHtml, innerHtml);
		}

		[Test]
		public void DomContentChanged_ChangeContentOfTextInputWithKeyPressAndMoveToSecondInput_DomContentChangedShouldFire()
		{
			string html = "<input id=\"one\" type=\"text\" value=\"hello\" /><input id=\"two\" type=\"text\"  value=\"world\" />";
			browser.TestLoadHtml(html);

			// Place browser on a form and show it. This is need to make the gecko accept the key press.
			Form f = new Form();
			f.Controls.Add(browser);
			browser.Visible = true;
			f.Show();

			// Focus first input box
			browser.Document.GetElementById("one").Focus();
			GeckoRange range = browser.Document.CreateRange();
			range.SelectNode(browser.Document.GetElementById("one"));
			browser.Window.Selection.AddRange(range);

			// record if DomContentChanged event happened.
			bool contentChangedEventReceived = false;
			browser.DomContentChanged += (sender, e) => contentChangedEventReceived = true;


			// Modify first input by sending a keypress.
			// TODO: create wrapper for nsIDOMWindowUtils
			nsIDOMWindowUtils utils = Xpcom.QueryInterface<nsIDOMWindowUtils>(browser.Window.DomWindow);
			using (nsAString type = new nsAString("keypress"))
			{
				utils.SendKeyEvent(type, 0, 102, 0, false);
			}

			// DomContentChanged Event should fire when we move we move to next element.
			browser.Document.GetElementById("two").Focus();
			range.SelectNode(browser.Document.GetElementById("two"));
			browser.Window.Selection.RemoveAllRanges();
			browser.Window.Selection.AddRange(range);

			Assert.IsTrue(contentChangedEventReceived);
		}
		
		[Test]
		public void LoadFrameset_RegressionTest_ShouldNotThrowException()
		{
			string innerHtml = "hello world";
			browser.TestLoadFrameset(innerHtml);						
		}

		[Test]
		public void Editor_LoadedReadonlyocument_ReturnsNull()
		{
			browser.TestLoadHtml("hello world.");
			Assert.Null(browser.Editor);
		}

		[Test]
		public void Editor_LoadedEditableDocument_ReturnsNonNull()
		{
			browser.TestLoadEditableHtml("hello world.");
			Assert.NotNull(browser.Editor);
		}
		 
		[Test]
		public void JavascriptError_NaviagateWithSomeJavascriptThatThrowsException_AttachedEventHandlerShouldExecute()
		{
			List<JavascriptErrorEventArgs> errorEventArgs = new List<JavascriptErrorEventArgs>();

			browser.JavascriptError += (object sender, JavascriptErrorEventArgs e) => errorEventArgs.Add(e);

			browser.Navigate("javascript:someRandomFunctionNameThatDoesNotExist(\"2\");");

			Application.DoEvents();

			Assert.AreEqual(2, errorEventArgs.Count);
			Assert.AreEqual("someRandomFunctionNameThatDoesNotExist is not defined", errorEventArgs[0].Message);
			Assert.AreEqual("ReferenceError: someRandomFunctionNameThatDoesNotExist is not defined", errorEventArgs[1].Message);

			Assert.AreEqual(1, errorEventArgs[0].ErrorNumber);
			Assert.AreEqual(1, errorEventArgs[1].ErrorNumber);

			Assert.AreEqual(1, errorEventArgs[0].Line);
			Assert.AreEqual(1, errorEventArgs[1].Line);

			Assert.AreEqual("javascript:someRandomFunctionNameThatDoesNotExist(\"2\");", errorEventArgs[0].Filename);
			Assert.AreEqual("javascript:someRandomFunctionNameThatDoesNotExist(\"2\");", errorEventArgs[1].Filename);

			Assert.AreEqual(ErrorFlags.REPORT_EXCEPTION, errorEventArgs[0].Flags);
			Assert.AreEqual(ErrorFlags.REPORT_EXCEPTION, errorEventArgs[1].Flags);

			Assert.AreEqual(0, errorEventArgs[0].Pos);
			Assert.AreEqual(0, errorEventArgs[1].Pos);
		}

		[Test]
		public void ConsoleMessage_NavigateWithSomeInvalidCss_AttachedEventHandlerShouldExecute()
		{
			ConsoleMessageEventArgs eventArgs = null;

			EventHandler<ConsoleMessageEventArgs> eventHandler = (object sender, ConsoleMessageEventArgs e) => eventArgs = e;
			browser.ConsoleMessage += eventHandler;

			string html = "<p style=\"background: bluse; color: white;\">hello</p>";
			browser.TestLoadHtml(html);			
			
			browser.ConsoleMessage -= eventHandler;

			Assert.NotNull(eventArgs);
			Assert.IsNotNullOrEmpty(eventArgs.Message);
			Assert.IsTrue(eventArgs.Message.Contains("JavaScript Warning: \"Expected color but found 'bluse'"), eventArgs.Message);
		}

		[Test]
		public void AddEventListener_JScriptFiresEvent_ListenerIsCalledWithMessage()
		{
			string payload = null;

			browser.AddMessageEventListener("callMe", ((string p) => payload = p));

			browser.LoadHtml(
				@"<!DOCTYPE html>
			                 <html><head>
			                 <script type='text/javascript'>
								window.onload= function() {
									event = document.createEvent('MessageEvent');
									var origin = window.location.protocol + '//' + window.location.host;
									event.initMessageEvent ('callMe', true, true, 'some data', origin, 1234, window, null);
									document.dispatchEvent (event);
								}
							</script>
							</head><body></body></html>");

			browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
			Assert.AreEqual("some data", payload);
		}

		[Test]
		public void EvaluateScript_SimpleJavascript_ScriptExecutesAndReturnsExpectedResult()
		{
			browser.TestLoadHtml("");
			
			using (AutoJSContext context = new AutoJSContext())
			{				
				string result;
				Assert.IsTrue(context.EvaluateScript("3 + 2;", out result));
				Assert.AreEqual(5, Int32.Parse(result));

				Assert.IsTrue(context.EvaluateScript("'hello' + ' ' + 'world';", out result));
				Assert.AreEqual("hello world", result);
			}				
		}

		[Test]
		public void EvaluateScript_SimpleJavascriptWithoutNormalDocumentSetup_ScriptExecutesAndReturnsExpectedResult()
		{		
			using (AutoJSContext context = new AutoJSContext(browser.JSContext))
			{
				string result;
				Assert.IsTrue(context.EvaluateScript("3 + 2;", out result));
				Assert.AreEqual(5, Int32.Parse(result));

				Assert.IsTrue(context.EvaluateScript("'hello' + ' ' + 'world';", out result));
				Assert.AreEqual("hello world", result);
			}
		}

		[Test]
		public void EvaluateScript_JavascriptAccessExistingGlobalObjects_ScriptExecutesAndReturnsExpectedResult()
		{
			browser.TestLoadHtml("hello world");
			
			using (AutoJSContext context = new AutoJSContext(browser.JSContext))
			{
				string result;
				Assert.IsTrue(context.EvaluateScript("this", out result));
				Assert.AreEqual("[object Window]", result);

				Assert.IsTrue(context.EvaluateScript("this.document.body.innerHTML;", out result));
				Assert.AreEqual("hello world", result);

				Assert.IsTrue(context.EvaluateScript("this.document.body.innerHTML = 'hi';", out result));
				Assert.IsTrue(context.EvaluateScript("this.document.body.innerHTML;", out result));
				Assert.AreEqual("hi", result);

				Assert.IsTrue(context.EvaluateScript("eval(\"x=10;y=20;x*y;\");", out result));
				Assert.AreEqual("200", result);
			}
		}

		[Test]
		public void EvaluateScript_JavascriptAccessExistingGlobalObjectsWithoutNormalDocumentSetup_ScriptExecutesAndReturnsExpectedResult()
		{			
			using (AutoJSContext context = new AutoJSContext(browser.JSContext))
			{
				string result;
				Assert.IsTrue(context.EvaluateScript("this", out result));
				Assert.AreEqual("[object Window]", result);

				Assert.IsTrue(context.EvaluateScript("this.document.body.innerHTML;", out result));
				Assert.AreEqual(String.Empty, result);

				Assert.IsTrue(context.EvaluateScript("this.document.body.innerHTML = 'hi';", out result));
				Assert.IsTrue(context.EvaluateScript("this.document.body.innerHTML;", out result));
				Assert.AreEqual("hi", result);

				Assert.IsTrue(context.EvaluateScript("eval(\"x=10;y=20;x*y;\");", out result));
				Assert.AreEqual("200", result);
			}
		}		
	}
}
