namespace Gecko.WebIDL
{
    using System;
    
    
    public class XULDocument : WebIDLBase
    {
        
        public XULDocument(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsIDOMNode PopupNode
        {
            get
            {
                return this.GetProperty<nsIDOMNode>("popupNode");
            }
            set
            {
                this.SetProperty("popupNode", value);
            }
        }
        
        public nsIDOMNode PopupRangeParent
        {
            get
            {
                return this.GetProperty<nsIDOMNode>("popupRangeParent");
            }
        }
        
        public int PopupRangeOffset
        {
            get
            {
                return this.GetProperty<int>("popupRangeOffset");
            }
        }
        
        public nsIDOMNode TooltipNode
        {
            get
            {
                return this.GetProperty<nsIDOMNode>("tooltipNode");
            }
            set
            {
                this.SetProperty("tooltipNode", value);
            }
        }
        
        public nsISupports CommandDispatcher
        {
            get
            {
                return this.GetProperty<nsISupports>("commandDispatcher");
            }
        }
        
        public int Width
        {
            get
            {
                return this.GetProperty<int>("width");
            }
        }
        
        public int Height
        {
            get
            {
                return this.GetProperty<int>("height");
            }
        }
        
        public nsISupports GetElementsByAttribute(string name, string value)
        {
            return this.CallMethod<nsISupports>("getElementsByAttribute", name, value);
        }
        
        public nsISupports GetElementsByAttributeNS(string namespaceURI, string name, string value)
        {
            return this.CallMethod<nsISupports>("getElementsByAttributeNS", namespaceURI, name, value);
        }
        
        public void AddBroadcastListenerFor(nsIDOMElement broadcaster, nsIDOMElement observer, string attr)
        {
            this.CallVoidMethod("addBroadcastListenerFor", broadcaster, observer, attr);
        }
        
        public void RemoveBroadcastListenerFor(nsIDOMElement broadcaster, nsIDOMElement observer, string attr)
        {
            this.CallVoidMethod("removeBroadcastListenerFor", broadcaster, observer, attr);
        }
        
        public void Persist(string id, string attr)
        {
            this.CallVoidMethod("persist", id, attr);
        }
        
        public nsISupports GetBoxObjectFor(nsIDOMElement element)
        {
            return this.CallMethod<nsISupports>("getBoxObjectFor", element);
        }
        
        public void LoadOverlay(string url, nsISupports observer)
        {
            this.CallVoidMethod("loadOverlay", url, observer);
        }
    }
}
