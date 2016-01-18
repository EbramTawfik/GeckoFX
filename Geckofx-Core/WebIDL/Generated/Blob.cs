namespace Gecko.WebIDL
{
    using System;
    
    
    public class Blob : WebIDLBase
    {
        
        public Blob(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public ulong Size
        {
            get
            {
                return this.GetProperty<ulong>("size");
            }
        }
        
        public string Type
        {
            get
            {
                return this.GetProperty<string>("type");
            }
        }
        
        public nsIDOMBlob Slice()
        {
            return this.CallMethod<nsIDOMBlob>("slice");
        }
        
        public nsIDOMBlob Slice(long start)
        {
            return this.CallMethod<nsIDOMBlob>("slice", start);
        }
        
        public nsIDOMBlob Slice(long start, long end)
        {
            return this.CallMethod<nsIDOMBlob>("slice", start, end);
        }
        
        public nsIDOMBlob Slice(long start, long end, string contentType)
        {
            return this.CallMethod<nsIDOMBlob>("slice", start, end, contentType);
        }
    }
}
