namespace Gecko.WebIDL
{
    using System;
    
    
    public class MmsMessage : WebIDLBase
    {
        
        public MmsMessage(nsISupports thisObject) : 
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
        
        public object[] DeliveryInfo
        {
            get
            {
                return this.GetProperty<object[]>("deliveryInfo");
            }
        }
        
        public nsAString Sender
        {
            get
            {
                return this.GetProperty<nsAString>("sender");
            }
        }
        
        public nsAString[] Receivers
        {
            get
            {
                return this.GetProperty<nsAString[]>("receivers");
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
        
        public bool Read
        {
            get
            {
                return this.GetProperty<bool>("read");
            }
        }
        
        public nsAString Subject
        {
            get
            {
                return this.GetProperty<nsAString>("subject");
            }
        }
        
        public nsAString Smil
        {
            get
            {
                return this.GetProperty<nsAString>("smil");
            }
        }
        
        public object[] Attachments
        {
            get
            {
                return this.GetProperty<object[]>("attachments");
            }
        }
        
        public nsISupports ExpiryDate
        {
            get
            {
                return this.GetProperty<nsISupports>("expiryDate");
            }
        }
        
        public bool ReadReportRequested
        {
            get
            {
                return this.GetProperty<bool>("readReportRequested");
            }
        }
    }
}
