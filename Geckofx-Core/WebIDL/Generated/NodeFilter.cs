namespace Gecko.WebIDL
{
    using System;
    
    
    public class NodeFilter : WebIDLBase
    {
        
        public NodeFilter(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public ushort AcceptNode(nsIDOMNode node)
        {
            return this.CallMethod<ushort>("acceptNode", node);
        }
    }
}
