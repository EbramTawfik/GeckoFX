namespace Gecko.WebIDL
{
    using System;
    
    
    public class CaretPosition : WebIDLBase
    {
        
        public CaretPosition(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsIDOMNode OffsetNode
        {
            get
            {
                return this.GetProperty<nsIDOMNode>("offsetNode");
            }
        }
        
        public uint Offset
        {
            get
            {
                return this.GetProperty<uint>("offset");
            }
        }
        
        public nsISupports GetClientRect()
        {
            return this.CallMethod<nsISupports>("getClientRect");
        }
    }
}
