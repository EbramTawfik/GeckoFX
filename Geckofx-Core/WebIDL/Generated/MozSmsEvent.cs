namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozSmsEvent : WebIDLBase
    {
        
        public MozSmsEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports Message
        {
            get
            {
                return this.GetProperty<nsISupports>("message");
            }
        }
    }
}
