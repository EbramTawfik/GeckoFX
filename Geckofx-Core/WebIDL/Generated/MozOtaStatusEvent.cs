namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozOtaStatusEvent : WebIDLBase
    {
        
        public MozOtaStatusEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Status
        {
            get
            {
                return this.GetProperty<string>("status");
            }
        }
    }
}
