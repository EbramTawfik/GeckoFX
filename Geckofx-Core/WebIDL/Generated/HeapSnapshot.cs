namespace Gecko.WebIDL
{
    using System;
    
    
    public class HeapSnapshot : WebIDLBase
    {
        
        public HeapSnapshot(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public System.Nullable<ulong> CreationTime
        {
            get
            {
                return this.GetProperty<System.Nullable<ulong>>("creationTime");
            }
        }
        
        public object TakeCensus(object options)
        {
            return this.CallMethod<object>("takeCensus", options);
        }
        
        public nsISupports ComputeDominatorTree()
        {
            return this.CallMethod<nsISupports>("computeDominatorTree");
        }
    }
}
