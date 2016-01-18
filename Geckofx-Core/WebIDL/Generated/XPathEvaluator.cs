namespace Gecko.WebIDL
{
    using System;
    
    
    public class XPathEvaluator : WebIDLBase
    {
        
        public XPathEvaluator(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports CreateExpression(string expression, nsISupports resolver)
        {
            return this.CallMethod<nsISupports>("createExpression", expression, resolver);
        }
        
        public nsIDOMNode CreateNSResolver(nsIDOMNode nodeResolver)
        {
            return this.CallMethod<nsIDOMNode>("createNSResolver", nodeResolver);
        }
        
        public nsISupports Evaluate(string expression, nsIDOMNode contextNode, nsISupports resolver, ushort type, object result)
        {
            return this.CallMethod<nsISupports>("evaluate", expression, contextNode, resolver, type, result);
        }
    }
}
