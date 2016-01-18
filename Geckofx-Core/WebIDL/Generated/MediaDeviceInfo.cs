namespace Gecko.WebIDL
{
    using System;
    
    
    public class MediaDeviceInfo : WebIDLBase
    {
        
        public MediaDeviceInfo(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string DeviceId
        {
            get
            {
                return this.GetProperty<string>("deviceId");
            }
        }
        
        public MediaDeviceKind Kind
        {
            get
            {
                return this.GetProperty<MediaDeviceKind>("kind");
            }
        }
        
        public string Label
        {
            get
            {
                return this.GetProperty<string>("label");
            }
        }
        
        public string GroupId
        {
            get
            {
                return this.GetProperty<string>("groupId");
            }
        }
    }
}
