namespace Gecko.WebIDL
{
    using System;
    
    
    public class PositionSensorVRDevice : WebIDLBase
    {
        
        public PositionSensorVRDevice(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
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
