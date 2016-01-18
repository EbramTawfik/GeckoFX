namespace Gecko.WebIDL
{
    using System;
    
    
    public class GamepadAxisMoveEvent : WebIDLBase
    {
        
        public GamepadAxisMoveEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public uint Axis
        {
            get
            {
                return this.GetProperty<uint>("axis");
            }
        }
        
        public double Value
        {
            get
            {
                return this.GetProperty<double>("value");
            }
        }
    }
}
