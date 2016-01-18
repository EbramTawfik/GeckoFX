namespace Gecko.WebIDL
{
    using System;
    
    
    public class AudioTrack : WebIDLBase
    {
        
        public AudioTrack(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Id
        {
            get
            {
                return this.GetProperty<string>("id");
            }
        }
        
        public string Kind
        {
            get
            {
                return this.GetProperty<string>("kind");
            }
        }
        
        public string Label
        {
            get
            {
                return this.GetProperty<string>("label");
            }
        }
        
        public string Language
        {
            get
            {
                return this.GetProperty<string>("language");
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
    }
}
