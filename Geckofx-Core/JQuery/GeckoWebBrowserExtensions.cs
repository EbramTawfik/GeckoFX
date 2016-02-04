using System.Collections.Generic;

namespace Gecko.JQuery
{
    public static class GeckoWebBrowserExtensions
    {
        public static void  ExecuteJQuery(this IGeckoWebBrowser browser, string jQuery)
        {
            var jquery = new JQueryExecutor(browser.Window);

            jquery.ExecuteJQuery(jQuery);
        }

        public static GeckoElement GetElementByJQuery(this IGeckoWebBrowser browser, string jQuery)
        {
            var jquery = new JQueryExecutor(browser.Window);

            return jquery.GetElementByJQuery(jQuery);
        }

        public static IEnumerable<GeckoElement> GetElementsByJQuery(this IGeckoWebBrowser browser, string jQuery)
        {
            var jquery = new JQueryExecutor(browser.Window);

            return jquery.GetElementsByJQuery(jQuery);
        }
    }
}
