namespace Gecko.WebIDL
{
    using System;
    
    
    public class PopupBoxObject : WebIDLBase
    {
        
        public PopupBoxObject(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public bool AutoPosition
        {
            get
            {
                return this.GetProperty<bool>("autoPosition");
            }
            set
            {
                this.SetProperty("autoPosition", value);
            }
        }
        
        public nsAString PopupState
        {
            get
            {
                return this.GetProperty<nsAString>("popupState");
            }
        }
        
        public nsIDOMNode TriggerNode
        {
            get
            {
                return this.GetProperty<nsIDOMNode>("triggerNode");
            }
        }
        
        public nsIDOMElement AnchorNode
        {
            get
            {
                return this.GetProperty<nsIDOMElement>("anchorNode");
            }
        }
        
        public nsAString AlignmentPosition
        {
            get
            {
                return this.GetProperty<nsAString>("alignmentPosition");
            }
        }
        
        public int AlignmentOffset
        {
            get
            {
                return this.GetProperty<int>("alignmentOffset");
            }
        }
        
        public void ShowPopup(nsIDOMElement srcContent, nsIDOMElement popupContent, int xpos, int ypos, nsAString popupType, nsAString anchorAlignment, nsAString popupAlignment)
        {
            this.CallVoidMethod("showPopup", srcContent, popupContent, xpos, ypos, popupType, anchorAlignment, popupAlignment);
        }
        
        public void HidePopup(bool cancel)
        {
            this.CallVoidMethod("hidePopup", cancel);
        }
        
        public void EnableKeyboardNavigator(bool enableKeyboardNavigator)
        {
            this.CallVoidMethod("enableKeyboardNavigator", enableKeyboardNavigator);
        }
        
        public void EnableRollup(bool enableRollup)
        {
            this.CallVoidMethod("enableRollup", enableRollup);
        }
        
        public void SetConsumeRollupEvent(uint consume)
        {
            this.CallVoidMethod("setConsumeRollupEvent", consume);
        }
        
        public void SizeTo(int width, int height)
        {
            this.CallVoidMethod("sizeTo", width, height);
        }
        
        public void MoveTo(int left, int top)
        {
            this.CallVoidMethod("moveTo", left, top);
        }
        
        public void OpenPopup(nsIDOMElement anchorElement, nsAString position, int x, int y, bool isContextMenu, bool attributesOverride, nsIDOMEvent triggerEvent)
        {
            this.CallVoidMethod("openPopup", anchorElement, position, x, y, isContextMenu, attributesOverride, triggerEvent);
        }
        
        public void OpenPopupAtScreen(int x, int y, bool isContextMenu, nsIDOMEvent triggerEvent)
        {
            this.CallVoidMethod("openPopupAtScreen", x, y, isContextMenu, triggerEvent);
        }
        
        public void OpenPopupAtScreenRect(nsAString position, int x, int y, int width, int height, bool isContextMenu, bool attributesOverride, nsIDOMEvent triggerEvent)
        {
            this.CallVoidMethod("openPopupAtScreenRect", position, x, y, width, height, isContextMenu, attributesOverride, triggerEvent);
        }
        
        public nsISupports GetOuterScreenRect()
        {
            return this.CallMethod<nsISupports>("getOuterScreenRect");
        }
        
        public void MoveToAnchor(nsIDOMElement anchorElement, nsAString position, int x, int y, bool attributesOverride)
        {
            this.CallVoidMethod("moveToAnchor", anchorElement, position, x, y, attributesOverride);
        }
    }
}
