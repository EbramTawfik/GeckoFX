namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozContactChangeEvent : WebIDLBase
    {
        
        public MozContactChangeEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString ContactID
        {
            get
            {
                return this.GetProperty<nsAString>("contactID");
            }
        }
        
        public nsAString Reason
        {
            get
            {
                return this.GetProperty<nsAString>("reason");
            }
        }
    }
}
