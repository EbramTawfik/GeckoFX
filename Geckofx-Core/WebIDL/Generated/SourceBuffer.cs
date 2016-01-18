namespace Gecko.WebIDL
{
    using System;
    
    
    public class SourceBuffer : WebIDLBase
    {
        
        public SourceBuffer(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public SourceBufferAppendMode Mode
        {
            get
            {
                return this.GetProperty<SourceBufferAppendMode>("mode");
            }
            set
            {
                this.SetProperty("mode", value);
            }
        }
        
        public bool Updating
        {
            get
            {
                return this.GetProperty<bool>("updating");
            }
        }
        
        public nsISupports Buffered
        {
            get
            {
                return this.GetProperty<nsISupports>("buffered");
            }
        }
        
        public double TimestampOffset
        {
            get
            {
                return this.GetProperty<double>("timestampOffset");
            }
            set
            {
                this.SetProperty("timestampOffset", value);
            }
        }
        
        public double AppendWindowStart
        {
            get
            {
                return this.GetProperty<double>("appendWindowStart");
            }
            set
            {
                this.SetProperty("appendWindowStart", value);
            }
        }
        
        public double AppendWindowEnd
        {
            get
            {
                return this.GetProperty<double>("appendWindowEnd");
            }
            set
            {
                this.SetProperty("appendWindowEnd", value);
            }
        }
        
        public void AppendBuffer(IntPtr data)
        {
            this.CallVoidMethod("appendBuffer", data);
        }
        
        public void Abort()
        {
            this.CallVoidMethod("abort");
        }
        
        public void Remove(double start, double end)
        {
            this.CallVoidMethod("remove", start, end);
        }
    }
}
