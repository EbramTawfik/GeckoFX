namespace Gecko.WebIDL
{
    using System;
    
    
    public class HMDVRDevice : WebIDLBase
    {
        
        public HMDVRDevice(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports GetEyeParameters(VREye whichEye)
        {
            return this.CallMethod<nsISupports>("getEyeParameters", whichEye);
        }
        
        public void SetFieldOfView(object leftFOV, object rightFOV, double zNear, double zFar)
        {
            this.CallVoidMethod("setFieldOfView", leftFOV, rightFOV, zNear, zFar);
        }
    }
}
