namespace Gecko.WebIDL
{
    using System;
    
    
    public class CameraConfigurationEvent : WebIDLBase
    {
        
        public CameraConfigurationEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public CameraMode Mode
        {
            get
            {
                return this.GetProperty<CameraMode>("mode");
            }
        }
        
        public string RecorderProfile
        {
            get
            {
                return this.GetProperty<string>("recorderProfile");
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
