namespace Gecko.WebIDL
{
    using System;
    
    
    public class WindowProxy : WebIDLBase
    {
        
        public WindowProxy(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
    }
}
