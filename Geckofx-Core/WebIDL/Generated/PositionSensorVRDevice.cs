namespace Gecko.WebIDL
{
    using System;
    
    
    public class PositionSensorVRDevice : WebIDLBase
    {
        
        public PositionSensorVRDevice(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports GetState()
        {
            return this.CallMethod<nsISupports>("getState");
        }
        
        public nsISupports GetImmediateState()
        {
            return this.CallMethod<nsISupports>("getImmediateState");
        }
        
        public void ResetSensor()
        {
            this.CallVoidMethod("resetSensor");
        }
    }
}
