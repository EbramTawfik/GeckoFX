namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGAngle : WebIDLBase
    {
        
        public SVGAngle(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public ushort UnitType
        {
            get
            {
                return this.GetProperty<ushort>("unitType");
            }
        }
        
        public float Value
        {
            get
            {
                return this.GetProperty<float>("value");
            }
            set
            {
                this.SetProperty("value", value);
            }
        }
        
        public float ValueInSpecifiedUnits
        {
            get
            {
                return this.GetProperty<float>("valueInSpecifiedUnits");
            }
            set
            {
                this.SetProperty("valueInSpecifiedUnits", value);
            }
        }
        
        public string ValueAsString
        {
            get
            {
                return this.GetProperty<string>("valueAsString");
            }
            set
            {
                this.SetProperty("valueAsString", value);
            }
        }
        
        public void NewValueSpecifiedUnits(ushort unitType, float valueInSpecifiedUnits)
        {
            this.CallVoidMethod("newValueSpecifiedUnits", unitType, valueInSpecifiedUnits);
        }
        
        public void ConvertToSpecifiedUnits(ushort unitType)
        {
            this.CallVoidMethod("convertToSpecifiedUnits", unitType);
        }
    }
}
