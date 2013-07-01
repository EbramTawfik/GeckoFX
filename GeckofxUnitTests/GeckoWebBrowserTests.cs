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
			browser.Document.GetHtmlElementById("one").Focus();
			GeckoRange range = browser.Document.CreateRange();
			range.SelectNode(browser.Document.GetHtmlElementById("one"));
			browser.Window.Selection.AddRange(range);

			// record if DomContentChanged event happened.
			bool contentChangedEventReceived = false;
			browser.DomContentChanged += (sender, e) => contentChangedEventReceived = true;


			// Modify first input by sending a keypress.			
			nsIDOMWindowUtils utils = Xpcom.QueryInterface<nsIDOMWindowUtils>(browser.Window.DomWindow);
			browser.Window.WindowUtils.SendKeyEvent("keypress", 0, 102, 0, false);			

			// DomContentChanged Event should fire when we move we move to next element.
			browser.Document.GetHtmlElementById("two").Focus();
			range.SelectNode(browser.Document.GetHtmlElementById("two"));
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
		 
		[Platform("Win")]
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

				Assert.IsTrue(context.EvaluateScript("x=10;y=20;x*y;", out result));
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

				Assert.IsTrue(context.EvaluateScript("x=10;y=20;x*y;", out result));
				Assert.AreEqual("200", result);
			}
		}
		
		[Test]
		public void EvaluateScript_JavascriptIncreasePriviligesCrossFrameAccess_ScriptExecutesAndReturnsExpectedResult()
		{
			string result;
			string aboutBlank;
			using (var page = new GeckoWebBrowser())
			{
				IntPtr unused = page.Handle;			
				page.CreateWindow += (s, e) => { e.WebBrowser = browser; };				
				using (AutoJSContext context = new AutoJSContext(page.JSContext))
				{
					Assert.IsTrue(context.EvaluateScript("window.open('http://www.google.com'); window.location.href", out aboutBlank));
				}				
				browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();

				using (AutoJSContext context = new AutoJSContext(browser.JSContext))
				{
					Assert.IsTrue(context.EvaluateScript("window.location.href", out result));
					Assert.AreNotEqual(aboutBlank, result);
					
					// cross frame access
					Assert.IsFalse(context.EvaluateScript("opener.location.href", out result));
					Assert.IsTrue(context.EvaluateTrustedScript("opener.location.href", out result));
					Assert.AreEqual(aboutBlank, result);
				}

				page.Stop();
			}
		}

		[Test]
		public void EvaluateScript_PassBodyasThis_ThisEqualsBodyObject()
		{
			browser.TestLoadHtml("hello world");

			using (AutoJSContext context = new AutoJSContext(browser.JSContext))
			{
				string result;
				context.EvaluateScript("this;", (nsISupports)browser.Document.Body.DomObject, out result);

				Assert.AreEqual("[object HTMLBodyElement]", result);
			}
		}

		[Test]
		public void EvaluateScript_PassBodysFirstChildAndPassToAInlineFunction_FunctionReturnsExpectedResults()
		{
			browser.TestLoadHtml("hello <span>world</span>");

			using (AutoJSContext context = new AutoJSContext(browser.JSContext))
			{
				string result;
				context.EvaluateScript("function dosomthing(node) { return node.textContent; } dosomthing(this);", (nsISupports)browser.Document.Body.FirstChild.DomObject, out result);

				Assert.AreEqual("hello ", result);
			}
		}
		
		[Test]
		public void EvaluateScript_Run500Times_DoesNotCrash()
		{
			browser.TestLoadHtml("");

			using (AutoJSContext context = new AutoJSContext(browser.JSContext))
			{
				for (int i = 0; i < 500; i++)
				{
					string result;
					context.EvaluateScript("2+3;", out result);
					Assert.AreEqual("5", result);
				}
			}
		}
		
		[Test]
		public void EvaluateScript_Run500TimesCreatingNewAutoJSContextEachTime_DoesNotCrash()
		{
			browser.TestLoadHtml("");

			for (int i = 0; i < 500; i++)
			{
				using (AutoJSContext context = new AutoJSContext(browser.JSContext))
				{
					string result;
					context.EvaluateScript("2+3;", out result);
					Assert.AreEqual("5", result);
				}
			}
		}

		[Test]
		public void EvaluateScript_Run500Times_CreatingNewSafeAutoJSContextEachTime_DoesNotCrash()
		{
			for (int i = 0; i < 500; i++)
			{
				using (var safeContext = new AutoJSContext(IntPtr.Zero))
				{
					string result;
					safeContext.EvaluateScript("2+3;", out result);
					Assert.AreEqual("5", result);
				}
			}
		}
		
		[Test]
		public void EvaluateScript_Run500TimesNavigatingToANewDocumentEachTime_DoesNotCrash()
		{			
			for (int i = 0; i < 500; i++)
			{
				browser.TestLoadHtml(String.Format("{0}", i));

				using (AutoJSContext context = new AutoJSContext(browser.JSContext))
				{
					string result;
					context.EvaluateScript("2+3;", out result);
					Assert.AreEqual("5", result);
				}
			}
		}

		[Test]
		public void GetMarkupDocumentViewer_InitalizedDocument_ValidGeckoMarkupDocumentViewerReturned()
		{
			browser.TestLoadHtml("hello world.");

			Assert.NotNull(browser.GetMarkupDocumentViewer());
		}

        [Test]
        public void Navigating_IntialDocumentLoad_NavigatigEventIsCalled()
        {
            int counter = 0;
            browser.Navigating += (sender, args) => counter++;

            browser.TestLoadHtml("hello world");

            Assert.AreEqual(1, counter);
        }

        [Test]
        public void Navigating_TwoDocumentsLoaded_NavigatigEventIsCalledTwice()
        {
            int counter = 0;
            browser.Navigating += (sender, args) => counter++;

            browser.TestLoadHtml("hello world");
            browser.TestLoadHtml("hello world");

            Assert.AreEqual(2, counter);
        }

        [Test]
        public void Navigating_UseJavaScriptToChangeDocument_NavigatigEventIsCalledWhenJavascriptChangesDocument()
        {
            int counter = 0;
            browser.Navigating += (sender, args) => counter++;

            browser.TestLoadHtml("hello world");
            browser.Navigate("javascript:location.href='http://www.google.com';");
            browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();

            Assert.AreEqual(2, counter);
        }

		[Platform("Win")]
        [Test]
        public void Navigating_UseJavaScriptToChangeDocumentToAUrlTheDoesNotExist_NavigatigEventIsCalled()
        {
            int counter = 0;
            int shouldNotChangeCounter = 0;

            browser.TestLoadHtml("hello world");
			browser.Navigating += (sender, args) => { counter++; args.Cancel = true; };
            browser.Navigated += (sender, args) => shouldNotChangeCounter++;

            browser.Navigate("javascript:location.href='http://www.domaindoesnNotExitqwertyuuiasdf.com?helloworld';");
            browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();

            Assert.AreEqual(1, counter);
            Assert.AreEqual(0, shouldNotChangeCounter);
        }
		
		[Platform("Win")]
        [Test]
        public void Navigating_NavigatingIsCanceled_NavigateDoesNotComplete()
        {
            browser.TestLoadHtml("hello world");
            bool navigatingCalled = false;
            bool navigatedCalled = false;

            browser.Navigated += (sender, args) => navigatedCalled = true;
            browser.Navigating += (sender, args) =>
                                      {
                                          args.Cancel = true;
                                          navigatingCalled = true;
                                      };
            browser.Navigate("www.google.com");

            while (!navigatingCalled)
                Application.DoEvents();

            Assert.False(navigatedCalled);
            Assert.AreEqual("hello world", browser.Document.Body.InnerHtml);

            navigatingCalled = false;
            browser.Navigate("javascript:location.href='http://www.google.co.uk';");

            while (!navigatingCalled)
                Application.DoEvents();

            Assert.False(navigatedCalled);
            Assert.AreEqual("hello world", browser.Document.Body.InnerHtml);
        }

		// TODO: move unittest into GeckoMarkupDocumentViewerTests
		[Test]
		public void SetFullZoomAttribute_SettingToDefault()
		{
			browser.TestLoadHtml("hello world.");

			browser.GetMarkupDocumentViewer().SetFullZoomAttribute(1.0F);

			Assert.AreEqual(1.0F, browser.GetMarkupDocumentViewer().GetFullZoomAttribute());
		}

		// TODO: move unittest into GeckoMarkupDocumentViewerTests
		[Ignore("SetFullZoomAttribute to anything other than 1.0 causes memory corruption")]
		[Test]
		public void SetFullZoomAttribute_ZoomingIn()
		{
			browser.TestLoadHtml("hello world.");

			browser.GetMarkupDocumentViewer().SetFullZoomAttribute(2.0F);

			Assert.AreEqual(2.0F, browser.GetMarkupDocumentViewer().GetFullZoomAttribute());
		}
	}
}
