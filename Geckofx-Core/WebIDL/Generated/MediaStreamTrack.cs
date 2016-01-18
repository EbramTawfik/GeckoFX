namespace Gecko.WebIDL
{
    using System;
    
    
    public class MediaStreamTrack : WebIDLBase
    {
        
        public MediaStreamTrack(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Kind
        {
            get
            {
                return this.GetProperty<string>("kind");
            }
        }
        
        public string Id
        {
            get
            {
                return this.GetProperty<string>("id");
            }
        }
        
        public string Label
        {
            get
            {
                return this.GetProperty<string>("label");
            }
        }
        
        public bool Enabled
        {
            get
            {
                return this.GetProperty<bool>("enabled");
            }
            set
            {
                this.SetProperty("enabled", value);
            }
        }
        
        public void Stop()
        {
            this.CallVoidMethod("stop");
        }
        
        public Promise ApplyConstraints()
        {
            return this.CallMethod<Promise>("applyConstraints");
        }
        
        public Promise ApplyConstraints(object constraints)
        {
            return this.CallMethod<Promise>("applyConstraints", constraints);
        }
    }
}
