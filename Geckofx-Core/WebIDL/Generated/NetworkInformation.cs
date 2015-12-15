namespace Gecko.WebIDL
{
    using System;
    
    
    public class NetworkInformation : WebIDLBase
    {
        
        public NetworkInformation(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public ConnectionType Type
        {
            get
            {
                return this.GetProperty<ConnectionType>("type");
            }
        }
    }
}
