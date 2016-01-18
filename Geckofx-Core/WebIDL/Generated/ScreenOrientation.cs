namespace Gecko.WebIDL
{
    using System;
    
    
    public class ScreenOrientation : WebIDLBase
    {
        
        public ScreenOrientation(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public OrientationType Type
        {
            get
            {
                return this.GetProperty<OrientationType>("type");
            }
        }
        
        public ushort Angle
        {
            get
            {
                return this.GetProperty<ushort>("angle");
            }
        }
        
        public Promise Lock(OrientationLockType orientation)
        {
            return this.CallMethod<Promise>("lock", orientation);
        }
        
        public void Unlock()
        {
            this.CallVoidMethod("unlock");
        }
    }
}
