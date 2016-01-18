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
        
        public nsAString ReadAsBinaryString(nsIDOMBlob blob)
        {
            return this.CallMethod<nsAString>("readAsBinaryString", blob);
        }
        
        public nsAString ReadAsText(nsIDOMBlob blob)
        {
            return this.CallMethod<nsAString>("readAsText", blob);
        }
        
        public nsAString ReadAsText(nsIDOMBlob blob, nsAString encoding)
        {
            return this.CallMethod<nsAString>("readAsText", blob, encoding);
        }
        
        public nsAString ReadAsDataURL(nsIDOMBlob blob)
        {
            return this.CallMethod<nsAString>("readAsDataURL", blob);
        }
    }
}
