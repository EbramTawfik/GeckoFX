namespace Gecko.WebIDL
{
    using System;
    
    
    public class ImageData : WebIDLBase
    {
        
        public ImageData(nsIDOMWindow globalWindow, nsISupports thisObject) : 
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
        
        public IntPtr Data
        {
            get
            {
                return this.GetProperty<IntPtr>("data");
            }
        }
    }
}
