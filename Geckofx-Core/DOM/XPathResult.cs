using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gecko.Interop;

namespace Gecko.DOM
{
    public class XPathResult
    {
        private ComPtr<nsIDOMWindow> _window;
        private ComPtr<nsIXPathResult> _xpathResult = null;

        internal XPathResult(nsIDOMWindow window, nsIXPathResult xpathResult)
        {
            _window = new ComPtr<nsIDOMWindow>(window);
            _xpathResult = new ComPtr<nsIXPathResult>(xpathResult);
        }

        public XPathResultType GetResultType()
        {
            using (var context = new AutoJSContext())
            {
                var jsObject = context.ConvertCOMObjectToJSObject((nsISupports) _xpathResult.Instance);
                return
                    (XPathResultType)
                        SpiderMonkey.JS_GetProperty(context.ContextPointer, jsObject, "resultType").ToInteger();
            }
        }

        public double GetNumberValue()
        {
            using (var context = new AutoJSContext())
            {
                var jsObject = context.ConvertCOMObjectToJSObject((nsISupports) _xpathResult.Instance);
                return SpiderMonkey.JS_GetProperty(context.ContextPointer, jsObject, "numberValue").ToDouble();
            }
        }

        public string GetStringValue()
        {
            using (var context = new AutoJSContext())
            {
                var jsObject = context.ConvertCOMObjectToJSObject((nsISupports) _xpathResult.Instance);
                return SpiderMonkey.JS_GetProperty(context.ContextPointer, jsObject, "stringValue").ToString();
            }
        }

        public bool GetBooleanValue()
        {
            using (var context = new AutoJSContext())
            {
                var jsObject = context.ConvertCOMObjectToJSObject((nsISupports) _xpathResult.Instance);
                return SpiderMonkey.JS_GetProperty(context.ContextPointer, jsObject, "booleanValue").ToBoolean();
            }
        }

        public GeckoNode GetSingleNodeValue()
        {
            // TODO: fixme - GetSingleNodeValue is returning property not found - even though it exists in the webidl?
            return new WebIDL.XPathResult(_window.Instance, _xpathResult.Instance as nsISupports).IterateNext().Wrap(GeckoNode.Create);
        }

        public IEnumerable<GeckoNode> GetNodes()
        {
            // TODO: fixme this should return a new copy of the results.
            return new GeckoNodeEnumerable(new WebIDL.XPathResult(_window.Instance, _xpathResult.Instance as nsISupports));
        }
    }

    public enum XPathResultType
        : ushort
    {
        Any = nsIDOMXPathResultConsts.ANY_TYPE,
        Number = nsIDOMXPathResultConsts.NUMBER_TYPE,
        String = nsIDOMXPathResultConsts.STRING_TYPE,
        Boolean = nsIDOMXPathResultConsts.BOOLEAN_TYPE,
        UnorderedNodeIterator = nsIDOMXPathResultConsts.UNORDERED_NODE_ITERATOR_TYPE,
        OrderedNodeIterator = nsIDOMXPathResultConsts.ORDERED_NODE_ITERATOR_TYPE,
        UnorderedNodeSnapshot = nsIDOMXPathResultConsts.UNORDERED_NODE_SNAPSHOT_TYPE,
        OrderedNodeSnapshot = nsIDOMXPathResultConsts.ORDERED_NODE_SNAPSHOT_TYPE,
        AnyUnorderedNode = nsIDOMXPathResultConsts.ANY_UNORDERED_NODE_TYPE,
        FirstOrderedNode = nsIDOMXPathResultConsts.FIRST_ORDERED_NODE_TYPE,
    }
}