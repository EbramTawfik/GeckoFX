namespace Gecko.WebIDL
{
    using System;
    
    
    public class GamepadEvent : WebIDLBase
    {
        
        public GamepadEvent(nsISupports thisObject) : 
                base(thisObject)
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
