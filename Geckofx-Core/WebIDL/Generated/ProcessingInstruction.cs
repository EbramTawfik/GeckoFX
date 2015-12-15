namespace Gecko.WebIDL
{
    using System;
    
    
    public class ProcessingInstruction : WebIDLBase
    {
        
        public ProcessingInstruction(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString Target
        {
            get
            {
                return this.GetProperty<nsAString>("target");
            }
        }
    }
}
