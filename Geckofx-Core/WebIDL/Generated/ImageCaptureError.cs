namespace Gecko.WebIDL
{
    using System;
    
    
    public class ImageCaptureError : WebIDLBase
    {
        
        public ImageCaptureError(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public ushort Code
        {
            get
            {
                return this.GetProperty<ushort>("code");
            }
        }
        
        public nsAString Message
        {
            get
            {
                return this.GetProperty<nsAString>("message");
            }
        }
    }
}
