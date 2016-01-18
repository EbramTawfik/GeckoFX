namespace Gecko.WebIDL
{
    using System;
    
    
    public class FileReaderSync : WebIDLBase
    {
        
        public FileReaderSync(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public IntPtr ReadAsArrayBuffer(nsIDOMBlob blob)
        {
            return this.CallMethod<IntPtr>("readAsArrayBuffer", blob);
        }
        
        public string ReadAsBinaryString(nsIDOMBlob blob)
        {
            return this.CallMethod<string>("readAsBinaryString", blob);
        }
        
        public string ReadAsText(nsIDOMBlob blob)
        {
            return this.CallMethod<string>("readAsText", blob);
        }
        
        public string ReadAsText(nsIDOMBlob blob, string encoding)
        {
            return this.CallMethod<string>("readAsText", blob, encoding);
        }
        
        public string ReadAsDataURL(nsIDOMBlob blob)
        {
            return this.CallMethod<string>("readAsDataURL", blob);
        }
    }
}
