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

			using (var autoContext = new AutoJSContext())
			{
				jsValue = autoContext.EvaluateScript((nsISupports)m_Window.DomWindow, jQuery);
			}

			return jsValue;
		}

		public GeckoElement GetElementByJQuery(string jQuery)
		{
			JsVal jsValue;

			using (var autoContext = new AutoJSContext())
			{
				jsValue = autoContext.EvaluateScript((nsISupports)m_Window.DomWindow, jQuery);
				if (jsValue.IsObject)
				{
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

					var firstNativeDom = SpiderMonkey.JS_GetProperty(autoContext.ContextPointer, jsValue.AsPtr, "0").ToComObject(autoContext.ContextPointer);
					element = Xpcom.QueryInterface<nsIDOMHTMLElement>(firstNativeDom);
					if (element != null)
					{
						return GeckoHtmlElement.Create(element);
					}
				}

			}
			return null;
		}

		public IEnumerable<GeckoElement> GetElementsByJQuery(string jQuery)
		{
			JsVal jsValue;
			var elements = new List<GeckoElement>();

			using (var autoContext = new AutoJSContext())
			{
				jsValue = autoContext.EvaluateScript((nsISupports)m_Window.DomWindow, jQuery);
				if (jsValue.IsObject)
				{
					if (!SpiderMonkey.JS_HasProperty(autoContext.ContextPointer, jsValue.AsPtr, "length"))
					{
						return null;
					}

					var length = SpiderMonkey.JS_GetProperty(autoContext.ContextPointer, jsValue.AsPtr, "length").ToInteger();
					if (length == 0)
					{
						return null;
					}

					for (var elementIndex = 0; elementIndex < length; elementIndex++)
					{
						var firstNativeDom = SpiderMonkey.JS_GetProperty(autoContext.ContextPointer, jsValue.AsPtr, elementIndex.ToString(CultureInfo.InvariantCulture)).ToComObject(autoContext.ContextPointer);
						var element = Xpcom.QueryInterface<nsIDOMHTMLElement>(firstNativeDom);
						if (element != null)
						{
							elements.Add(GeckoHtmlElement.Create(element));
						}
					}
				}
			}
			return elements;
		}


	}
}
