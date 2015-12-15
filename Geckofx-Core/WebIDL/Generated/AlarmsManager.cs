namespace Gecko.WebIDL
{
    using System;
    
    
    public class AlarmsManager : WebIDLBase
    {
        
        public AlarmsManager(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports GetAll()
        {
            return this.CallMethod<nsISupports>("getAll");
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
