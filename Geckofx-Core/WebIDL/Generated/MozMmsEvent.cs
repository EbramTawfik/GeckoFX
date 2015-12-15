namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozMmsEvent : WebIDLBase
    {
        
        public MozMmsEvent(nsISupports thisObject) : 
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
