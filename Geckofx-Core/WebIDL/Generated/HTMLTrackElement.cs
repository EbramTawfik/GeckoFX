namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLTrackElement : WebIDLBase
    {
        
        public HTMLTrackElement(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString Kind
        {
            get
            {
                return this.GetProperty<nsAString>("kind");
            }
            set
            {
                this.SetProperty("kind", value);
            }
        }
        
        public nsAString Src
        {
            get
            {
                return this.GetProperty<nsAString>("src");
            }
            set
            {
                this.SetProperty("src", value);
            }
        }
        
        public nsAString Srclang
        {
            get
            {
                return this.GetProperty<nsAString>("srclang");
            }
            set
            {
                this.SetProperty("srclang", value);
            }
        }
        
        public nsAString Label
        {
            get
            {
                return this.GetProperty<nsAString>("label");
            }
            set
            {
                this.SetProperty("label", value);
            }
        }
        
        public bool Default
        {
            get
            {
                return this.GetProperty<bool>("default");
            }
            set
            {
                this.SetProperty("default", value);
            }
        }
        
        public ushort ReadyState
        {
            get
            {
                return this.GetProperty<ushort>("readyState");
            }
        }
        
        public nsISupports Track
        {
            get
            {
                return this.GetProperty<nsISupports>("track");
            }
        }
    }
}
