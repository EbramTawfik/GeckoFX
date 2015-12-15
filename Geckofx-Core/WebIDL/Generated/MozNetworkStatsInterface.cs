namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozNetworkStatsInterface : WebIDLBase
    {
        
        public MozNetworkStatsInterface(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public int Type
        {
            get
            {
                return this.GetProperty<int>("type");
            }
        }
        
        public nsAString Id
        {
            get
            {
                return this.GetProperty<nsAString>("id");
            }
        }
    }
}
