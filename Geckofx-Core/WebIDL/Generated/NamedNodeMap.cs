namespace Gecko.WebIDL
{
    using System;
    
    
    public class NamedNodeMap : WebIDLBase
    {
        
        public NamedNodeMap(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public uint Length
        {
            get
            {
                return this.GetProperty<uint>("length");
            }
        }
        
        public nsISupports SetNamedItem(nsISupports arg)
        {
            return this.CallMethod<nsISupports>("setNamedItem", arg);
        }
        
        public nsISupports RemoveNamedItem(nsAString name)
        {
            return this.CallMethod<nsISupports>("removeNamedItem", name);
        }
        
        public nsISupports GetNamedItemNS(nsAString namespaceURI, nsAString localName)
        {
            return this.CallMethod<nsISupports>("getNamedItemNS", namespaceURI, localName);
        }
        
        public nsISupports SetNamedItemNS(nsISupports arg)
        {
            return this.CallMethod<nsISupports>("setNamedItemNS", arg);
        }
        
        public nsISupports RemoveNamedItemNS(nsAString namespaceURI, nsAString localName)
        {
            return this.CallMethod<nsISupports>("removeNamedItemNS", namespaceURI, localName);
        }
    }
}
