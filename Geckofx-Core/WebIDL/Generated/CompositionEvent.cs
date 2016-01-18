namespace Gecko.WebIDL
{
    using System;
    
    
    public class CompositionEvent : WebIDLBase
    {
        
        public CompositionEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString Data
        {
            get
            {
                return this.GetProperty<nsAString>("data");
            }
        }
        
        public nsAString Locale
        {
            get
            {
                return this.GetProperty<nsAString>("locale");
            }
        }
        
        public void InitCompositionEvent(nsAString typeArg, bool canBubbleArg, bool cancelableArg, nsIDOMWindow viewArg, nsAString dataArg, nsAString localeArg)
        {
            this.CallVoidMethod("initCompositionEvent", typeArg, canBubbleArg, cancelableArg, viewArg, dataArg, localeArg);
        }
    }
}
