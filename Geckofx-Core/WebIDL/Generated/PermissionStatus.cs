namespace Gecko.WebIDL
{
    using System;
    
    
    public class PermissionStatus : WebIDLBase
    {
        
        public PermissionStatus(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public PermissionState State
        {
            get
            {
                return this.GetProperty<PermissionState>("state");
            }
        }
    }
}
