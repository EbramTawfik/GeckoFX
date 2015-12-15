namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozIdleObserver : WebIDLBase
    {
        
        public MozIdleObserver(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public uint Time
        {
            get
            {
                return this.GetProperty<uint>("time");
            }
        }
        
        public void Onidle()
        {
            this.CallVoidMethod("onidle");
        }
        
        public void Onactive()
        {
            this.CallVoidMethod("onactive");
        }
    }
}
