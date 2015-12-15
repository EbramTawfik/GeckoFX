namespace Gecko.WebIDL
{
    using System;
    
    
    public class ContactManager : WebIDLBase
    {
        
        public ContactManager(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports Find(object options)
        {
            return this.CallMethod<nsISupports>("find", options);
        }
        
        public nsISupports GetAll(object options)
        {
            return this.CallMethod<nsISupports>("getAll", options);
        }
        
        public nsISupports Clear()
        {
            return this.CallMethod<nsISupports>("clear");
        }
        
        public nsISupports Save(nsISupports contact)
        {
            return this.CallMethod<nsISupports>("save", contact);
        }
        
        public nsISupports Remove(WebIDLUnion<nsISupports,nsAString> contactOrId)
        {
            return this.CallMethod<nsISupports>("remove", contactOrId);
        }
        
        public nsISupports GetRevision()
        {
            return this.CallMethod<nsISupports>("getRevision");
        }
        
        public nsISupports GetCount()
        {
            return this.CallMethod<nsISupports>("getCount");
        }
    }
}
