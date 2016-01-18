namespace Gecko.WebIDL
{
    using System;
    
    
    public class CloseEvent : WebIDLBase
    {
        
        public CloseEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
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
        
        public string Reason
        {
            get
            {
                return this.GetProperty<string>("reason");
            }
        }
    }
}
