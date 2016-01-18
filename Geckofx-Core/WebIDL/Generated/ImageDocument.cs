namespace Gecko.WebIDL
{
    using System;
    
    
    public class ImageDocument : WebIDLBase
    {
        
        public ImageDocument(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public bool ImageResizingEnabled
        {
            get
            {
                return this.GetProperty<bool>("imageResizingEnabled");
            }
        }
        
        public bool ImageIsOverflowing
        {
            get
            {
                return this.GetProperty<bool>("imageIsOverflowing");
            }
        }
        
        public bool ImageIsResized
        {
            get
            {
                return this.GetProperty<bool>("imageIsResized");
            }
        }
        
        public nsISupports ImageRequest
        {
            get
            {
                return this.GetProperty<nsISupports>("imageRequest");
            }
        }
        
        public void ShrinkToFit()
        {
            this.CallVoidMethod("shrinkToFit");
        }
        
        public void RestoreImage()
        {
            this.CallVoidMethod("restoreImage");
        }
        
        public void RestoreImageTo(int x, int y)
        {
            this.CallVoidMethod("restoreImageTo", x, y);
        }
        
        public void ToggleImageSize()
        {
            this.CallVoidMethod("toggleImageSize");
        }
    }
}
