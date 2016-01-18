namespace Gecko.WebIDL
{
    using System;
    
    
    public class AudioListener : WebIDLBase
    {
        
        public AudioListener(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public double DopplerFactor
        {
            get
            {
                return this.GetProperty<double>("dopplerFactor");
            }
            set
            {
                this.SetProperty("dopplerFactor", value);
            }
        }
        
        public double SpeedOfSound
        {
            get
            {
                return this.GetProperty<double>("speedOfSound");
            }
            set
            {
                this.SetProperty("speedOfSound", value);
            }
        }
        
        public void SetPosition(double x, double y, double z)
        {
            this.CallVoidMethod("setPosition", x, y, z);
        }
        
        public void SetOrientation(double x, double y, double z, double xUp, double yUp, double zUp)
        {
            this.CallVoidMethod("setOrientation", x, y, z, xUp, yUp, zUp);
        }
        
        public void SetVelocity(double x, double y, double z)
        {
            this.CallVoidMethod("setVelocity", x, y, z);
        }
    }
}
