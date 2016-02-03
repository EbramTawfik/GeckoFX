using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using Gecko;
using Gecko.JQuery;
using NUnit.Framework;

namespace GeckofxUnitTests
{
    public class JQueryExecutorTests
    {

        private GeckoWebBrowser _browser;
        private nsIMemory _memoryService;

        [SetUp]
        public void BeforeEachTestSetup()
        {
            Xpcom.Initialize(XpComTests.XulRunnerLocation);
            //affecting browser.Realod()/GoForward()/GoBackward() of error page
            GeckoPreferences.User["browser.xul.error_pages.enabled"] = true;
            _browser = new GeckoWebBrowser();
            var unused = _browser.Handle;
            Assert.IsNotNull(_browser);
            _memoryService = Xpcom.GetService<nsIMemory>("@mozilla.org/xpcom/memory-service;1");
        }

        [TearDown]
        public void AfterEachTestTearDown()
        {
            Marshal.ReleaseComObject(_memoryService);
            _browser.Dispose();
        }

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
            _browser.TestLoadHtml(JQueryExecutorTestsHtml);

            var executor = new JQueryExecutor(_browser.Window);
            JsVal value = executor.ExecuteJQuery("$('#a')");
            Assert.IsTrue(value.IsObject);
        }

        [Test]
        [Platform(Exclude = "Linux", Reason = "Crashes on Linux")]
        public void JQueryExecutor_GetElementByJQuery_ScriptExecutesAndReturnsExpectedResult()
        {
            _browser.TestLoadHtml(JQueryExecutorTestsHtml);

            var executor = new JQueryExecutor(_browser.Window);
            GeckoElement div = null;
            Assert.DoesNotThrow(() => div = executor.GetElementByJQuery("$('#a')"));
            Assert.IsNotNull(div);
            Assert.AreEqual("DIV", div.TagName);
            Assert.AreEqual("a", div.GetAttribute("id"));
        }

        [Test]
        [Platform(Exclude = "Linux", Reason = "Crashes on Linux")]
        public void JQueryExecutor_GetElementsByJQuery_ScriptExecutesAndReturnsExpectedResult()
        {
            _browser.TestLoadHtml(JQueryExecutorTestsHtml);

            var executor = new JQueryExecutor(_browser.Window);

            List<GeckoElement> elements = null;
            Assert.DoesNotThrow(() => elements = executor.GetElementsByJQuery("$('.divs')").ToList());
            Assert.IsNotNull(elements);
            Assert.AreEqual(2, elements.Count());

            foreach (var div in elements)
            {
                Assert.IsNotNull(div);
                Assert.AreEqual("DIV", div.TagName);
                Assert.AreEqual("divs", div.GetAttribute("class"));
            }
        }

        [Test, Explicit]
        [Platform(Exclude = "Linux", Reason = "Crashes on Linux")]
        public void JQueryExecutor_GetElementsByJQueryWithLargeHTML_Query1000Times_DoesNotProduceMemoryLeak()
        {
            const int lineCount = 10000;
            var tempFile = CreateTempFile(lineCount);

            NavigateToTempFile(tempFile);

            for (var testCounter = 0; testCounter < 1000; testCounter++)
            {
                var elements = GetPElementsWithJQuery();
                Assert.That(elements.Count, Is.EqualTo(lineCount));
                GC.Collect();
                _memoryService.HeapMinimize(true);
            }

            CleanUp(tempFile);
        }

        [Test, Explicit]
        [Platform(Exclude = "Linux", Reason = "Crashes on Linux")]
        public void JQueryExecutor_GetElementsByJQueryWithLargeHTML_ReNavigateAndQuery1000Times_DoesNotProduceMemoryLeak()
        {
            const int lineCount = 10000;
            var tempFile = CreateTempFile(lineCount);

            for (var testCounter = 0; testCounter < 1000; testCounter++)
            {
                NavigateToTempFile(tempFile);
                var elements = GetPElementsWithJQuery();
                Assert.That(elements.Count, Is.EqualTo(lineCount));
                GC.Collect();
                _memoryService.HeapMinimize(true);
            }

            CleanUp(tempFile);
        }

        [Test, Explicit]
        [Platform(Exclude = "Linux", Reason = "Crashes on Linux")]
        public void JQueryExecutor_ExecuteJQueryWithLargeHTML_ReturnsString_DoesNotProduceMemoryLeak()
        {
            const int lineCount = 100;
            var tempFile = CreateTempFile(lineCount);

            NavigateToTempFile(tempFile);
            for (var testCounter = 0; testCounter < 1000000; testCounter++)
            {
                var executor = new JQueryExecutor(_browser.Window);

                var value = executor.ExecuteJQuery(@"$('p').first().text()").ToString();

                Assert.That(value, Is.EqualTo("Content"));

                GC.Collect();
                _memoryService.HeapMinimize(true);
            }

            CleanUp(tempFile);
        }

        [Test, Explicit]
        [Platform(Exclude = "Linux", Reason = "Crashes on Linux")]
        public void JQueryExecutor_ExecuteJQueryWithLargeHTML_ReturnsNothing_DoesNotProduceMemoryLeak()
        {
            const int lineCount = 100;
            var tempFile = CreateTempFile(lineCount);

            NavigateToTempFile(tempFile);
            for (var testCounter = 0; testCounter < 1000000; testCounter++)
            {
                NavigateToTempFile(tempFile);
                var executor = new JQueryExecutor(_browser.Window);

                executor.ExecuteJQuery(@"$('p').first().hide()");

                GC.Collect();
                _memoryService.HeapMinimize(true);
            }

            CleanUp(tempFile);
        }

        [Test, Explicit]
        [Platform(Exclude = "Linux", Reason = "Crashes on Linux")]
        public void GeckoWebBrowser_ExecuteJQueryWithLargeHTML_ReturnsNothing_DoesNotProduceMemoryLeak()
        {
            const int lineCount = 100;
            var tempFile = CreateTempFile(lineCount);

            NavigateToTempFile(tempFile);
            for (var testCounter = 0; testCounter < 1000000; testCounter++)
            {
                using (var context = new AutoJSContext(_browser.Window))
                {
                    context.EvaluateScript(@"$('p').first().hide()");
                }

                GC.Collect();
                _memoryService.HeapMinimize(true);
            }

            CleanUp(tempFile);
        }

        private void CleanUp(string tempFile)
        {
            try
            {
                File.Delete(tempFile);
            }
            catch (Exception)
            {
                //Ignore
            }
        }

        private List<GeckoElement> GetPElementsWithJQuery()
        {
            var executor = new JQueryExecutor(_browser.Window);

            var elements = executor.GetElementsByJQuery(@"$('p')").ToList();
            return elements;
        }

        private void NavigateToTempFile(string tempFile)
        {
            _browser.Navigate(tempFile);
            _browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
        }

        private static string CreateTempFile(int lineCount)
        {
            var bodyContent = string.Concat(Enumerable.Repeat(string.Format(@"<p>Content</p>{0}", Environment.NewLine), lineCount).ToArray());
            var htmlDocument = string.Format(@"<html><head><script src='http://ajax.googleapis.com/ajax/libs/jquery/1.10.2/jquery.min.js'></script></head><body>{0}</body></html>", bodyContent);
            var tempFile = Path.GetTempFileName();

            using (var writer = new StreamWriter(tempFile, false))
            {
                writer.Write(htmlDocument);
            }
            return tempFile;
        }
    }
}
