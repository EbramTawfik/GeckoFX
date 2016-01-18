namespace Gecko.WebIDL
{
    using System;
    
    
    public class External : WebIDLBase
    {
        
        public External(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void AddSearchProvider(nsAString aDescriptionURL)
        {
            this.CallVoidMethod("AddSearchProvider", aDescriptionURL);
        }
        
        public uint IsSearchProviderInstalled(nsAString aSearchURL)
        {
            return this.CallMethod<uint>("IsSearchProviderInstalled", aSearchURL);
        }
        
        public void AddSearchEngine(nsAString engineURL, nsAString iconURL, nsAString suggestedTitle, nsAString suggestedCategory)
        {
            this.CallVoidMethod("addSearchEngine", engineURL, iconURL, suggestedTitle, suggestedCategory);
        }
    }
}
