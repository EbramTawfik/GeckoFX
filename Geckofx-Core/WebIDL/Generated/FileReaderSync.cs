namespace Gecko.WebIDL
{
    using System;
    
    
    public class FileReaderSync : WebIDLBase
    {
        
        public FileReaderSync(nsISupports thisObject) : 
                base(thisObject)
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
