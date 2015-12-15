namespace Gecko.WebIDL
{
    using System;
    
    
    public class XULDocument : WebIDLBase
    {
        
        public XULDocument(nsISupports thisObject) : 
                base(thisObject)
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
        
        public nsISupports GetElementsByAttribute(nsAString name, nsAString value)
        {
            return this.CallMethod<nsISupports>("getElementsByAttribute", name, value);
        }
        
        public nsISupports GetElementsByAttributeNS(nsAString namespaceURI, nsAString name, nsAString value)
        {
            return this.CallMethod<nsISupports>("getElementsByAttributeNS", namespaceURI, name, value);
        }
        
        public void AddBroadcastListenerFor(nsIDOMElement broadcaster, nsIDOMElement observer, nsAString attr)
        {
            this.CallVoidMethod("addBroadcastListenerFor", broadcaster, observer, attr);
        }
        
        public void RemoveBroadcastListenerFor(nsIDOMElement broadcaster, nsIDOMElement observer, nsAString attr)
        {
            this.CallVoidMethod("removeBroadcastListenerFor", broadcaster, observer, attr);
        }
        
        public void Persist(nsAString id, nsAString attr)
        {
            this.CallVoidMethod("persist", id, attr);
        }
        
        public nsISupports GetBoxObjectFor(nsIDOMElement element)
        {
            return this.CallMethod<nsISupports>("getBoxObjectFor", element);
        }
        
        public void LoadOverlay(nsAString url, nsISupports observer)
        {
            this.CallVoidMethod("loadOverlay", url, observer);
        }
    }
}
