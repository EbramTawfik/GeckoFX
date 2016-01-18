namespace Gecko.WebIDL
{
    using System;
    
    
    public class TimeRanges : WebIDLBase
    {
        
        public TimeRanges(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public uint Length
        {
            get
            {
                return this.GetProperty<uint>("length");
            }
        }
        
        public double Start(uint index)
        {
            return this.CallMethod<double>("start", index);
        }
        
        public double End(uint index)
        {
            return this.CallMethod<double>("end", index);
        }
    }
}
