namespace Gecko.WebIDL
{
    using System;
    
    
    public class CameraRecorderProfile : WebIDLBase
    {
        
        public CameraRecorderProfile(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Name
        {
            get
            {
                return this.GetProperty<string>("name");
            }
        }
        
        public string ContainerFormat
        {
            get
            {
                return this.GetProperty<string>("containerFormat");
            }
        }
        
        public string MimeType
        {
            get
            {
                return this.GetProperty<string>("mimeType");
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
