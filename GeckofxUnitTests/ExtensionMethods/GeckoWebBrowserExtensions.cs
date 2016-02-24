using System.Threading.Tasks;
using Gecko;

namespace GeckofxUnitTests.ExtensionMethods
{
    public static class GeckoWebBrowserExtensions
    {
        public static async Task NavigateAndWait(this IGeckoWebBrowser browser, string url)
        {
            browser.Navigate(url);
            await browser.WaitUntilNavigatinFinished();
        }

        public static async Task WaitUntilNavigatinFinished(this IGeckoWebBrowser browser)
        {
            var done = false;
            browser.DocumentCompleted += (sender, e) => done = true;
            browser.NavigationError += (sender, e) => done = true;
            browser.Retargeted += (sender, e) => done = true;

            while (!done)
            {
                await Task.Delay(50);
            }
        }
    }
}
