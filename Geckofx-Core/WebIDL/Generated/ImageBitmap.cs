namespace Gecko.WebIDL
{
    using System;
    
    
    public class ImageBitmap : WebIDLBase
    {
        
        public ImageBitmap(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public uint Width
        {
            get
            {
                return this.GetProperty<uint>("width");
            }
        }
        
        public uint Height
        {
            get
            {
                return this.GetProperty<uint>("height");
            }
        }
    }
}
