namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozVoicemail : WebIDLBase
    {
        
        public MozVoicemail(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports GetStatus(uint serviceId)
        {
            return this.CallMethod<nsISupports>("getStatus", serviceId);
        }
        
        public nsAString GetNumber(uint serviceId)
        {
            return this.CallMethod<nsAString>("getNumber", serviceId);
        }
        
        public nsAString GetDisplayName(uint serviceId)
        {
            return this.CallMethod<nsAString>("getDisplayName", serviceId);
        }
    }
}
