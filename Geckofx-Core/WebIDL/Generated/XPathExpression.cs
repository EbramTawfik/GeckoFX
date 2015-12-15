namespace Gecko.WebIDL
{
    using System;
    
    
    public class XPathExpression : WebIDLBase
    {
        
        public XPathExpression(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports Evaluate(nsIDOMNode contextNode, ushort type, object result)
        {
            return this.CallMethod<nsISupports>("evaluate", contextNode, type, result);
        }
        
        public nsISupports EvaluateWithContext(nsIDOMNode contextNode, uint contextPosition, uint contextSize, ushort type, object result)
        {
            return this.CallMethod<nsISupports>("evaluateWithContext", contextNode, contextPosition, contextSize, type, result);
        }
    }
}
