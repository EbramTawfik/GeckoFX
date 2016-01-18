namespace Gecko.WebIDL
{
    using System;
    
    
    public class DocumentFragment : WebIDLBase
    {
        
        public DocumentFragment(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsIDOMElement GetElementById(string elementId)
        {
            return this.CallMethod<nsIDOMElement>("getElementById", elementId);
        }
        
        public nsIDOMElement QuerySelector(string selectors)
        {
            return this.CallMethod<nsIDOMElement>("querySelector", selectors);
        }
        
        public nsISupports QuerySelectorAll(string selectors)
        {
            return this.CallMethod<nsISupports>("querySelectorAll", selectors);
        }
    }
}
