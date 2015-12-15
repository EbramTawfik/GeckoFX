namespace Gecko.WebIDL
{
    using System;
    
    
    public class Screen : WebIDLBase
    {
        
        public Screen(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public int AvailWidth
        {
            get
            {
                return this.GetProperty<int>("availWidth");
            }
        }
        
        public int AvailHeight
        {
            get
            {
                return this.GetProperty<int>("availHeight");
            }
        }
        
        public int Width
        {
            get
            {
                return this.GetProperty<int>("width");
            }
        }
        
        public int Height
        {
            get
            {
                return this.GetProperty<int>("height");
            }
        }
        
        public int ColorDepth
        {
            get
            {
                return this.GetProperty<int>("colorDepth");
            }
        }
        
        public int PixelDepth
        {
            get
            {
                return this.GetProperty<int>("pixelDepth");
            }
        }
        
        public int Top
        {
            get
            {
                return this.GetProperty<int>("top");
            }
        }
        
        public int Left
        {
            get
            {
                return this.GetProperty<int>("left");
            }
        }
        
        public int AvailTop
        {
            get
            {
                return this.GetProperty<int>("availTop");
            }
        }
        
        public int AvailLeft
        {
            get
            {
                return this.GetProperty<int>("availLeft");
            }
        }
        
        public nsAString MozOrientation
        {
            get
            {
                return this.GetProperty<nsAString>("mozOrientation");
            }
        }
        
        public bool MozLockOrientation(nsAString orientation)
        {
            return this.CallMethod<bool>("mozLockOrientation", orientation);
        }
        
        public bool MozLockOrientation(nsAString[] orientation)
        {
            return this.CallMethod<bool>("mozLockOrientation", orientation);
        }
        
        public void MozUnlockOrientation()
        {
            this.CallVoidMethod("mozUnlockOrientation");
        }
        
        public nsISupports Orientation
        {
            get
            {
                return this.GetProperty<nsISupports>("orientation");
            }
        }
    }
}
