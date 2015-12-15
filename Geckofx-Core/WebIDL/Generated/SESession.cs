namespace Gecko.WebIDL
{
    using System;
    
    
    public class SESession : WebIDLBase
    {
        
        public SESession(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports Reader
        {
            get
            {
                return this.GetProperty<nsISupports>("reader");
            }
        }
        
        public bool IsClosed
        {
            get
            {
                return this.GetProperty<bool>("isClosed");
            }
        }
        
        public Promise < nsISupports > OpenLogicalChannel(IntPtr aid)
        {
            return this.CallMethod<Promise < nsISupports >>("openLogicalChannel", aid);
        }
        
        public Promise CloseAll()
        {
            return this.CallMethod<Promise>("closeAll");
        }
    }
}
