namespace Gecko.WebIDL
{
    using System;
    
    
    public class MediaKeyMessageEvent : WebIDLBase
    {
        
        public MediaKeyMessageEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
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
