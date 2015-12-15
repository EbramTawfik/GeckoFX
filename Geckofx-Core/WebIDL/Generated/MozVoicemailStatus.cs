namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozVoicemailStatus : WebIDLBase
    {
        
        public MozVoicemailStatus(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public uint ServiceId
        {
            get
            {
                return this.GetProperty<uint>("serviceId");
            }
        }
        
        public bool HasMessages
        {
            get
            {
                return this.GetProperty<bool>("hasMessages");
            }
        }
        
        public int MessageCount
        {
            get
            {
                return this.GetProperty<int>("messageCount");
            }
        }
        
        public nsAString ReturnNumber
        {
            get
            {
                return this.GetProperty<nsAString>("returnNumber");
            }
        }
        
        public nsAString ReturnMessage
        {
            get
            {
                return this.GetProperty<nsAString>("returnMessage");
            }
        }
    }
}
