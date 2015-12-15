namespace Gecko.WebIDL
{
    using System;
    
    
    public class FormData : WebIDLBase
    {
        
        public FormData(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public void Append(USVString name, nsIDOMBlob value, USVString filename)
        {
            this.CallVoidMethod("append", name, value, filename);
        }
        
        public void Append(USVString name, USVString value)
        {
            this.CallVoidMethod("append", name, value);
        }
        
        public void Delete(USVString name)
        {
            this.CallVoidMethod("delete", name);
        }
        
        public WebIDLUnion<nsISupports,USVString> Get(USVString name)
        {
            return this.CallMethod<WebIDLUnion<nsISupports,USVString>>("get", name);
        }
        
        public WebIDLUnion<nsISupports,USVString> GetAll(USVString name)
        {
            return this.CallMethod<WebIDLUnion<nsISupports,USVString>>("getAll", name);
        }
        
        public bool Has(USVString name)
        {
            return this.CallMethod<bool>("has", name);
        }
        
        public void Set(USVString name, nsIDOMBlob value, USVString filename)
        {
            this.CallVoidMethod("set", name, value, filename);
        }
        
        public void Set(USVString name, USVString value)
        {
            this.CallVoidMethod("set", name, value);
        }
    }
}
