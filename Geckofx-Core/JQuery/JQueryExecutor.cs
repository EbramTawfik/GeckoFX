using System.Collections.Generic;
using System.Globalization;

namespace Gecko.JQuery
{
    public class JQueryExecutor
    {
        private readonly GeckoWindow m_Window;

        public JQueryExecutor(GeckoWindow window)
        {
            m_Window = window;
        }

        public JsVal ExecuteJQuery(string jQuery)
        {
            JsVal jsValue;

            using (var autoContext = new AutoJSContext(m_Window.JSContext))
            {
                jsValue = autoContext.EvaluateScript(jQuery);
            }

            return jsValue;
        }

        public GeckoElement GetElementByJQuery(string jQuery)
        {
            JsVal jsValue;

            using (var autoContext = new AutoJSContext(m_Window.JSContext))
            {
                jsValue = autoContext.EvaluateScript(jQuery);
            }

            if (!jsValue.IsObject)
            {
                return null;
            }

            var nativeComObject = jsValue.ToObject();
            var element = Xpcom.QueryInterface<nsIDOMHTMLElement>(nativeComObject);
            if (element != null)
            {
                return GeckoHtmlElement.Create(element);
            }

            if (!SpiderMonkey.JS_HasProperty(m_Window.JSContext, jsValue.AsPtr, "length"))
            {
                return null;
            }

            var length = SpiderMonkey.JS_GetProperty(m_Window.JSContext, jsValue.AsPtr, "length").ToInteger();
            if (length == 0)
            {
                return null;
            }

            var FirstNativeDom = SpiderMonkey.JS_GetProperty(m_Window.JSContext, jsValue.AsPtr, "0").ToObject();
            element = Xpcom.QueryInterface<nsIDOMHTMLElement>(FirstNativeDom);
            if (element != null)
            {
                return GeckoHtmlElement.Create(element);
            }

            return null;
        }

        public IEnumerable<GeckoElement> GetElementsByJQuery(string jQuery)
        {
            JsVal jsValue;
            var elements = new List<GeckoElement>();

            using (var autoContext = new AutoJSContext(m_Window.JSContext))
            {
                jsValue = autoContext.EvaluateScript(jQuery);
            }

            if (!jsValue.IsObject)
            {
                return null;
            }

            if (!SpiderMonkey.JS_HasProperty(m_Window.JSContext, jsValue.AsPtr, "length"))
            {
                return null;
            }

            var length = SpiderMonkey.JS_GetProperty(m_Window.JSContext, jsValue.AsPtr, "length").ToInteger();
            if (length == 0)
            {
                return null;
            }

            for (var elementIndex = 0; elementIndex < length; elementIndex++)
            {
                var FirstNativeDom = SpiderMonkey.JS_GetProperty(m_Window.JSContext, jsValue.AsPtr, elementIndex.ToString(CultureInfo.InvariantCulture)).ToObject();
                var element = Xpcom.QueryInterface<nsIDOMHTMLElement>(FirstNativeDom);
                if (element != null)
                {
                    elements.Add(GeckoHtmlElement.Create(element));
                }
            }

            return elements;
        }


    }
}
