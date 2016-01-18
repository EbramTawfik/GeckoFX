namespace Gecko.WebIDL
{
    using System;
    
    
    public class Presentation : WebIDLBase
    {
        
        public Presentation(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports DefaultRequest
        {
            get
            {
                return this.GetProperty<nsISupports>("defaultRequest");
            }
            set
            {
                this.SetProperty("defaultRequest", value);
            }
        }
        
        public nsISupports Receiver
        {
            get
            {
                return this.GetProperty<nsISupports>("receiver");
            }
        }
    }
}
