namespace Gecko.WebIDL
{
    using System;
    
    
    public class HMDVRDevice : WebIDLBase
    {
        
        public HMDVRDevice(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports GetEyeParameters(VREye whichEye)
        {
            return this.CallMethod<nsISupports>("getEyeParameters", whichEye);
        }
        
        public void SetFieldOfView()
        {
            this.CallVoidMethod("setFieldOfView");
        }
        
        public void SetFieldOfView(object leftFOV)
        {
            this.CallVoidMethod("setFieldOfView", leftFOV);
        }
        
        public void SetFieldOfView(object leftFOV, object rightFOV)
        {
            this.CallVoidMethod("setFieldOfView", leftFOV, rightFOV);
        }
        
        public void SetFieldOfView(object leftFOV, object rightFOV, double zNear)
        {
            this.CallVoidMethod("setFieldOfView", leftFOV, rightFOV, zNear);
        }
        
        public void SetFieldOfView(object leftFOV, object rightFOV, double zNear, double zFar)
        {
            this.CallVoidMethod("setFieldOfView", leftFOV, rightFOV, zNear, zFar);
        }
    }
}
