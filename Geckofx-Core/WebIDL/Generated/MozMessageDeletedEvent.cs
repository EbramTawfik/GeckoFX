namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozMessageDeletedEvent : WebIDLBase
    {
        
        public MozMessageDeletedEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
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
