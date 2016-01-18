namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLScriptElement : WebIDLBase
    {
        
        public HTMLScriptElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
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
        
        public string Charset
        {
            get
            {
                return this.GetProperty<string>("charset");
            }
            set
            {
                this.SetProperty("charset", value);
            }
        }
        
        public bool Async
        {
            get
            {
                return this.GetProperty<bool>("async");
            }
            set
            {
                this.SetProperty("async", value);
            }
        }
        
        public bool Defer
        {
            get
            {
                return this.GetProperty<bool>("defer");
            }
            set
            {
                this.SetProperty("defer", value);
            }
        }
        
        public string CrossOrigin
        {
            get
            {
                return this.GetProperty<string>("crossOrigin");
            }
            set
            {
                this.SetProperty("crossOrigin", value);
            }
        }
        
        public string Text
        {
            get
            {
                return this.GetProperty<string>("text");
            }
            set
            {
                this.SetProperty("text", value);
            }
        }
        
        public string Event
        {
            get
            {
                return this.GetProperty<string>("event");
            }
            set
            {
                this.SetProperty("event", value);
            }
        }
        
        public string HtmlFor
        {
            get
            {
                return this.GetProperty<string>("htmlFor");
            }
            set
            {
                this.SetProperty("htmlFor", value);
            }
        }
        
        public string Integrity
        {
            get
            {
                return this.GetProperty<string>("integrity");
            }
            set
            {
                this.SetProperty("integrity", value);
            }
        }
    }
}
