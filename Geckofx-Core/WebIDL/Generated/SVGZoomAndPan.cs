namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGZoomAndPan : WebIDLBase
    {
        
        public SVGZoomAndPan(nsISupports thisObject) : 
                base(thisObject)
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
