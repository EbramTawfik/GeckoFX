namespace Gecko.WebIDL
{
    using System;
    
    
    public class ShadowRoot : WebIDLBase
    {
        
        public ShadowRoot(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string InnerHTML
        {
            get
            {
                return this.GetProperty<string>("innerHTML");
            }
            set
            {
                this.SetProperty("innerHTML", value);
            }
        }
        
        public nsIDOMElement Host
        {
            get
            {
                return this.GetProperty<nsIDOMElement>("host");
            }
        }
        
        public nsISupports OlderShadowRoot
        {
            get
            {
                return this.GetProperty<nsISupports>("olderShadowRoot");
            }
        }
        
        public bool ApplyAuthorStyles
        {
            get
            {
                return this.GetProperty<bool>("applyAuthorStyles");
            }
            set
            {
                this.SetProperty("applyAuthorStyles", value);
            }
        }
        
        public nsISupports StyleSheets
        {
            get
            {
                return this.GetProperty<nsISupports>("styleSheets");
            }
        }
        
        public nsIDOMElement GetElementById(string elementId)
        {
            return this.CallMethod<nsIDOMElement>("getElementById", elementId);
        }
        
        public nsISupports GetElementsByTagName(string localName)
        {
            return this.CallMethod<nsISupports>("getElementsByTagName", localName);
        }
        
        public nsISupports GetElementsByTagNameNS(string @namespace, string localName)
        {
            return this.CallMethod<nsISupports>("getElementsByTagNameNS", @namespace, localName);
        }
        
        public nsISupports GetElementsByClassName(string classNames)
        {
            return this.CallMethod<nsISupports>("getElementsByClassName", classNames);
        }
    }
}
