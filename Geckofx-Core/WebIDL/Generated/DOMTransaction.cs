namespace Gecko.WebIDL
{
    using System;
    
    
    public class DOMTransaction : WebIDLBase
    {
        
        public DOMTransaction(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString Label
        {
            get
            {
                return this.GetProperty<nsAString>("label");
            }
        }
    }
}
