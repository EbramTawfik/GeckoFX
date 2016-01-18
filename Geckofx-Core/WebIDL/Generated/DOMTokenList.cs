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
        
        public bool Contains(string token)
        {
            return this.CallMethod<bool>("contains", token);
        }
        
        public void Add(string tokens)
        {
            this.CallVoidMethod("add", tokens);
        }
        
        public void Remove(string tokens)
        {
            this.CallVoidMethod("remove", tokens);
        }
        
        public bool Toggle(string token)
        {
            return this.CallMethod<bool>("toggle", token);
        }
        
        public bool Toggle(string token, bool force)
        {
            return this.CallMethod<bool>("toggle", token, force);
        }
    }
}
