namespace Gecko.WebIDL
{
    using System;
    
    
    public class CanvasCaptureMediaStream : WebIDLBase
    {
        
        public CanvasCaptureMediaStream(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsIDOMHTMLCanvasElement Canvas
        {
            get
            {
                return this.GetProperty<nsIDOMHTMLCanvasElement>("canvas");
            }
        }
        
        public void RequestFrame()
        {
            this.CallVoidMethod("requestFrame");
        }
    }
}
