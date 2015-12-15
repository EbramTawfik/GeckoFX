namespace Gecko.WebIDL
{
    using System;
    
    
    public class KeyEvent : WebIDLBase
    {
        
        public KeyEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public void InitKeyEvent(nsAString type, bool canBubble, bool cancelable, nsIDOMWindow view, bool ctrlKey, bool altKey, bool shiftKey, bool metaKey, uint keyCode, uint charCode)
        {
            this.CallVoidMethod("initKeyEvent", type, canBubble, cancelable, view, ctrlKey, altKey, shiftKey, metaKey, keyCode, charCode);
        }
    }
}
