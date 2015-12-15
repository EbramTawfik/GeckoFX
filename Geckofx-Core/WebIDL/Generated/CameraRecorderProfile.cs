namespace Gecko.WebIDL
{
    using System;
    
    
    public class CameraRecorderProfile : WebIDLBase
    {
        
        public CameraRecorderProfile(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString Name
        {
            get
            {
                return this.GetProperty<nsAString>("name");
            }
        }
        
        public nsAString ContainerFormat
        {
            get
            {
                return this.GetProperty<nsAString>("containerFormat");
            }
        }
        
        public nsAString MimeType
        {
            get
            {
                return this.GetProperty<nsAString>("mimeType");
            }
        }
        
        public nsISupports Audio
        {
            get
            {
                return this.GetProperty<nsISupports>("audio");
            }
        }
        
        public nsISupports Video
        {
            get
            {
                return this.GetProperty<nsISupports>("video");
            }
        }
    }
}
