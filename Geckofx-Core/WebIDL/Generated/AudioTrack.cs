namespace Gecko.WebIDL
{
    using System;
    
    
    public class AudioTrack : WebIDLBase
    {
        
        public AudioTrack(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString Id
        {
            get
            {
                return this.GetProperty<nsAString>("id");
            }
        }
        
        public nsAString Kind
        {
            get
            {
                return this.GetProperty<nsAString>("kind");
            }
        }
        
        public nsAString Label
        {
            get
            {
                return this.GetProperty<nsAString>("label");
            }
        }
        
        public nsAString Language
        {
            get
            {
                return this.GetProperty<nsAString>("language");
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
