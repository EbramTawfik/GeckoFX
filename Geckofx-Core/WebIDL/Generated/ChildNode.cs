namespace Gecko.WebIDL
{
    using System;
    
    
    public class ChildNode : WebIDLBase
    {
        
        public ChildNode(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public void Remove()
        {
            this.CallVoidMethod("remove");
        }
    }
}
