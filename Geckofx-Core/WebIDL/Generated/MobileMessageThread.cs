namespace Gecko.WebIDL
{
    using System;
    
    
    public class MobileMessageThread : WebIDLBase
    {
        
        public MobileMessageThread(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public ulong Id
        {
            get
            {
                return this.GetProperty<ulong>("id");
            }
        }
        
        public string LastMessageSubject
        {
            get
            {
                return this.GetProperty<string>("lastMessageSubject");
            }
        }
        
        public string Body
        {
            get
            {
                return this.GetProperty<string>("body");
            }
        }
        
        public ulong UnreadCount
        {
            get
            {
                return this.GetProperty<ulong>("unreadCount");
            }
        }
        
        public string[] Participants
        {
            get
            {
                return this.GetProperty<string[]>("participants");
            }
        }
        
        public nsISupports Timestamp
        {
            get
            {
                return this.GetProperty<nsISupports>("timestamp");
            }
        }
        
        public string LastMessageType
        {
            get
            {
                return this.GetProperty<string>("lastMessageType");
            }
        }
    }
}
