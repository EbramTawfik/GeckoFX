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
        
        public string GetNumber()
        {
            return this.CallMethod<string>("getNumber");
        }
        
        public string GetNumber(uint serviceId)
        {
            return this.CallMethod<string>("getNumber", serviceId);
        }
        
        public string GetDisplayName()
        {
            return this.CallMethod<string>("getDisplayName");
        }
        
        public string GetDisplayName(uint serviceId)
        {
            return this.CallMethod<string>("getDisplayName", serviceId);
        }
    }
}
