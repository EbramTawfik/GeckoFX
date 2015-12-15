namespace Gecko.WebIDL
{
    using System;
    
    
    public class TimeEvent : WebIDLBase
    {
        
        public TimeEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public int Detail
        {
            get
            {
                return this.GetProperty<int>("detail");
            }
        }
        
        public nsIDOMWindow View
        {
            get
            {
                return this.GetProperty<nsIDOMWindow>("view");
            }
        }
        
        public void InitTimeEvent(nsAString aType, nsIDOMWindow aView, int aDetail)
        {
            this.CallVoidMethod("initTimeEvent", aType, aView, aDetail);
        }
    }
}
