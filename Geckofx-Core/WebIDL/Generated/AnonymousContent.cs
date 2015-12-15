namespace Gecko.WebIDL
{
    using System;
    
    
    public class AnonymousContent : WebIDLBase
    {
        
        public AnonymousContent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString GetTextContentForElement(nsAString elementId)
        {
            return this.CallMethod<nsAString>("getTextContentForElement", elementId);
        }
        
        public void SetTextContentForElement(nsAString elementId, nsAString text)
        {
            this.CallVoidMethod("setTextContentForElement", elementId, text);
        }
        
        public nsAString GetAttributeForElement(nsAString elementId, nsAString attributeName)
        {
            return this.CallMethod<nsAString>("getAttributeForElement", elementId, attributeName);
        }
        
        public void SetAttributeForElement(nsAString elementId, nsAString attributeName, nsAString value)
        {
            this.CallVoidMethod("setAttributeForElement", elementId, attributeName, value);
        }
        
        public void RemoveAttributeForElement(nsAString elementId, nsAString attributeName)
        {
            this.CallVoidMethod("removeAttributeForElement", elementId, attributeName);
        }
        
        public nsISupports GetCanvasContext(nsAString elementId, nsAString contextId)
        {
            return this.CallMethod<nsISupports>("getCanvasContext", elementId, contextId);
        }
    }
}
