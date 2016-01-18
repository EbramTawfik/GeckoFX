namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGAltGlyphElement : WebIDLBase
    {
        
        public SVGAltGlyphElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString GlyphRef
        {
            get
            {
                return this.GetProperty<nsAString>("glyphRef");
            }
            set
            {
                this.SetProperty("glyphRef", value);
            }
        }
        
        public nsAString Format
        {
            get
            {
                return this.GetProperty<nsAString>("format");
            }
            set
            {
                this.SetProperty("format", value);
            }
        }
    }
}
