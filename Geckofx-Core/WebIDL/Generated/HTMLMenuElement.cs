namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLMenuElement : WebIDLBase
    {
        
        public HTMLMenuElement(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString Type
        {
            get
            {
                return this.GetProperty<nsAString>("type");
            }
            set
            {
                this.SetProperty("type", value);
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
