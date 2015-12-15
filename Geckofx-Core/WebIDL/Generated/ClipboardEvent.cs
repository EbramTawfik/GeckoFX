namespace Gecko.WebIDL
{
    using System;
    
    
    public class ClipboardEvent : WebIDLBase
    {
        
        public ClipboardEvent(nsISupports thisObject) : 
                base(thisObject)
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
