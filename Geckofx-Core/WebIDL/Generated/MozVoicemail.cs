namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozVoicemail : WebIDLBase
    {
        
        public MozVoicemail(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports GetStatus()
        {
            return this.CallMethod<nsISupports>("getStatus");
        }
        
        public nsISupports GetStatus(uint serviceId)
        {
            return this.CallMethod<nsISupports>("getStatus", serviceId);
        }
        
        public nsAString GetNumber()
        {
            return this.CallMethod<nsAString>("getNumber");
        }
        
        public nsAString GetNumber(uint serviceId)
        {
            return this.CallMethod<nsAString>("getNumber", serviceId);
        }
        
        public nsAString GetDisplayName()
        {
            return this.CallMethod<nsAString>("getDisplayName");
        }
        
        public nsAString GetDisplayName(uint serviceId)
        {
            return this.CallMethod<nsAString>("getDisplayName", serviceId);
        }
    }
}
