namespace Gecko.WebIDL
{
    using System;
    
    
    public class PerformanceRenderTiming : WebIDLBase
    {
        
        public PerformanceRenderTiming(nsISupports thisObject) : 
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
