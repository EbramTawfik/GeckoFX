using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gecko.Interop;

namespace Gecko.DOM
{
    /// <summary>
    /// // TODO: (Idenally this class would be generated using a webidl-> C# compiler but for now just do it via manually written spidermonkey calls..)
    /// </summary>
	public class XPathResult
	{
        private ComPtr<nsIXPathResult> xpathResult = null;

        internal XPathResult(nsIXPathResult xpathResult)
		{
            this.xpathResult = new ComPtr<nsIXPathResult>(xpathResult);
		}

		public XPathResultType GetResultType()
		{
            using (var context = new AutoJSContext())
            {
                var jsObject = context.ConvertCOMObjectToJSObject((nsISupports)xpathResult.Instance);
                return (XPathResultType)SpiderMonkey.JS_GetProperty(context.ContextPointer, jsObject, "resultType").ToInteger();
            }			
		}

		public double GetNumberValue()
		{
            using (var context = new AutoJSContext())
            {
                var jsObject = context.ConvertCOMObjectToJSObject((nsISupports)xpathResult.Instance);
                return SpiderMonkey.JS_GetProperty(context.ContextPointer, jsObject, "numberValue").ToDouble();
            }
		}

		public string GetStringValue()
		{
            using (var context = new AutoJSContext())
            {
                var jsObject = context.ConvertCOMObjectToJSObject((nsISupports)xpathResult.Instance);
                return SpiderMonkey.JS_GetProperty(context.ContextPointer, jsObject, "stringValue").ToString();
            }
		}

		public bool GetBooleanValue()
		{            
		    using (var context = new AutoJSContext())
		    {
		        var jsObject = context.ConvertCOMObjectToJSObject((nsISupports) xpathResult.Instance);		        
		        return SpiderMonkey.JS_GetProperty(context.ContextPointer, jsObject, "booleanValue").ToBoolean();
		    }
		}

		public GeckoNode GetSingleNodeValue()
		{
		    using (var context = new AutoJSContext())
		    {
		        var jsObject = context.ConvertCOMObjectToJSObject((nsISupports) xpathResult.Instance);
                return (SpiderMonkey.JS_GetProperty(context.ContextPointer, jsObject, "singleNodeValue").ToComObject(context.ContextPointer) as nsIDOMNode).Wrap(GeckoNode.Create);
		    }
		}
        public IEnumerable<GeckoNode> GetNodes()
		{
			return new GeckoNodeEnumerable( xpathResult.Instance );
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
