namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLAllCollection : WebIDLBase
    {
        
        public HTMLAllCollection(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public uint Length
        {
            get
            {
                return this.GetProperty<uint>("length");
            }
        }
        
        public nsIDOMNode Item(uint index)
        {
            return this.CallMethod<nsIDOMNode>("item", index);
        }
        
        public WebIDLUnion<nsIDOMNode,nsISupports> Item(nsAString name)
        {
            return this.CallMethod<WebIDLUnion<nsIDOMNode,nsISupports>>("item", name);
        }
    }
}
