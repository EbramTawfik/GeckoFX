namespace Gecko.WebIDL
{
    using System;
    
    
    public class IDBFileHandle : WebIDLBase
    {
        
        public IDBFileHandle(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports MutableFile
        {
            get
            {
                return this.GetProperty<nsISupports>("mutableFile");
            }
        }
        
        public nsISupports FileHandle
        {
            get
            {
                return this.GetProperty<nsISupports>("fileHandle");
            }
        }
        
        public FileMode Mode
        {
            get
            {
                return this.GetProperty<FileMode>("mode");
            }
        }
        
        public bool Active
        {
            get
            {
                return this.GetProperty<bool>("active");
            }
        }
        
        public System.Nullable<ulong> Location
        {
            get
            {
                return this.GetProperty<System.Nullable<ulong>>("location");
            }
            set
            {
                this.SetProperty("location", value);
            }
        }
        
        public nsISupports GetMetadata()
        {
            return this.CallMethod<nsISupports>("getMetadata");
        }
        
        public nsISupports GetMetadata(object parameters)
        {
            return this.CallMethod<nsISupports>("getMetadata", parameters);
        }
        
        public nsISupports ReadAsArrayBuffer(ulong size)
        {
            return this.CallMethod<nsISupports>("readAsArrayBuffer", size);
        }
        
        public nsISupports ReadAsText(ulong size)
        {
            return this.CallMethod<nsISupports>("readAsText", size);
        }
        
        public nsISupports ReadAsText(ulong size, string encoding)
        {
            return this.CallMethod<nsISupports>("readAsText", size, encoding);
        }
        
        public nsISupports Write(WebIDLUnion<System.String,IntPtr,IntPtr,nsIDOMBlob> value)
        {
            return this.CallMethod<nsISupports>("write", value);
        }
        
        public nsISupports Append(WebIDLUnion<System.String,IntPtr,IntPtr,nsIDOMBlob> value)
        {
            return this.CallMethod<nsISupports>("append", value);
        }
        
        public nsISupports Truncate()
        {
            return this.CallMethod<nsISupports>("truncate");
        }
        
        public nsISupports Truncate(ulong size)
        {
            return this.CallMethod<nsISupports>("truncate", size);
        }
        
        public nsISupports Flush()
        {
            return this.CallMethod<nsISupports>("flush");
        }
        
        public void Abort()
        {
            this.CallVoidMethod("abort");
        }
    }
}
