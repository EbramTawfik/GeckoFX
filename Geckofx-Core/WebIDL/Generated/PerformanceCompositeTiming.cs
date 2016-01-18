namespace Gecko.WebIDL
{
    using System;
    
    
    public class PerformanceCompositeTiming : WebIDLBase
    {
        
        public PerformanceCompositeTiming(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public uint SourceFrameNumber
        {
            get
            {
                return this.GetProperty<uint>("sourceFrameNumber");
            }
        }
    }
}
