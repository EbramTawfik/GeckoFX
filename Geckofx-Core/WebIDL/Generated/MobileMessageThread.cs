namespace Gecko.WebIDL
{
    using System;
    
    
    public class MobileMessageThread : WebIDLBase
    {
        
        public MobileMessageThread(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public ulong Id
        {
            get
            {
                return this.GetProperty<ulong>("id");
            }
        }
        
        public nsAString LastMessageSubject
        {
            get
            {
                return this.GetProperty<nsAString>("lastMessageSubject");
            }
        }
        
        public nsAString Body
        {
            get
            {
                return this.GetProperty<nsAString>("body");
            }
        }
        
        public ulong UnreadCount
        {
            get
            {
                return this.GetProperty<ulong>("unreadCount");
            }
        }
        
        public nsAString[] Participants
        {
            get
            {
                return this.GetProperty<nsAString[]>("participants");
            }
        }
        
        public nsISupports Timestamp
        {
            get
            {
                return this.GetProperty<nsISupports>("timestamp");
            }
        }
        
        public nsAString LastMessageType
        {
            get
            {
                return this.GetProperty<nsAString>("lastMessageType");
            }
        }
    }
}
