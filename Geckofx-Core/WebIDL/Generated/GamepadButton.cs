namespace Gecko.WebIDL
{
    using System;
    
    
    public class GamepadButton : WebIDLBase
    {
        
        public GamepadButton(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public bool Pressed
        {
            get
            {
                return this.GetProperty<bool>("pressed");
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
