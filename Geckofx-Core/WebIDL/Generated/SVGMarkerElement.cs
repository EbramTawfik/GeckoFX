namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGMarkerElement : WebIDLBase
    {
        
        public SVGMarkerElement(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports RefX
        {
            get
            {
                return this.GetProperty<nsISupports>("refX");
            }
        }
        
        public nsISupports RefY
        {
            get
            {
                return this.GetProperty<nsISupports>("refY");
            }
        }
        
        public nsISupports MarkerUnits
        {
            get
            {
                return this.GetProperty<nsISupports>("markerUnits");
            }
        }
        
        public nsISupports MarkerWidth
        {
            get
            {
                return this.GetProperty<nsISupports>("markerWidth");
            }
        }
        
        public nsISupports MarkerHeight
        {
            get
            {
                return this.GetProperty<nsISupports>("markerHeight");
            }
        }
        
        public nsISupports OrientType
        {
            get
            {
                return this.GetProperty<nsISupports>("orientType");
            }
        }
        
        public nsISupports OrientAngle
        {
            get
            {
                return this.GetProperty<nsISupports>("orientAngle");
            }
        }
        
        public void SetOrientToAuto()
        {
            this.CallVoidMethod("setOrientToAuto");
        }
        
        public void SetOrientToAngle(nsISupports angle)
        {
            this.CallVoidMethod("setOrientToAngle", angle);
        }
    }
}
