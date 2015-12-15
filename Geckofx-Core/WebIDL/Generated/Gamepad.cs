namespace Gecko.WebIDL
{
    using System;
    
    
    public class Gamepad : WebIDLBase
    {
        
        public Gamepad(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString Id
        {
            get
            {
                return this.GetProperty<nsAString>("id");
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
