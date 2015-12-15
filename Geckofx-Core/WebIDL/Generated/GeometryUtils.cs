namespace Gecko.WebIDL
{
    using System;
    
    
    public class GeometryUtils : WebIDLBase
    {
        
        public GeometryUtils(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports[] GetBoxQuads(object options)
        {
            return this.CallMethod<nsISupports[]>("getBoxQuads", options);
        }
        
        public nsISupports ConvertQuadFromNode(nsISupports quad, WebIDLUnion<nsIDOMText,nsIDOMElement,nsIDOMDocument> from, object options)
        {
            return this.CallMethod<nsISupports>("convertQuadFromNode", quad, from, options);
        }
        
        public nsISupports ConvertRectFromNode(nsISupports rect, WebIDLUnion<nsIDOMText,nsIDOMElement,nsIDOMDocument> from, object options)
        {
            return this.CallMethod<nsISupports>("convertRectFromNode", rect, from, options);
        }
        
        public nsISupports ConvertPointFromNode(object point, WebIDLUnion<nsIDOMText,nsIDOMElement,nsIDOMDocument> from, object options)
        {
            return this.CallMethod<nsISupports>("convertPointFromNode", point, from, options);
        }
    }
}
