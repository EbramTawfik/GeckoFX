using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using Gecko;
using NUnit.Framework;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gecko.DOM;
using Gecko.JQuery;
using GeckofxUnitTests.ExtensionMethods;
using GeckofxUnitTests.Forms;

namespace GeckofxUnitTests
{
    public class MemoryStressTests
    {

        [SetUp]
        public void BeforeEachTestSetup()
        {
            Xpcom.Initialize(XpComTests.XulRunnerLocation);
            //affecting browser.Realod()/GoForward()/GoBackward() of error page
            GeckoPreferences.User["browser.xul.error_pages.enabled"] = true;
            GeckoPreferences.User["browser.sessionhistory.max_entries"] = 0;
            GeckoPreferences.User["browser.sessionhistory.max_total_viewers"] = 0;
        }

        [TearDown]
        public void AfterEachTestTearDown()
        {
            Xpcom.Shutdown();
        }

        [Test]
        public void StressTestGeckoFxBrowserMemory()
        {
            var aboutMemory = new UnitTestBrowser();
            var uiThreadContext = TaskScheduler.FromCurrentSynchronizationContext();
            var unused = Task.Factory.StartNew(() => StartUnitTest(aboutMemory), new CancellationToken(), TaskCreationOptions.LongRunning, uiThreadContext);
            Application.Run(aboutMemory);
        }

        private async void StartUnitTest(UnitTestBrowser browserWindow)
        {
            try
            {
                await DoStressTest(browserWindow.wbUnitTest);
            }
            catch (Exception)
            {
                //Ignore
            }
            finally
            {
                //browserWindow.Close();
            }
        }

        private async Task DoStressTest(GeckoWebBrowser browser)
        {
            await Task.Delay(1000);

            var pageLinks = Enumerable.Range(1, 100).Select(page => string.Format(@"https://bitbucket.org/repo/all/{0}?name=c%23", page)).ToList();
            var callbacks = new List<string>();

            browser.AddMessageEventListener("callback", value => callbacks.Add(value));


            var repoLinks = new List<string>();
            foreach (var link in pageLinks)
            {
                repoLinks.AddRange(await RetrieveBitbucketRepositoryLinks(browser, link));

                DoCallbacks(browser);
            }

            Debug.WriteLine("Found {0} repo links", repoLinks.Count);
        }

        private void DoCallbacks(IGeckoWebBrowser browser)
        {
            browser.ExecuteJQuery(@"
            $('a.repo-link').each(function(){
                var content = $(this).text();
                var event = new MessageEvent('callback', { 'view' : window, 'bubbles' : true, 'cancelable' : false, 'data' : content});
                document.dispatchEvent (event);
            });");
        }

        private static async Task<IEnumerable<string>> RetrieveBitbucketRepositoryLinks(IGeckoWebBrowser browser, string pageLink)
        {
            await browser.NavigateAndWait(pageLink);

            return browser.GetElementsByJQuery(@"$(""a.repo-link"")").OfType<GeckoAnchorElement>().Select(element => element.Href).ToList();
        }
    }
}
