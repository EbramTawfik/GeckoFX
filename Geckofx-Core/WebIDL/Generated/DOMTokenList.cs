namespace Gecko.WebIDL
{
    using System;
    
    
    public class DOMTokenList : WebIDLBase
    {
        
        public DOMTokenList(nsIDOMWindow globalWindow, nsISupports thisObject) : 
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
        
        public bool Contains(nsAString token)
        {
            return this.CallMethod<bool>("contains", token);
        }
        
        public void Add(nsAString tokens)
        {
            this.CallVoidMethod("add", tokens);
        }
        
        public void Remove(nsAString tokens)
        {
            this.CallVoidMethod("remove", tokens);
        }
        
        public bool Toggle(nsAString token)
        {
            return this.CallMethod<bool>("toggle", token);
        }
        
        public bool Toggle(nsAString token, bool force)
        {
            return this.CallMethod<bool>("toggle", token, force);
        }
    }
}
