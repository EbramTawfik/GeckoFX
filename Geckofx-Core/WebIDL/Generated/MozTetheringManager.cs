namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozTetheringManager : WebIDLBase
    {
        
        public MozTetheringManager(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public Promise <object> SetTetheringEnabled(bool enabled, TetheringType type)
        {
            return this.CallMethod<Promise <object>>("setTetheringEnabled", enabled, type);
        }
        
        public Promise <object> SetTetheringEnabled(bool enabled, TetheringType type, object config)
        {
            return this.CallMethod<Promise <object>>("setTetheringEnabled", enabled, type, config);
        }
    }
}
