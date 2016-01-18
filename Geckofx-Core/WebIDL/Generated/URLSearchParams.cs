namespace Gecko.WebIDL
{
    using System;
    
    
    public class URLSearchParams : WebIDLBase
    {
        
        public URLSearchParams(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void Append(USVString name, USVString value)
        {
            this.CallVoidMethod("append", name, value);
        }
        
        public void Delete(USVString name)
        {
            this.CallVoidMethod("delete", name);
        }
        
        public USVString Get(USVString name)
        {
            return this.CallMethod<USVString>("get", name);
        }
        
        public USVString[] GetAll(USVString name)
        {
            return this.CallMethod<USVString[]>("getAll", name);
        }
        
        public bool Has(USVString name)
        {
            return this.CallMethod<bool>("has", name);
        }
        
        public void Set(USVString name, USVString value)
        {
            this.CallVoidMethod("set", name, value);
        }
    }
}
