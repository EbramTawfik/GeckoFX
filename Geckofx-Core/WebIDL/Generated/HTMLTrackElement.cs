namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLTrackElement : WebIDLBase
    {
        
        public HTMLTrackElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Kind
        {
            get
            {
                return this.GetProperty<string>("kind");
            }
            set
            {
                this.SetProperty("kind", value);
            }
        }
        
        public string Src
        {
            get
            {
                return this.GetProperty<string>("src");
            }
            set
            {
                this.SetProperty("src", value);
            }
        }
        
        public string Srclang
        {
            get
            {
                return this.GetProperty<string>("srclang");
            }
            set
            {
                this.SetProperty("srclang", value);
            }
        }
        
        public string Label
        {
            get
            {
                return this.GetProperty<string>("label");
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
