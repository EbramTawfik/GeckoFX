namespace Gecko.WebIDL
{
    using System;
    
    
    public class WebrtcGlobalInformation : WebIDLBase
    {
        
        public WebrtcGlobalInformation(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public int DebugLevel
        {
            get
            {
                return this.GetProperty<int>("debugLevel");
            }
            set
            {
                this.SetProperty("debugLevel", value);
            }
        }
        
        public bool AecDebug
        {
            get
            {
                return this.GetProperty<bool>("aecDebug");
            }
            set
            {
                this.SetProperty("aecDebug", value);
            }
        }
    }
}
