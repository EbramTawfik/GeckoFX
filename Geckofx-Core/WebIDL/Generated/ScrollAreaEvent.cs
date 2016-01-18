namespace Gecko.WebIDL
{
    using System;
    
    
    public class ScrollAreaEvent : WebIDLBase
    {
        
        public ScrollAreaEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public float X
        {
            get
            {
                return this.GetProperty<float>("x");
            }
        }
        
        public float Y
        {
            get
            {
                return this.GetProperty<float>("y");
            }
        }
        
        public float Width
        {
            get
            {
                return this.GetProperty<float>("width");
            }
        }
        
        public float Height
        {
            get
            {
                return this.GetProperty<float>("height");
            }
        }
        
        public void InitScrollAreaEvent(nsAString type, bool canBubble, bool cancelable, nsIDOMWindow view, int detail, float x, float y, float width, float height)
        {
            this.CallVoidMethod("initScrollAreaEvent", type, canBubble, cancelable, view, detail, x, y, width, height);
        }
    }
}
