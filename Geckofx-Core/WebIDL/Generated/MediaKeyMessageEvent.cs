namespace Gecko.WebIDL
{
    using System;
    
    
    public class MediaKeyMessageEvent : WebIDLBase
    {
        
        public MediaKeyMessageEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public MediaKeyMessageType MessageType
        {
            get
            {
                return this.GetProperty<MediaKeyMessageType>("messageType");
            }
        }
        
        public IntPtr Message
        {
            get
            {
                return this.GetProperty<IntPtr>("message");
            }
        }
    }
}
