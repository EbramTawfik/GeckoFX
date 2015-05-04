using System.Collections.Generic;
using Gecko.Interop;

namespace Gecko
{
	/// <summary>
	/// Represents a collection of GeckoNode's
	/// </summary>
	internal class GeckoNodeEnumerable : IEnumerable<GeckoNode>
	{
		private nsIXPathResult xpathResult = null;

        internal GeckoNodeEnumerable(nsIXPathResult xpathResult)
		{
			this.xpathResult = xpathResult;
		}

		#region IEnumerable<GeckoNode> Members

	    public IEnumerator<GeckoNode> GetEnumerator()
	    {
	        using (var context = new AutoJSContext())
	        {
	            var jsObject = context.ConvertCOMObjectToJSObject((nsISupports) xpathResult);
	            JsVal jsVal;
	            do
	            {
	                while (
	                    !(jsVal = SpiderMonkey.JS_CallFunctionName(context.ContextPointer, jsObject, "iterateNext")).IsNull)
	                    yield return (jsVal.ToComObject(context.ContextPointer) as nsIDOMNode).Wrap(GeckoNode.Create);
	            } while (!jsVal.IsNull);
	        }
	    }

	    #endregion

		#region IEnumerable Members

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
		    var i = GetEnumerator();
            while (i.MoveNext())
		    {
                yield return i.Current;                
		    }
		        
		}

		#endregion
	}
}