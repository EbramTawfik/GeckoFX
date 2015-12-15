namespace Gecko.WebIDL
{
    using System;
    
    
    public class MediaStreamTrack : WebIDLBase
    {
        
        public MediaStreamTrack(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString Kind
        {
            get
            {
                return this.GetProperty<nsAString>("kind");
            }
        }
        
        public nsAString Id
        {
            get
            {
                return this.GetProperty<nsAString>("id");
            }
        }
        
        public nsAString Label
        {
            get
            {
                return this.GetProperty<nsAString>("label");
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
        
        public Promise ApplyConstraints(object constraints)
        {
            return this.CallMethod<Promise>("applyConstraints", constraints);
        }
    }
}
