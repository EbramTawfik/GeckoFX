namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozContactChangeEvent : WebIDLBase
    {
        
        public MozContactChangeEvent(nsISupports thisObject) : 
                base(thisObject)
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
