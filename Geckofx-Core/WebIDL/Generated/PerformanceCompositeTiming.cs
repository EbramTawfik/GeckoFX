namespace Gecko.WebIDL
{
    using System;
    
    
    public class PerformanceCompositeTiming : WebIDLBase
    {
        
        public PerformanceCompositeTiming(nsISupports thisObject) : 
                base(thisObject)
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
