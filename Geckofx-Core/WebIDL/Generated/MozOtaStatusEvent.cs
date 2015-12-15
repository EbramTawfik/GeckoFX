namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozOtaStatusEvent : WebIDLBase
    {
        
        public MozOtaStatusEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString Status
        {
            get
            {
                return this.GetProperty<nsAString>("status");
            }
        }
    }
}
