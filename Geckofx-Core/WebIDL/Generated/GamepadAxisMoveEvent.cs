namespace Gecko.WebIDL
{
    using System;
    
    
    public class GamepadAxisMoveEvent : WebIDLBase
    {
        
        public GamepadAxisMoveEvent(nsISupports thisObject) : 
                base(thisObject)
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
