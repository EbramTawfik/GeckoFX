using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Gecko.JQuery
{
    public class JQueryExecutor
    {
        private readonly GeckoWindow _window;

        public JQueryExecutor(GeckoWindow window)
        {
            _window = window;
        }

        public JsVal ExecuteJQuery(string jQuery)
        {
            JsVal jsValue;

            using (var autoContext = new AutoJSContext(_window))
            {
                jsValue = autoContext.EvaluateScript(jQuery, _window.DomWindow);
            }

            return jsValue;
        }

        public GeckoElement GetElementByJQuery(string jQuery)
        {
            using (var autoContext = new AutoJSContext(_window))
            {
                var jsValue = autoContext.EvaluateScript(jQuery, _window.DomWindow);

                if (!jsValue.IsObject)
                {
                    return null;
                }

                var nativeComObject = jsValue.ToComObject(autoContext.ContextPointer);
                var element = Xpcom.QueryInterface<nsIDOMHTMLElement>(nativeComObject);
                if (element != null)
                {
                    return GeckoHtmlElement.Create(element);
                }

                if (!SpiderMonkey.JS_HasProperty(autoContext.ContextPointer, jsValue.AsPtr, "length"))
                {
                    return null;
                }

                var length = SpiderMonkey.JS_GetProperty(autoContext.ContextPointer, jsValue.AsPtr, "length").ToInteger();
                if (length == 0)
                {
                    return null;
                }

                return CreateHtmlElementFromDom(autoContext, jsValue, 0);
            }
        }

        public IEnumerable<GeckoElement> GetElementsByJQuery(string jQuery)
        {
            using (var autoContext = new AutoJSContext(_window))
            {
                var jsValue = autoContext.EvaluateScript(jQuery, _window.DomWindow);
                if (!jsValue.IsObject)
                    return new List<GeckoElement>();

                if (!SpiderMonkey.JS_HasProperty(autoContext.ContextPointer, jsValue.AsPtr, "length"))
                {
                    return new List<GeckoElement>();
                }

                var length = SpiderMonkey.JS_GetProperty(autoContext.ContextPointer, jsValue.AsPtr, "length").ToInteger();
                if (length == 0)
                {
                    return new List<GeckoElement>();
                }

                return Enumerable.Range(0, length).Select(elementIndex => CreateHtmlElementFromDom(autoContext, jsValue, elementIndex)).Where(element => element != null).ToList();
            }
        }

        private static GeckoElement CreateHtmlElementFromDom(AutoJSContext autoContext, JsVal jsValue, int elementIndex)
        {
            var elementIndexString = elementIndex.ToString(CultureInfo.InvariantCulture);
            var firstNativeDom = SpiderMonkey.JS_GetProperty(autoContext.ContextPointer, jsValue.AsPtr, elementIndexString).ToComObject(autoContext.ContextPointer);

            var element = Xpcom.QueryInterface<nsIDOMHTMLElement>(firstNativeDom);
            if (element == null)
            {
                return null;
            }

            return GeckoHtmlElement.Create(element);
        }
    }
}