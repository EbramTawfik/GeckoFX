namespace Gecko.WebIDL
{
    using System;
    
    
    public class XPathEvaluator : WebIDLBase
    {
        
        public XPathEvaluator(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports CreateExpression(nsAString expression, nsISupports resolver)
        {
            return this.CallMethod<nsISupports>("createExpression", expression, resolver);
        }
        
        public nsIDOMNode CreateNSResolver(nsIDOMNode nodeResolver)
        {
            return this.CallMethod<nsIDOMNode>("createNSResolver", nodeResolver);
        }
        
        public nsISupports Evaluate(nsAString expression, nsIDOMNode contextNode, nsISupports resolver, ushort type, object result)
        {
            return this.CallMethod<nsISupports>("evaluate", expression, contextNode, resolver, type, result);
        }
    }
}
