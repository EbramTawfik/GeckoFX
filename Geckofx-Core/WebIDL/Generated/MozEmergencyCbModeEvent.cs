namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozEmergencyCbModeEvent : WebIDLBase
    {
        
        public MozEmergencyCbModeEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public bool Active
        {
            get
            {
                return this.GetProperty<bool>("active");
            }
        }
        
        public uint TimeoutMs
        {
            get
            {
                return this.GetProperty<uint>("timeoutMs");
            }
        }
    }
}
