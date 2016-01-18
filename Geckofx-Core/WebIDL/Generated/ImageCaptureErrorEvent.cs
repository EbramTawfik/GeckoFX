namespace Gecko.WebIDL
{
    using System;
    
    
    public class ImageCaptureErrorEvent : WebIDLBase
    {
        
        public ImageCaptureErrorEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
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
