namespace Gecko.WebIDL
{
    using System;
    
    
    public class Gamepad : WebIDLBase
    {
        
        public Gamepad(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Id
        {
            get
            {
                return this.GetProperty<string>("id");
            }
        }
        
        public uint Index
        {
            get
            {
                return this.GetProperty<uint>("index");
            }
        }
        
        public GamepadMappingType Mapping
        {
            get
            {
                return this.GetProperty<GamepadMappingType>("mapping");
            }
        }
        
        public bool Connected
        {
            get
            {
                return this.GetProperty<bool>("connected");
            }
        }
        
        public nsISupports[] Buttons
        {
            get
            {
                return this.GetProperty<nsISupports[]>("buttons");
            }
        }
        
        public double[] Axes
        {
            get
            {
                return this.GetProperty<double[]>("axes");
            }
        }
        
        public Double Timestamp
        {
            get
            {
                return this.GetProperty<Double>("timestamp");
            }
        }
    }
}
