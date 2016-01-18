namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozContactChangeEvent : WebIDLBase
    {
        
        public MozContactChangeEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string ContactID
        {
            get
            {
                return this.GetProperty<string>("contactID");
            }
        }
        
        public string Reason
        {
            get
            {
                return this.GetProperty<string>("reason");
            }
        }
    }
}
