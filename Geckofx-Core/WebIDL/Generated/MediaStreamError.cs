namespace Gecko.WebIDL
{
    using System;
    
    
    public class MediaStreamError : WebIDLBase
    {
        
        public MediaStreamError(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString Name
        {
            get
            {
                return this.GetProperty<nsAString>("name");
            }
        }
        
        public nsAString Message
        {
            get
            {
                return this.GetProperty<nsAString>("message");
            }
        }
        
        public nsAString Constraint
        {
            get
            {
                return this.GetProperty<nsAString>("constraint");
            }
        }
    }
}
