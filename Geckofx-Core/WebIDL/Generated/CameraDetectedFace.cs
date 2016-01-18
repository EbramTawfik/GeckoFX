namespace Gecko.WebIDL
{
    using System;
    
    
    public class CameraDetectedFace : WebIDLBase
    {
        
        public CameraDetectedFace(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public uint Id
        {
            get
            {
                return this.GetProperty<uint>("id");
            }
        }
        
        public uint Score
        {
            get
            {
                return this.GetProperty<uint>("score");
            }
        }
        
        public nsISupports Bounds
        {
            get
            {
                return this.GetProperty<nsISupports>("bounds");
            }
        }
        
        public bool HasLeftEye
        {
            get
            {
                return this.GetProperty<bool>("hasLeftEye");
            }
        }
        
        public nsISupports LeftEye
        {
            get
            {
                return this.GetProperty<nsISupports>("leftEye");
            }
        }
        
        public bool HasRightEye
        {
            get
            {
                return this.GetProperty<bool>("hasRightEye");
            }
        }
        
        public nsISupports RightEye
        {
            get
            {
                return this.GetProperty<nsISupports>("rightEye");
            }
        }
        
        public bool HasMouth
        {
            get
            {
                return this.GetProperty<bool>("hasMouth");
            }
        }
        
        public nsISupports Mouth
        {
            get
            {
                return this.GetProperty<nsISupports>("mouth");
            }
        }
    }
}
