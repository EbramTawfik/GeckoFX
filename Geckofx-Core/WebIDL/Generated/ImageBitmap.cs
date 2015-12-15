namespace Gecko.WebIDL
{
    using System;
    
    
    public class ImageBitmap : WebIDLBase
    {
        
        public ImageBitmap(nsISupports thisObject) : 
                base(thisObject)
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
