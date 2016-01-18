namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozVoicemailStatus : WebIDLBase
    {
        
        public MozVoicemailStatus(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
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
        
        public string ReturnNumber
        {
            get
            {
                return this.GetProperty<string>("returnNumber");
            }
        }
        
        public string ReturnMessage
        {
            get
            {
                return this.GetProperty<string>("returnMessage");
            }
        }
    }
}
