namespace Gecko.WebIDL
{
    using System;
    
    
    public class TouchEvent : WebIDLBase
    {
        
        public TouchEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Touches
        {
            get
            {
                return this.GetProperty<nsISupports>("touches");
            }
        }
        
        public nsISupports TargetTouches
        {
            get
            {
                return this.GetProperty<nsISupports>("targetTouches");
            }
        }
        
        public nsISupports ChangedTouches
        {
            get
            {
                return this.GetProperty<nsISupports>("changedTouches");
            }
        }
        
        public bool AltKey
        {
            get
            {
                return this.GetProperty<bool>("altKey");
            }
        }
        
        public bool MetaKey
        {
            get
            {
                return this.GetProperty<bool>("metaKey");
            }
        }
        
        public bool CtrlKey
        {
            get
            {
                return this.GetProperty<bool>("ctrlKey");
            }
        }
        
        public bool ShiftKey
        {
            get
            {
                return this.GetProperty<bool>("shiftKey");
            }
        }
        
        public void InitTouchEvent(string type, bool canBubble, bool cancelable, nsIDOMWindow view, int detail, bool ctrlKey, bool altKey, bool shiftKey, bool metaKey, nsISupports touches, nsISupports targetTouches, nsISupports changedTouches)
        {
            this.CallVoidMethod("initTouchEvent", type, canBubble, cancelable, view, detail, ctrlKey, altKey, shiftKey, metaKey, touches, targetTouches, changedTouches);
        }
    }
}
