namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGAltGlyphElement : WebIDLBase
    {
        
        public SVGAltGlyphElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string GlyphRef
        {
            get
            {
                return this.GetProperty<string>("glyphRef");
            }
            set
            {
                this.SetProperty("glyphRef", value);
            }
        }
        
        public string Format
        {
            get
            {
                return this.GetProperty<string>("format");
            }
            set
            {
                this.SetProperty("format", value);
            }
        }
    }
}
