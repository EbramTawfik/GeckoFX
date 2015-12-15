namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozTetheringManager : WebIDLBase
    {
        
        public MozTetheringManager(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public Promise <object> SetTetheringEnabled(bool enabled, TetheringType type, object config)
        {
            return this.CallMethod<Promise <object>>("setTetheringEnabled", enabled, type, config);
        }
    }
}
