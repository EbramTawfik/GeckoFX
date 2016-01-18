namespace Gecko.WebIDL
{
    using System;
    
    
    public class MediaSource : WebIDLBase
    {
        
        public MediaSource(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports SourceBuffers
        {
            get
            {
                return this.GetProperty<nsISupports>("sourceBuffers");
            }
        }
        
        public nsISupports ActiveSourceBuffers
        {
            get
            {
                return this.GetProperty<nsISupports>("activeSourceBuffers");
            }
        }
        
        public MediaSourceReadyState ReadyState
        {
            get
            {
                return this.GetProperty<MediaSourceReadyState>("readyState");
            }
        }
        
        public double Duration
        {
            get
            {
                return this.GetProperty<double>("duration");
            }
            set
            {
                this.SetProperty("duration", value);
            }
        }
        
        public string MozDebugReaderData
        {
            get
            {
                return this.GetProperty<string>("mozDebugReaderData");
            }
        }
        
        public nsISupports AddSourceBuffer(string type)
        {
            return this.CallMethod<nsISupports>("addSourceBuffer", type);
        }
        
        public void RemoveSourceBuffer(nsISupports sourceBuffer)
        {
            this.CallVoidMethod("removeSourceBuffer", sourceBuffer);
        }
        
        public void EndOfStream()
        {
            this.CallVoidMethod("endOfStream");
        }
        
        public void EndOfStream(MediaSourceEndOfStreamError error)
        {
            this.CallVoidMethod("endOfStream", error);
        }
    }
}
