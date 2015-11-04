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
			//affecting browser.Realod()/GoForward()/GoBackward() of error page
			GeckoPreferences.User["browser.xul.error_pages.enabled"] = true;
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

			for (int i = 5; i >= 0; i--)
			{
				GC.Collect();
				GC.WaitForPendingFinalizers();
			}
			
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
		public void LoadHtmlInUrl_SomeSimpleHtml_HtmlIsLoadedAndAccessableAfterNavigationFinished()
		{
			string innerHtml = "<div id=\"_lv5\">old value</div>";
			string url = "http://mydomain.myzone/";

			browser.LoadHtml("<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">"

							 + "<html xmlns=\"http://www.w3.org/1999/xhtml\" >"

							 + "<body>" + innerHtml + "</body></html>", url);

			browser.NavigateFinishedNotifier.NavigateFinished += (sender, e) =>
			{
				Assert.AreEqual(innerHtml, browser.Document.Body.InnerHtml);
			};

			browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();

			Assert.AreEqual(innerHtml, browser.Document.Body.InnerHtml);

			Assert.AreEqual(url, browser.Url.AbsoluteUri);
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

        [Ignore("JavascriptError need refactoring to the new system (in gecko 33+)")]
		[Platform("Win")]
		[Test]
		public void JavascriptError_NaviagateWithSomeJavascriptThatThrowsException_AttachedEventHandlerShouldExecute()
		{
			List<JavascriptErrorEventArgs> errorEventArgs = new List<JavascriptErrorEventArgs>();

#if PORT
			browser.JavascriptError += (object sender, JavascriptErrorEventArgs e) => errorEventArgs.Add(e);
#endif

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
			// Error messages changes based upon locale. (color/colour)
			Assert.IsTrue(eventArgs.Message.Contains("JavaScript Warning: \"Expected"), eventArgs.Message);
			Assert.IsTrue(eventArgs.Message.Contains("but found 'bluse'"), eventArgs.Message);
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
									var event = new MessageEvent('callMe',  { 'view' : window, 'bubbles' : true, 'cancelable' : false, 'data' : 'some data'}); document.dispatchEvent (event);
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

			using (AutoJSContext context = new AutoJSContext(browser.Window.JSContext))
			{				
				string result;
				Assert.IsTrue(context.EvaluateScript("3 + 2;", out result));
				Assert.AreEqual(5, Int32.Parse(result));

				Assert.IsTrue(context.EvaluateScript("'hello' + ' ' + 'world';", out result));
				Assert.AreEqual("hello world", result);
			}				
		}

		[Test]
		public void EvaluateScript_UnicodeJavascript_ScriptExecutesAndReturnsExpectedResult()
		{
			browser.TestLoadHtml("");

			using (AutoJSContext context = new AutoJSContext(browser.Window.JSContext))
			{
				string result;

				Assert.IsTrue(context.EvaluateScript("'文';", out result));
				Assert.AreEqual("文"[0], result[0]);

                Assert.IsTrue(context.EvaluateScript("'a\0a';", out result));
                Assert.AreEqual("a\0a", result);

                Assert.IsTrue(context.EvaluateScript("'hello' + ' ' + '中\0文';", out result));
                Assert.AreEqual("hello 中\0文", result);

			}
		}

		[Test]
		public void EvaluateScript_SimpleJavascriptWithoutNormalDocumentSetup_ScriptExecutesAndReturnsExpectedResult()
		{		
			using (AutoJSContext context = new AutoJSContext(browser.Window.JSContext))
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
			
			using (AutoJSContext context = new AutoJSContext(browser.Window.JSContext))
			{
				string result;
				Assert.IsTrue(context.EvaluateScript("this", (nsISupports)browser.Window.DomWindow, out result));
				Assert.AreEqual("[object Window]", result);

				Assert.IsTrue(context.EvaluateScript("this", (nsISupports)browser.Document.DomObject, out result));
				Assert.AreEqual("[object HTMLDocument]", result);

				Assert.IsTrue(context.EvaluateScript("this.defaultView", (nsISupports)browser.Document.DomObject, out result));
				Assert.AreEqual("[object Window]", result);

				Assert.IsTrue(context.EvaluateScript("this.body.innerHTML;", (nsISupports)browser.Document.DomObject, out result));
				Assert.AreEqual("hello world", result);

				Assert.IsTrue(context.EvaluateScript("body.innerHTML = 'hi';", (nsISupports)browser.Document.DomObject, out result));
				Assert.IsTrue(context.EvaluateScript("body.innerHTML;", (nsISupports)browser.Document.DomObject, out result));
				Assert.AreEqual("hi", result);

				Assert.IsTrue(context.EvaluateScript("x=10;y=20;x*y;", out result));
				Assert.AreEqual("200", result);
			}
		} 

		[Test]
		public void EvaluateScript_JavascriptAccessExistingGlobalObjectsWithoutNormalDocumentSetup_ScriptExecutesAndReturnsExpectedResult()
		{
			using (AutoJSContext context = new AutoJSContext(browser.Window.JSContext))
			{
				string result;
				Assert.IsTrue(context.EvaluateScript("this", (nsISupports)browser.Window.DomWindow, out result));
				Assert.AreEqual("[object Window]", result);

				Assert.IsTrue(context.EvaluateScript("body.innerHTML;", (nsISupports)browser.Document.DomObject, out result));
				Assert.AreEqual(String.Empty, result);

				Assert.IsTrue(context.EvaluateScript("this.document.body.innerHTML = 'hi';", (nsISupports)browser.Window.DomWindow, out result));
				Assert.IsTrue(context.EvaluateScript("this.document.body.innerHTML;", (nsISupports)browser.Window.DomWindow, out result));
				Assert.AreEqual("hi", result);

				Assert.IsTrue(context.EvaluateScript("x=10;y=20;x*y;", out result));
				Assert.AreEqual("200", result);
			}
		}
		
		[Test]
		[Ignore("Disabled in Gecko for security")]
		public void EvaluateScript_JavascriptIncreasePriviligesCrossFrameAccess_ScriptExecutesAndReturnsExpectedResult()
		{
			string result;
			string aboutBlank;
			using (var page = new GeckoWebBrowser())
			{
				IntPtr unused = page.Handle;			
				page.CreateWindow += (s, e) => { e.WebBrowser = browser; };				
				using (AutoJSContext context = new AutoJSContext(page.Window.JSContext))
				{
					Assert.IsTrue(context.EvaluateScript("window.open('http://www.google.com'); window.location.href", out aboutBlank));
				}				
				browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();

				using (AutoJSContext context = new AutoJSContext(browser.Window.JSContext))
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

			using (AutoJSContext context = new AutoJSContext(browser.Window.JSContext))
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

			using (AutoJSContext context = new AutoJSContext(browser.Window.JSContext))
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

			using (AutoJSContext context = new AutoJSContext(browser.Window.JSContext))
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
				using (AutoJSContext context = new AutoJSContext(browser.Window.JSContext))
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

				using (AutoJSContext context = new AutoJSContext(browser.Window.JSContext))
				{
					string result;
					context.EvaluateScript("2+3;", out result);
					Assert.AreEqual("5", result);
				}
			}
		}

		[Test]
		public void EvaluateScript_ReturingJsVal_ScriptExecutesAndReturnsJsValOfExpectedTypeAndContainingExpectedResult()
		{
			using (var context = new AutoJSContext(browser.Window.JSContext))
			{				
				var jsVal = context.EvaluateScript("3 + 2;");
				Assert.IsTrue(jsVal.IsInt);
				Assert.AreEqual(5, jsVal.ToInteger());
			}
		}
		
		#region JQueryExecutor

		private const string JQueryExecutorTestsHtml = @"
<html>
	<body>
		<script src='http://ajax.googleapis.com/ajax/libs/jquery/1.10.2/jquery.min.js'></script>
		<div id='a' class='divs'></div>
		<div id='b' class='divs'></div>
	</body>
</html>
";

		[Test]
		public void JQueryExecutor_ExecuteJQuery_ScriptExecutesAndReturnsJsValOfExpectedType()
		{
			browser.TestLoadHtml(JQueryExecutorTestsHtml);
			
			var executor = new Gecko.JQuery.JQueryExecutor(browser.Window);
			JsVal value = executor.ExecuteJQuery("$('#a')");
			Assert.IsTrue(value.IsObject);
		}

		[Test]
        [Platform(Exclude="Linux", Reason = "Crashes on Linux")]
		public void JQueryExecutor_GetElementByJQuery_ScriptExecutesAndReturnsExpectedResult()
		{
			browser.TestLoadHtml(JQueryExecutorTestsHtml);

			var executor = new Gecko.JQuery.JQueryExecutor(browser.Window);
			GeckoElement div = null;
			Assert.DoesNotThrow(() => div = executor.GetElementByJQuery("$('#a')"));
			Assert.IsNotNull(div);
			Assert.AreEqual("DIV", div.TagName);
			Assert.AreEqual("a", div.GetAttribute("id"));			
		}

		[Test]
        [Platform(Exclude="Linux", Reason = "Crashes on Linux")]
		public void JQueryExecutor_GetElementsByJQuery_ScriptExecutesAndReturnsExpectedResult()
		{
			browser.TestLoadHtml(JQueryExecutorTestsHtml);

			var executor = new Gecko.JQuery.JQueryExecutor(browser.Window);

			IEnumerable<GeckoElement> elements = null;
			Assert.DoesNotThrow(() => elements = executor.GetElementsByJQuery("$('.divs')"));
			Assert.IsNotNull(elements);
			Assert.AreEqual(2, elements.Count());

			foreach(var div in elements)
			{
				Assert.IsNotNull(div);
				Assert.AreEqual("DIV", div.TagName);
				Assert.AreEqual("divs", div.GetAttribute("class"));
			}
		}

		#endregion

		[Test]
		public void GetMarkupDocumentViewer_InitalizedDocument_ValidGeckoMarkupDocumentViewerReturned()
		{
			browser.TestLoadHtml("hello world.");

			Assert.NotNull(browser.GetMarkupDocumentViewer());
		}

		[Test]
		public void Navigating_FrameDocumentLoaded_NavigatigAndFrameNavigatingEventIsCalled()
		{
			int navigatingCounter = 0;
			int frameNavigatingCounter = 0;
			browser.Navigating += (sender, args) => navigatingCounter++;
			browser.FrameNavigating += (sender, args) => frameNavigatingCounter++;

			browser.TestLoadHtml(@"<html><body><iframe src='data:text/html,hello world'></iframe></body></html>'");

			Assert.AreEqual(1, navigatingCounter, "Navigating");
			Assert.AreEqual(1, frameNavigatingCounter, "FrameNavigating");
		}

		[Test]
		public void Navigating_JSCreatedFrameDocumentLoaded_NavigatigAndFrameNavigatingEventIsCalled()
		{
			int navigatingCounter = 0;
			int	frameNavigatingCounter = 0;
			browser.Navigating += (sender, args) => navigatingCounter++;
			browser.FrameNavigating += (sender, args) => frameNavigatingCounter++;
			
			browser.TestLoadHtml(@"
<html>
	<body>
		<script type='text/javascript'>
setTimeout(function(){
			var iframe = document.createElement('iframe');
			iframe.src = 'data:text/html,hello world';
			document.body.appendChild(iframe);
}, 1000);
		</script>
	</body>
</html>");
			DateTime expire = DateTime.Now.AddSeconds(5);
			while (DateTime.Now < expire)
				Application.DoEvents();


			Assert.AreEqual(1, navigatingCounter, "Navigating");
			Assert.AreEqual(1, frameNavigatingCounter, "FrameNavigating");
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

		[Test]
		[Ignore("Navigate doesn't behave how describe in this unittest on my Windows 7 64bit machine.")]
		public void Navigating_NavigationError_Http()
		{
			int errorCount = 0, completeCount = 0;
			browser.DocumentCompleted += (sender, e) => ++ completeCount;
			browser.NavigationError += (sender, e) => ++ errorCount;

			browser.Navigate("http://localhost:63333");
			browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
			Assert.True(errorCount == 1 && completeCount == 0, "localhost:63333 should have failed.");
			errorCount = completeCount = 0;

			browser.Navigate("http://localhost:25");
			browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
			Assert.True(errorCount == 1 && completeCount == 0, "(1) localhost:25 should have failed.");
			errorCount = completeCount = 0;

			browser.Reload();
			browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
			Assert.True(errorCount == 1 && completeCount == 0, "(2) localhost:25 should have failed.");
			errorCount = completeCount = 0;
		}

		[Test]
		public void Navigating_NavigationError_Chrome()
		{
			int errorCount = 0, completeCount = 0;
			browser.DocumentCompleted += (sender, e) => ++ completeCount;
			browser.NavigationError += (sender, e) => ++ errorCount;

			browser.Navigate("chrome://global/content/bindings/general.xml"); //good url
			browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
			Assert.True(errorCount == 0 && completeCount == 1);
			errorCount = completeCount = 0;

			browser.Navigate("chrome://global/content/aaaa"); //not found
			browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
			Assert.True(errorCount == 1 && completeCount == 0);
			errorCount = completeCount = 0;

			Assert.True(browser.CanGoBack);
			browser.GoBack();
			browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
			Assert.True(errorCount == 0 && completeCount == 1);
			errorCount = completeCount = 0;

			Assert.True(browser.CanGoForward);
			browser.GoForward();
			browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
			Assert.True(errorCount == 1 && completeCount == 0);
			errorCount = completeCount = 0;

			browser.Navigate("chrome://global/bindings/general.xml"); //missing 'content' part
			browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
			Assert.True(errorCount == 1 && completeCount == 0);
			errorCount = completeCount = 0;

			browser.Navigate("chrome://global/content/bindings/general.xml");
			browser.Stop();
			browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
			Assert.True(errorCount == 1 && completeCount == 0);
			errorCount = completeCount = 0;

			browser.Navigate("chrome://global/content/bindings/general.xml");
			browser.Navigating += (sender, e) => e.Cancel = true;
			browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
			Assert.True(errorCount == 1 && completeCount == 0);
			errorCount = completeCount = 0;
		}

		[Test]
		public void Navigating_NavigationError_History()
		{
			string errorUrl = null;
			browser.NavigationError += (sender, e) => errorUrl = e.Uri;

			browser.Navigate("chrome://global/content/bindings/general.xml"); //good url
			browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();

			browser.Navigate("chrome://global/content/aaaa"); //not found
			browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();

			Assert.True(browser.CanGoBack);
			browser.GoBack();
			browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();

			Assert.True(browser.CanGoForward);
			browser.GoForward();
			browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
			Assert.AreEqual(errorUrl, "chrome://global/content/aaaa");

			browser.Navigate("chrome://global/bindings/general.xml"); //missing 'content' part
			browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
			Assert.AreEqual(errorUrl, "chrome://global/bindings/general.xml");
		}

		[Test]
		[Ignore("Expected fail.")]
		public void Navigating_NavigationError_History2()
		{
			string errorUrl = null;
			browser.NavigationError += (sender, e) => errorUrl = e.Uri;

			browser.Navigate("chrome://global/content/bindings/general.xml"); //good url
			browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();

			browser.Navigate("chrome://global/bindings/general.xml"); //missing 'content' part
			browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();

			// TODO Navigate("chrome://global/bindings/general.xml") failed and the url was not pushed into history stack,
			// so the assertion failed. may be a mozilla's bug
			Assert.True(browser.GoBack());
			browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
			Assert.True(browser.GoForward());
			browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
			Assert.AreEqual(errorUrl, "chrome://global/bindings/general.xml");
		}

		[Test]
		public void Navigating_Retarget()
		{
			int errorCount = 0, completeCount = 0, retargetCount = 0;
			string url = "data:application/zip,xyzuvw";
			GeckoRetargetedEventArgs rte = null;
			string contentType = null;
			browser.DocumentCompleted += (sender, e) => ++ completeCount;
			browser.NavigationError += (sender, e) => ++ errorCount;
			browser.Retargeted += (sender, e) =>
			{
				++retargetCount;
				rte = e;
				contentType = (rte.Request as Gecko.Net.Channel).ContentType;
			};

			browser.Navigate(url);
			browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
			Assert.True(errorCount == 0 && completeCount == 0 && retargetCount == 1, "Unexpected event counts");
			Assert.AreEqual(url, rte.Uri.ToString());
			Assert.AreEqual("application/zip", contentType);
		}

		[Test]
		public void LoadContent_ControlHandleCreated_DocumentIsInitalizedWithSpecifiedContent()
		{
			Assert.AreEqual(true, browser.IsHandleCreated);
			browser.LoadContent("<body><div id='main'>hello world</div></body>", "http://www.earth.com", "text/html");
			browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
			Assert.AreEqual(browser.Document.GetElementById("main").TextContent, "hello world");
		}

		[Test]
		public void LoadContent_ControlHandleNotCreated_DocumentIsInitalizedWithContentAndHandleCreationisForced()
		{
			using (var browser = new GeckoWebBrowser())
			{
				Assert.AreEqual(false, browser.IsHandleCreated);
				browser.LoadContent("<body><div id='main'>hello world</div></body>", "http://www.earth.com", "text/html");
				Assert.AreEqual(true, browser.IsHandleCreated);
				browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
				Assert.AreEqual(browser.Document.GetElementById("main").TextContent, "hello world");
			}
		}
	}
}