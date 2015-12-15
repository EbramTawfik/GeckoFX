namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGFESpotLightElement : WebIDLBase
    {
        
        public SVGFESpotLightElement(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports X
        {
            get
            {
                return this.GetProperty<nsISupports>("x");
            }
        }
        
        public nsISupports Y
        {
            get
            {
                return this.GetProperty<nsISupports>("y");
            }
        }
        
        public nsISupports Z
        {
            get
            {
                return this.GetProperty<nsISupports>("z");
            }
        }
        
        public nsISupports PointsAtX
        {
            get
            {
                return this.GetProperty<nsISupports>("pointsAtX");
            }
        }
        
        public nsISupports PointsAtY
        {
            get
            {
                return this.GetProperty<nsISupports>("pointsAtY");
            }
        }
        
        public nsISupports PointsAtZ
        {
            get
            {
                return this.GetProperty<nsISupports>("pointsAtZ");
            }
        }
        
        public nsISupports SpecularExponent
        {
            get
            {
                return this.GetProperty<nsISupports>("specularExponent");
            }
        }
        
        public nsISupports LimitingConeAngle
        {
            get
            {
                return this.GetProperty<nsISupports>("limitingConeAngle");
            }
        }
    }
}
