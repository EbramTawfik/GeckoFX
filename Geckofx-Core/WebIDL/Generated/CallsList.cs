namespace Gecko.WebIDL
{
    using System;
    
    
    public class CallsList : WebIDLBase
    {
        
        public CallsList(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public uint Length
        {
            get
            {
                return this.GetProperty<uint>("length");
            }
        }
    }
}
