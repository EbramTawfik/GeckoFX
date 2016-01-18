namespace Gecko.WebIDL
{
    using System;
    
    
    public class DocumentFragment : WebIDLBase
    {
        
        public DocumentFragment(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsIDOMElement GetElementById(nsAString elementId)
        {
            return this.CallMethod<nsIDOMElement>("getElementById", elementId);
        }
        
        public nsIDOMElement QuerySelector(nsAString selectors)
        {
            return this.CallMethod<nsIDOMElement>("querySelector", selectors);
        }
        
        public nsISupports QuerySelectorAll(nsAString selectors)
        {
            return this.CallMethod<nsISupports>("querySelectorAll", selectors);
        }
    }
}
