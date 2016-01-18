namespace Gecko.WebIDL
{
    using System;
    
    
    public class ExternalAppEvent : WebIDLBase
    {
        
        public ExternalAppEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString Data
        {
            get
            {
                return this.GetProperty<nsAString>("data");
            }
        }
    }
}
