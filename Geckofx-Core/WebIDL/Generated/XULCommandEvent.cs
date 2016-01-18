namespace Gecko.WebIDL
{
    using System;
    
    
    public class XULCommandEvent : WebIDLBase
    {
        
        public XULCommandEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
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
        
        public nsIDOMEvent SourceEvent
        {
            get
            {
                return this.GetProperty<nsIDOMEvent>("sourceEvent");
            }
        }
        
        public void InitCommandEvent(string type, bool canBubble, bool cancelable, nsIDOMWindow view, int detail, bool ctrlKey, bool altKey, bool shiftKey, bool metaKey, nsIDOMEvent sourceEvent)
        {
            this.CallVoidMethod("initCommandEvent", type, canBubble, cancelable, view, detail, ctrlKey, altKey, shiftKey, metaKey, sourceEvent);
        }
    }
}
