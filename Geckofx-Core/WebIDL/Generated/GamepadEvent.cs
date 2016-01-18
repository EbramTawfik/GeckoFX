namespace Gecko.WebIDL
{
    using System;
    
    
    public class GamepadEvent : WebIDLBase
    {
        
        public GamepadEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Gamepad
        {
            get
            {
                return this.GetProperty<nsISupports>("gamepad");
            }
        }
    }
}
