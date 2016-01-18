namespace Gecko.WebIDL
{
    using System;
    
    
    public class AlarmsManager : WebIDLBase
    {
        
        public AlarmsManager(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports GetAll()
        {
            return this.CallMethod<nsISupports>("getAll");
        }
        
        public nsISupports Add(object date, nsAString respectTimezone)
        {
            return this.CallMethod<nsISupports>("add", date, respectTimezone);
        }
        
        public nsISupports Add(object date, nsAString respectTimezone, object data)
        {
            return this.CallMethod<nsISupports>("add", date, respectTimezone, data);
        }
        
        public void Remove(uint id)
        {
            this.CallVoidMethod("remove", id);
        }
    }
}
