namespace Gecko.WebIDL
{
    using System;
    
    
    public class CompositionEvent : WebIDLBase
    {
        
        public CompositionEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Data
        {
            get
            {
                return this.GetProperty<string>("data");
            }
        }
        
        public string Locale
        {
            get
            {
                return this.GetProperty<string>("locale");
            }
        }
        
        public void InitCompositionEvent(string typeArg, bool canBubbleArg, bool cancelableArg, nsIDOMWindow viewArg, string dataArg, string localeArg)
        {
            this.CallVoidMethod("initCompositionEvent", typeArg, canBubbleArg, cancelableArg, viewArg, dataArg, localeArg);
        }
    }
}
