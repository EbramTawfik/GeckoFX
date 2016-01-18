namespace Gecko.WebIDL
{
    using System;
    
    
    public class DOMTransaction : WebIDLBase
    {
        
        public DOMTransaction(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Label
        {
            get
            {
                return this.GetProperty<string>("label");
            }
        }
    }
}
