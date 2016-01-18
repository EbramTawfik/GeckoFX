namespace Gecko.WebIDL
{
    using System;
    
    
    public class XMLStylesheetProcessingInstruction : WebIDLBase
    {
        
        public XMLStylesheetProcessingInstruction(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Sheet
        {
            get
            {
                return this.GetProperty<nsISupports>("sheet");
            }
        }
    }
}
