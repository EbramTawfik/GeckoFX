namespace Gecko.WebIDL
{
    using System;
    
    
    public class PopupBlockedEvent : WebIDLBase
    {
        
        public PopupBlockedEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsIDOMWindow RequestingWindow
        {
            get
            {
                return this.GetProperty<nsIDOMWindow>("requestingWindow");
            }
        }
        
        public nsISupports PopupWindowURI
        {
            get
            {
                return this.GetProperty<nsISupports>("popupWindowURI");
            }
        }
        
        public string PopupWindowName
        {
            get
            {
                return this.GetProperty<string>("popupWindowName");
            }
        }
        
        public string PopupWindowFeatures
        {
            get
            {
                return this.GetProperty<string>("popupWindowFeatures");
            }
        }
    }
}
