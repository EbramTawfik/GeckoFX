namespace Gecko.WebIDL
{
    using System;
    
    
    public class XMLStylesheetProcessingInstruction : WebIDLBase
    {
        
        public XMLStylesheetProcessingInstruction(nsISupports thisObject) : 
                base(thisObject)
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
