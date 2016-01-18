namespace Gecko.WebIDL
{
    using System;
    
    
    public class Coordinates : WebIDLBase
    {
        
        public Coordinates(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public double Latitude
        {
            get
            {
                return this.GetProperty<double>("latitude");
            }
        }
        
        public double Longitude
        {
            get
            {
                return this.GetProperty<double>("longitude");
            }
        }
        
        public System.Nullable<double> Altitude
        {
            get
            {
                return this.GetProperty<System.Nullable<double>>("altitude");
            }
        }
        
        public double Accuracy
        {
            get
            {
                return this.GetProperty<double>("accuracy");
            }
        }
        
        public System.Nullable<double> AltitudeAccuracy
        {
            get
            {
                return this.GetProperty<System.Nullable<double>>("altitudeAccuracy");
            }
        }
        
        public System.Nullable<double> Heading
        {
            get
            {
                return this.GetProperty<System.Nullable<double>>("heading");
            }
        }
        
        public System.Nullable<double> Speed
        {
            get
            {
                return this.GetProperty<System.Nullable<double>>("speed");
            }
        }
    }
}
