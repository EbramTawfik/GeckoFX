namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLMenuElement : WebIDLBase
    {
        
        public HTMLMenuElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Type
        {
            get
            {
                return this.GetProperty<string>("type");
            }
            set
            {
                this.SetProperty("type", value);
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
        
        public bool Compact
        {
            get
            {
                return this.GetProperty<bool>("compact");
            }
            set
            {
                this.SetProperty("compact", value);
            }
        }
        
        public void SendShowEvent()
        {
            this.CallVoidMethod("sendShowEvent");
        }
        
        public nsISupports CreateBuilder()
        {
            return this.CallMethod<nsISupports>("createBuilder");
        }
        
        public void Build(nsISupports aBuilder)
        {
            this.CallVoidMethod("build", aBuilder);
        }
    }
}
