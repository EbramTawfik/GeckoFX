namespace Gecko.WebIDL
{
    using System;
    
    
    public class Blob : WebIDLBase
    {
        
        public Blob(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public ulong Size
        {
            get
            {
                return this.GetProperty<ulong>("size");
            }
        }
        
        public nsAString Type
        {
            get
            {
                return this.GetProperty<nsAString>("type");
            }
        }
        
        public nsIDOMBlob Slice(long start, long end, nsAString contentType)
        {
            return this.CallMethod<nsIDOMBlob>("slice", start, end, contentType);
        }
    }
}
