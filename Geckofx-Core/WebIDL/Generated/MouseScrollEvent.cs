namespace Gecko.WebIDL
{
    using System;
    
    
    public class MouseScrollEvent : WebIDLBase
    {
        
        public MouseScrollEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public int Axis
        {
            get
            {
                return this.GetProperty<int>("axis");
            }
        }
        
        public void InitMouseScrollEvent(
                    nsAString type, 
                    bool canBubble, 
                    bool cancelable, 
                    nsIDOMWindow view, 
                    int detail, 
                    int screenX, 
                    int screenY, 
                    int clientX, 
                    int clientY, 
                    bool ctrlKey, 
                    bool altKey, 
                    bool shiftKey, 
                    bool metaKey, 
                    ushort button, 
                    nsISupports relatedTarget, 
                    int axis)
        {
            this.CallVoidMethod("initMouseScrollEvent", type, canBubble, cancelable, view, detail, screenX, screenY, clientX, clientY, ctrlKey, altKey, shiftKey, metaKey, button, relatedTarget, axis);
        }
    }
}
