namespace Gecko.WebIDL
{
    using System;
    
    
    public class FileReader : WebIDLBase
    {
        
        public FileReader(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public ushort ReadyState
        {
            get
            {
                return this.GetProperty<ushort>("readyState");
            }
        }
        
        public object Result
        {
            get
            {
                return this.GetProperty<object>("result");
            }
        }
        
        public nsISupports Error
        {
            get
            {
                return this.GetProperty<nsISupports>("error");
            }
        }
        
        public void ReadAsArrayBuffer(nsIDOMBlob blob)
        {
            this.CallVoidMethod("readAsArrayBuffer", blob);
        }
        
        public void ReadAsText(nsIDOMBlob blob)
        {
            this.CallVoidMethod("readAsText", blob);
        }
        
        public void ReadAsText(nsIDOMBlob blob, nsAString label)
        {
            this.CallVoidMethod("readAsText", blob, label);
        }
        
        public void ReadAsDataURL(nsIDOMBlob blob)
        {
            this.CallVoidMethod("readAsDataURL", blob);
        }
        
        public void Abort()
        {
            this.CallVoidMethod("abort");
        }
        
        public void ReadAsBinaryString(nsIDOMBlob filedata)
        {
            this.CallVoidMethod("readAsBinaryString", filedata);
        }
    }
}
