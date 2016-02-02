using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Gecko;
using Gecko.JQuery;
using NUnit.Framework;

namespace GeckofxUnitTests
{
    public class JQueryExecutorTests
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

            var executor = new JQueryExecutor(browser.Window);
            JsVal value = executor.ExecuteJQuery("$('#a')");
            Assert.IsTrue(value.IsObject);
        }

        [Test]
        [Platform(Exclude = "Linux", Reason = "Crashes on Linux")]
        public void JQueryExecutor_GetElementByJQuery_ScriptExecutesAndReturnsExpectedResult()
        {
            browser.TestLoadHtml(JQueryExecutorTestsHtml);

            var executor = new JQueryExecutor(browser.Window);
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
            browser.TestLoadHtml(JQueryExecutorTestsHtml);

            var executor = new JQueryExecutor(browser.Window);

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
                var executor = new JQueryExecutor(browser.Window);

                var value = executor.ExecuteJQuery(@"$('p').first().text()").ToString();

                Assert.That(value, Is.EqualTo("Content"));

                GC.Collect();
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
            var executor = new JQueryExecutor(browser.Window);

            var elements = executor.GetElementsByJQuery(@"$('p')").ToList();
            return elements;
        }

        private void NavigateToTempFile(string tempFile)
        {
            browser.Navigate(tempFile);
            browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
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
