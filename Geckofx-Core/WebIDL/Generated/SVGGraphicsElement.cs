namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGGraphicsElement : WebIDLBase
    {
        
        public SVGGraphicsElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Transform
        {
            get
            {
                return this.GetProperty<nsISupports>("transform");
            }
        }
        
        public nsISupports NearestViewportElement
        {
            get
            {
                return this.GetProperty<nsISupports>("nearestViewportElement");
            }
        }
        
        public nsISupports FarthestViewportElement
        {
            get
            {
                return this.GetProperty<nsISupports>("farthestViewportElement");
            }
        }
        
        public nsISupports GetBBox()
        {
            return this.CallMethod<nsISupports>("getBBox");
        }
        
        public nsISupports GetBBox(object aOptions)
        {
            return this.CallMethod<nsISupports>("getBBox", aOptions);
        }
        
        public nsISupports GetCTM()
        {
            return this.CallMethod<nsISupports>("getCTM");
        }
        
        public nsISupports GetScreenCTM()
        {
            return this.CallMethod<nsISupports>("getScreenCTM");
        }
        
        public nsISupports GetTransformToElement(nsISupports element)
        {
            return this.CallMethod<nsISupports>("getTransformToElement", element);
        }
    }
}
