namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozPowerManager : WebIDLBase
    {
        
        public MozPowerManager(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public bool ScreenEnabled
        {
            get
            {
                return this.GetProperty<bool>("screenEnabled");
            }
            set
            {
                this.SetProperty("screenEnabled", value);
            }
        }
        
        public bool KeyLightEnabled
        {
            get
            {
                return this.GetProperty<bool>("keyLightEnabled");
            }
            set
            {
                this.SetProperty("keyLightEnabled", value);
            }
        }
        
        public double ScreenBrightness
        {
            get
            {
                return this.GetProperty<double>("screenBrightness");
            }
            set
            {
                this.SetProperty("screenBrightness", value);
            }
        }
        
        public bool CpuSleepAllowed
        {
            get
            {
                return this.GetProperty<bool>("cpuSleepAllowed");
            }
            set
            {
                this.SetProperty("cpuSleepAllowed", value);
            }
        }
        
        public void PowerOff()
        {
            this.CallVoidMethod("powerOff");
        }
        
        public void Reboot()
        {
            this.CallVoidMethod("reboot");
        }
        
        public void FactoryReset(FactoryResetReason reason)
        {
            this.CallVoidMethod("factoryReset", reason);
        }
        
        public void AddWakeLockListener(nsISupports aListener)
        {
            this.CallVoidMethod("addWakeLockListener", aListener);
        }
        
        public void RemoveWakeLockListener(nsISupports aListener)
        {
            this.CallVoidMethod("removeWakeLockListener", aListener);
        }
        
        public nsAString GetWakeLockState(nsAString aTopic)
        {
            return this.CallMethod<nsAString>("getWakeLockState", aTopic);
        }
    }
}
