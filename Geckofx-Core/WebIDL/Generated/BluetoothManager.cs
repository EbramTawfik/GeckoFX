namespace Gecko.WebIDL
{
    using System;
    
    
    public class BluetoothManager : WebIDLBase
    {
        
        public BluetoothManager(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports DefaultAdapter
        {
            get
            {
                return this.GetProperty<nsISupports>("defaultAdapter");
            }
        }
        
        public nsISupports[] GetAdapters()
        {
            return this.CallMethod<nsISupports[]>("getAdapters");
        }
    }
}
