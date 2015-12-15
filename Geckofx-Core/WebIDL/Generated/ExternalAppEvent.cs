namespace Gecko.WebIDL
{
    using System;
    
    
    public class ExternalAppEvent : WebIDLBase
    {
        
        public ExternalAppEvent(nsISupports thisObject) : 
                base(thisObject)
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
