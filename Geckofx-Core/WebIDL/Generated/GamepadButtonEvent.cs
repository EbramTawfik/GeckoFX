namespace Gecko.WebIDL
{
    using System;
    
    
    public class GamepadButtonEvent : WebIDLBase
    {
        
        public GamepadButtonEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public uint Button
        {
            get
            {
                return this.GetProperty<uint>("button");
            }
        }
    }
}
