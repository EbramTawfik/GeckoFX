namespace Gecko.WebIDL
{
    using System;
    
    
    public class ImageBitmapFactories : WebIDLBase
    {
        
        public ImageBitmapFactories(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public Promise < nsISupports > CreateImageBitmap(WebIDLUnion<nsIDOMHTMLImageElement,nsISupports,nsIDOMHTMLCanvasElement> aImage)
        {
            return this.CallMethod<Promise < nsISupports >>("createImageBitmap", aImage);
        }
        
        public Promise < nsISupports > CreateImageBitmap(WebIDLUnion<nsIDOMHTMLImageElement,nsISupports,nsIDOMHTMLCanvasElement> aImage, int aSx, int aSy, int aSw, int aSh)
        {
            return this.CallMethod<Promise < nsISupports >>("createImageBitmap", aImage, aSx, aSy, aSw, aSh);
        }
    }
}
