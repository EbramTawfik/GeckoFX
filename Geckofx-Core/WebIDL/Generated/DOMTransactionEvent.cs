namespace Gecko.WebIDL
{
    using System;
    
    
    public class DOMTransactionEvent : WebIDLBase
    {
        
        public DOMTransactionEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public object Transactions
        {
            get
            {
                return this.GetProperty<object>("transactions");
            }
        }
    }
}
