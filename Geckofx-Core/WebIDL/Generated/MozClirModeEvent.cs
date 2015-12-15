namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozClirModeEvent : WebIDLBase
    {
        
        public MozClirModeEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public uint Mode
        {
            get
            {
                return this.GetProperty<uint>("mode");
            }
        }
    }
}
