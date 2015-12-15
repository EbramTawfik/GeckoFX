namespace Gecko.WebIDL
{
    using System;
    
    
    public class SmsMessage : WebIDLBase
    {
        
        public SmsMessage(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString Type
        {
            get
            {
                return this.GetProperty<nsAString>("type");
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
        
        public nsAString IccId
        {
            get
            {
                return this.GetProperty<nsAString>("iccId");
            }
        }
        
        public nsAString Delivery
        {
            get
            {
                return this.GetProperty<nsAString>("delivery");
            }
        }
        
        public nsAString DeliveryStatus
        {
            get
            {
                return this.GetProperty<nsAString>("deliveryStatus");
            }
        }
        
        public nsAString Sender
        {
            get
            {
                return this.GetProperty<nsAString>("sender");
            }
        }
        
        public nsAString Receiver
        {
            get
            {
                return this.GetProperty<nsAString>("receiver");
            }
        }
        
        public nsAString Body
        {
            get
            {
                return this.GetProperty<nsAString>("body");
            }
        }
        
        public nsAString MessageClass
        {
            get
            {
                return this.GetProperty<nsAString>("messageClass");
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
