namespace Gecko.WebIDL
{
    using System;
    
    
    public class PopupBlockedEvent : WebIDLBase
    {
        
        public PopupBlockedEvent(nsISupports thisObject) : 
                base(thisObject)
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
        
        public nsAString PopupWindowName
        {
            get
            {
                return this.GetProperty<nsAString>("popupWindowName");
            }
        }
        
        public nsAString PopupWindowFeatures
        {
            get
            {
                return this.GetProperty<nsAString>("popupWindowFeatures");
            }
        }
    }
}
