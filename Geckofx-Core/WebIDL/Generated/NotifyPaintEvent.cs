namespace Gecko.WebIDL
{
    using System;
    
    
    public class NotifyPaintEvent : WebIDLBase
    {
        
        public NotifyPaintEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports ClientRects
        {
            get
            {
                return this.GetProperty<nsISupports>("clientRects");
            }
        }
        
        public nsISupports BoundingClientRect
        {
            get
            {
                return this.GetProperty<nsISupports>("boundingClientRect");
            }
        }
        
        public nsISupports PaintRequests
        {
            get
            {
                return this.GetProperty<nsISupports>("paintRequests");
            }
        }
    }
}
