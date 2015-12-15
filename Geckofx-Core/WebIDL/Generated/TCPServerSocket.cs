namespace Gecko.WebIDL
{
    using System;
    
    
    public class TCPServerSocket : WebIDLBase
    {
        
        public TCPServerSocket(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public ushort LocalPort
        {
            get
            {
                return this.GetProperty<ushort>("localPort");
            }
        }
        
        public void Close()
        {
            this.CallVoidMethod("close");
        }
    }
}
