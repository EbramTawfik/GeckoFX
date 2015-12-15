namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozMessageDeletedEvent : WebIDLBase
    {
        
        public MozMessageDeletedEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public int[] DeletedMessageIds
        {
            get
            {
                return this.GetProperty<int[]>("deletedMessageIds");
            }
        }
        
        public ulong[] DeletedThreadIds
        {
            get
            {
                return this.GetProperty<ulong[]>("deletedThreadIds");
            }
        }
    }
}
