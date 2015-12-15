namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGZoomEvent : WebIDLBase
    {
        
        public SVGZoomEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public float PreviousScale
        {
            get
            {
                return this.GetProperty<float>("previousScale");
            }
        }
        
        public nsISupports PreviousTranslate
        {
            get
            {
                return this.GetProperty<nsISupports>("previousTranslate");
            }
        }
        
        public float NewScale
        {
            get
            {
                return this.GetProperty<float>("newScale");
            }
        }
        
        public nsISupports NewTranslate
        {
            get
            {
                return this.GetProperty<nsISupports>("newTranslate");
            }
        }
    }
}
