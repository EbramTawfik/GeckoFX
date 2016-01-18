namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGZoomAndPan : WebIDLBase
    {
        
        public SVGZoomAndPan(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public ushort ZoomAndPan
        {
            get
            {
                return this.GetProperty<ushort>("zoomAndPan");
            }
            set
            {
                this.SetProperty("zoomAndPan", value);
            }
        }
    }
}
