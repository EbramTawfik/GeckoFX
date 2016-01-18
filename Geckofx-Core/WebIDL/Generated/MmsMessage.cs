namespace Gecko.WebIDL
{
    using System;
    
    
    public class MmsMessage : WebIDLBase
    {
        
        public MmsMessage(nsIDOMWindow globalWindow, nsISupports thisObject) : 
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
        
        public object[] DeliveryInfo
        {
            get
            {
                return this.GetProperty<object[]>("deliveryInfo");
            }
        }
        
        public string Sender
        {
            get
            {
                return this.GetProperty<string>("sender");
            }
        }
        
        public string[] Receivers
        {
            get
            {
                return this.GetProperty<string[]>("receivers");
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
        
        public string Subject
        {
            get
            {
                return this.GetProperty<string>("subject");
            }
        }
        
        public string Smil
        {
            get
            {
                return this.GetProperty<string>("smil");
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
