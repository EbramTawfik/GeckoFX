namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLScriptElement : WebIDLBase
    {
        
        public HTMLScriptElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
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
        
        public nsAString Charset
        {
            get
            {
                return this.GetProperty<nsAString>("charset");
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
        
        public nsAString CrossOrigin
        {
            get
            {
                return this.GetProperty<nsAString>("crossOrigin");
            }
            set
            {
                this.SetProperty("crossOrigin", value);
            }
        }
        
        public nsAString Text
        {
            get
            {
                return this.GetProperty<nsAString>("text");
            }
            set
            {
                this.SetProperty("text", value);
            }
        }
        
        public nsAString Event
        {
            get
            {
                return this.GetProperty<nsAString>("event");
            }
            set
            {
                this.SetProperty("event", value);
            }
        }
        
        public nsAString HtmlFor
        {
            get
            {
                return this.GetProperty<nsAString>("htmlFor");
            }
            set
            {
                this.SetProperty("htmlFor", value);
            }
        }
        
        public nsAString Integrity
        {
            get
            {
                return this.GetProperty<nsAString>("integrity");
            }
            set
            {
                this.SetProperty("integrity", value);
            }
        }
    }
}
