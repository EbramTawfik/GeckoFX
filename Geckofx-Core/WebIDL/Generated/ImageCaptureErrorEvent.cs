namespace Gecko.WebIDL
{
    using System;
    
    
    public class ImageCaptureErrorEvent : WebIDLBase
    {
        
        public ImageCaptureErrorEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports ImageCaptureError
        {
            get
            {
                return this.GetProperty<nsISupports>("imageCaptureError");
            }
        }
    }
}
