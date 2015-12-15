namespace Gecko.WebIDL
{
    using System;
    
    
    public class FontFaceSource : WebIDLBase
    {
        
        public FontFaceSource(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports Fonts
        {
            get
            {
                return this.GetProperty<nsISupports>("fonts");
            }
        }
    }
}
