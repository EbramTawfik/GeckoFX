namespace Gecko.WebIDL
{
    using System;
    
    
    public class GeometryUtils : WebIDLBase
    {
        
        public GeometryUtils(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports[] GetBoxQuads()
        {
            return this.CallMethod<nsISupports[]>("getBoxQuads");
        }
        
        public nsISupports[] GetBoxQuads(object options)
        {
            return this.CallMethod<nsISupports[]>("getBoxQuads", options);
        }
        
        public nsISupports ConvertQuadFromNode(nsISupports quad, WebIDLUnion<nsIDOMText,nsIDOMElement,nsIDOMDocument> from)
        {
            return this.CallMethod<nsISupports>("convertQuadFromNode", quad, from);
        }
        
        public nsISupports ConvertQuadFromNode(nsISupports quad, WebIDLUnion<nsIDOMText,nsIDOMElement,nsIDOMDocument> from, object options)
        {
            return this.CallMethod<nsISupports>("convertQuadFromNode", quad, from, options);
        }
        
        public nsISupports ConvertRectFromNode(nsISupports rect, WebIDLUnion<nsIDOMText,nsIDOMElement,nsIDOMDocument> from)
        {
            return this.CallMethod<nsISupports>("convertRectFromNode", rect, from);
        }
        
        public nsISupports ConvertRectFromNode(nsISupports rect, WebIDLUnion<nsIDOMText,nsIDOMElement,nsIDOMDocument> from, object options)
        {
            return this.CallMethod<nsISupports>("convertRectFromNode", rect, from, options);
        }
        
        public nsISupports ConvertPointFromNode(object point, WebIDLUnion<nsIDOMText,nsIDOMElement,nsIDOMDocument> from)
        {
            return this.CallMethod<nsISupports>("convertPointFromNode", point, from);
        }
        
        public nsISupports ConvertPointFromNode(object point, WebIDLUnion<nsIDOMText,nsIDOMElement,nsIDOMDocument> from, object options)
        {
            return this.CallMethod<nsISupports>("convertPointFromNode", point, from, options);
        }
    }
}
