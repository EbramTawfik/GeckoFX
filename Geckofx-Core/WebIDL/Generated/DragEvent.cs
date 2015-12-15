namespace Gecko.WebIDL
{
    using System;
    
    
    public class DragEvent : WebIDLBase
    {
        
        public DragEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports DataTransfer
        {
            get
            {
                return this.GetProperty<nsISupports>("dataTransfer");
            }
        }
        
        public void InitDragEvent(
                    nsAString type, 
                    bool canBubble, 
                    bool cancelable, 
                    nsIDOMWindow aView, 
                    int aDetail, 
                    int aScreenX, 
                    int aScreenY, 
                    int aClientX, 
                    int aClientY, 
                    bool aCtrlKey, 
                    bool aAltKey, 
                    bool aShiftKey, 
                    bool aMetaKey, 
                    ushort aButton, 
                    nsISupports aRelatedTarget, 
                    nsISupports aDataTransfer)
        {
            this.CallVoidMethod("initDragEvent", type, canBubble, cancelable, aView, aDetail, aScreenX, aScreenY, aClientX, aClientY, aCtrlKey, aAltKey, aShiftKey, aMetaKey, aButton, aRelatedTarget, aDataTransfer);
        }
    }
}
