namespace Gecko.WebIDL
{
    using System;
    
    
    public class IDBVersionChangeEvent : WebIDLBase
    {
        
        public IDBVersionChangeEvent(nsISupports thisObject) : 
                base(thisObject)
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
