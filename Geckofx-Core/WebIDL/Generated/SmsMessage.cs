namespace Gecko.WebIDL
{
    using System;
    
    
    public class SmsMessage : WebIDLBase
    {
        
        public SmsMessage(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Type
        {
            get
            {
                return this.GetProperty<string>("type");
            }
        }
        
        public int Id
        {
            get
            {
                return this.GetProperty<int>("id");
            }
        }
        
        public ulong ThreadId
        {
            get
            {
                return this.GetProperty<ulong>("threadId");
            }
        }
        
        public string IccId
        {
            get
            {
                return this.GetProperty<string>("iccId");
            }
        }
        
        public string Delivery
        {
            get
            {
                return this.GetProperty<string>("delivery");
            }
        }
        
        public string DeliveryStatus
        {
            get
            {
                return this.GetProperty<string>("deliveryStatus");
            }
        }
        
        public string Sender
        {
            get
            {
                return this.GetProperty<string>("sender");
            }
        }
        
        public string Receiver
        {
            get
            {
                return this.GetProperty<string>("receiver");
            }
        }
        
        public string Body
        {
            get
            {
                return this.GetProperty<string>("body");
            }
        }
        
        public string MessageClass
        {
            get
            {
                return this.GetProperty<string>("messageClass");
            }
        }
        
        public nsISupports Timestamp
        {
            get
            {
                return this.GetProperty<nsISupports>("timestamp");
            }
        }
        
        public nsISupports SentTimestamp
        {
            get
            {
                return this.GetProperty<nsISupports>("sentTimestamp");
            }
        }
        
        public nsISupports DeliveryTimestamp
        {
            get
            {
                return this.GetProperty<nsISupports>("deliveryTimestamp");
            }
        }
        
        public bool Read
        {
            get
            {
                return this.GetProperty<bool>("read");
            }
        }
    }
}
