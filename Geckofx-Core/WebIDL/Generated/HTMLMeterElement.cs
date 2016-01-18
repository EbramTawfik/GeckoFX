namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLMeterElement : WebIDLBase
    {
        
        public HTMLMeterElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public double Value
        {
            get
            {
                return this.GetProperty<double>("value");
            }
            set
            {
                this.SetProperty("value", value);
            }
        }
        
        public double Min
        {
            get
            {
                return this.GetProperty<double>("min");
            }
            set
            {
                this.SetProperty("min", value);
            }
        }
        
        public double Max
        {
            get
            {
                return this.GetProperty<double>("max");
            }
            set
            {
                this.SetProperty("max", value);
            }
        }
        
        public double Low
        {
            get
            {
                return this.GetProperty<double>("low");
            }
            set
            {
                this.SetProperty("low", value);
            }
        }
        
        public double High
        {
            get
            {
                return this.GetProperty<double>("high");
            }
            set
            {
                this.SetProperty("high", value);
            }
        }
        
        public double Optimum
        {
            get
            {
                return this.GetProperty<double>("optimum");
            }
            set
            {
                this.SetProperty("optimum", value);
            }
        }
    }
}
