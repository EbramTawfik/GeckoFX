namespace Gecko.WebIDL
{
    using System;
    
    
    public class CloseEvent : WebIDLBase
    {
        
        public CloseEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public bool WasClean
        {
            get
            {
                return this.GetProperty<bool>("wasClean");
            }
        }
        
        public ushort Code
        {
            get
            {
                return this.GetProperty<ushort>("code");
            }
        }
        
        public nsAString Reason
        {
            get
            {
                return this.GetProperty<nsAString>("reason");
            }
        }
    }
}
