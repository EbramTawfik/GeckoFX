namespace Gecko.WebIDL
{
    using System;
    
    
    public class ClipboardEvent : WebIDLBase
    {
        
        public ClipboardEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports ClipboardData
        {
            get
            {
                return this.GetProperty<nsISupports>("clipboardData");
            }
        }
    }
}
