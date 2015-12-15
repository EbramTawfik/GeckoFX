namespace Gecko.WebIDL
{
    using System;
    
    
    public class CanvasCaptureMediaStream : WebIDLBase
    {
        
        public CanvasCaptureMediaStream(nsISupports thisObject) : 
                base(thisObject)
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
