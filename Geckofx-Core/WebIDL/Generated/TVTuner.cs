namespace Gecko.WebIDL
{
    using System;
    
    
    public class TVTuner : WebIDLBase
    {
        
        public TVTuner(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString Id
        {
            get
            {
                return this.GetProperty<nsAString>("id");
            }
        }
        
        public nsISupports CurrentSource
        {
            get
            {
                return this.GetProperty<nsISupports>("currentSource");
            }
        }
        
        public nsISupports Stream
        {
            get
            {
                return this.GetProperty<nsISupports>("stream");
            }
        }
        
        public TVSourceType[] GetSupportedSourceTypes()
        {
            return this.CallMethod<TVSourceType[]>("getSupportedSourceTypes");
        }
        
        public Promise < nsISupports[] > GetSources()
        {
            return this.CallMethod<Promise < nsISupports[] >>("getSources");
        }
        
        public Promise SetCurrentSource(TVSourceType sourceType)
        {
            return this.CallMethod<Promise>("setCurrentSource", sourceType);
        }
    }
}
