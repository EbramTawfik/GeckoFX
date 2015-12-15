namespace Gecko.WebIDL
{
    using System;
    
    
    public class MediaDeviceInfo : WebIDLBase
    {
        
        public MediaDeviceInfo(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString DeviceId
        {
            get
            {
                return this.GetProperty<nsAString>("deviceId");
            }
        }
        
        public MediaDeviceKind Kind
        {
            get
            {
                return this.GetProperty<MediaDeviceKind>("kind");
            }
        }
        
        public nsAString Label
        {
            get
            {
                return this.GetProperty<nsAString>("label");
            }
        }
        
        public nsAString GroupId
        {
            get
            {
                return this.GetProperty<nsAString>("groupId");
            }
        }
    }
}
