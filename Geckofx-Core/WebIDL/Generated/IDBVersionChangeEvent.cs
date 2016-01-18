namespace Gecko.WebIDL
{
    using System;
    
    
    public class IDBVersionChangeEvent : WebIDLBase
    {
        
        public IDBVersionChangeEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public ulong OldVersion
        {
            get
            {
                return this.GetProperty<ulong>("oldVersion");
            }
        }
        
        public System.Nullable<ulong> NewVersion
        {
            get
            {
                return this.GetProperty<System.Nullable<ulong>>("newVersion");
            }
        }
    }
}
