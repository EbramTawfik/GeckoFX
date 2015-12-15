namespace Gecko.WebIDL
{
    using System;
    
    
    public class CameraConfigurationEvent : WebIDLBase
    {
        
        public CameraConfigurationEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public CameraMode Mode
        {
            get
            {
                return this.GetProperty<CameraMode>("mode");
            }
        }
        
        public nsAString RecorderProfile
        {
            get
            {
                return this.GetProperty<nsAString>("recorderProfile");
            }
        }
        
        public nsISupports PreviewSize
        {
            get
            {
                return this.GetProperty<nsISupports>("previewSize");
            }
        }
        
        public nsISupports PictureSize
        {
            get
            {
                return this.GetProperty<nsISupports>("pictureSize");
            }
        }
    }
}
