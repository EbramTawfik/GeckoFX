namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGFETurbulenceElement : WebIDLBase
    {
        
        public SVGFETurbulenceElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports BaseFrequencyX
        {
            get
            {
                return this.GetProperty<nsISupports>("baseFrequencyX");
            }
        }
        
        public nsISupports BaseFrequencyY
        {
            get
            {
                return this.GetProperty<nsISupports>("baseFrequencyY");
            }
        }
        
        public nsISupports NumOctaves
        {
            get
            {
                return this.GetProperty<nsISupports>("numOctaves");
            }
        }
        
        public nsISupports Seed
        {
            get
            {
                return this.GetProperty<nsISupports>("seed");
            }
        }
        
        public nsISupports StitchTiles
        {
            get
            {
                return this.GetProperty<nsISupports>("stitchTiles");
            }
        }
        
        public nsISupports Type
        {
            get
            {
                return this.GetProperty<nsISupports>("type");
            }
        }
    }
}
