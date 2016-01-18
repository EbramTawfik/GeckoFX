namespace Gecko.WebIDL
{
    using System;
    
    
    public class ProgressEvent : WebIDLBase
    {
        
        public ProgressEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public bool LengthComputable
        {
            get
            {
                return this.GetProperty<bool>("lengthComputable");
            }
        }
        
        public ulong Loaded
        {
            get
            {
                return this.GetProperty<ulong>("loaded");
            }
        }
        
        public ulong Total
        {
            get
            {
                return this.GetProperty<ulong>("total");
            }
        }
    }
}
