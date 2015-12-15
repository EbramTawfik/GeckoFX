namespace Gecko.WebIDL
{
    using System;
    
    
    public class PresentationConnectionAvailableEvent : WebIDLBase
    {
        
        public PresentationConnectionAvailableEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports Connection
        {
            get
            {
                return this.GetProperty<nsISupports>("connection");
            }
        }
    }
}
