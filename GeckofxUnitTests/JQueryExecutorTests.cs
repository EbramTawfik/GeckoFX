using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Gecko;
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

            var executor = new Gecko.JQuery.JQueryExecutor(browser.Window);
            JsVal value = executor.ExecuteJQuery("$('#a')");
            Assert.IsTrue(value.IsObject);
        }

        [Test]
        [Platform(Exclude = "Linux", Reason = "Crashes on Linux")]
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
        [Platform(Exclude = "Linux", Reason = "Crashes on Linux")]
        public void JQueryExecutor_GetElementsByJQuery_ScriptExecutesAndReturnsExpectedResult()
        {
            browser.TestLoadHtml(JQueryExecutorTestsHtml);

            var executor = new Gecko.JQuery.JQueryExecutor(browser.Window);

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
            var executor = new Gecko.JQuery.JQueryExecutor(browser.Window);

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
            var bodyContent = string.Concat(Enumerable.Repeat($@"<p>Content</p>{Environment.NewLine}", lineCount).ToArray());
            var htmlDocument = $@"<html><head><script src='http://ajax.googleapis.com/ajax/libs/jquery/1.10.2/jquery.min.js'></script></head><body>{bodyContent}</body></html>";
            var tempFile = Path.GetTempFileName();

            using (var writer = new StreamWriter(tempFile, false))
            {
                writer.Write(htmlDocument);
            }
            return tempFile;
        }
    }
}
