namespace Gecko.WebIDL
{
    using System;
    
    
    public class ErrorEvent : WebIDLBase
    {
        
        public ErrorEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString Message
        {
            get
            {
                return this.GetProperty<nsAString>("message");
            }
        }
        
        public nsAString Filename
        {
            get
            {
                return this.GetProperty<nsAString>("filename");
            }
        }
        
        public uint Lineno
        {
            get
            {
                return this.GetProperty<uint>("lineno");
            }
        }
        
        public uint Colno
        {
            get
            {
                return this.GetProperty<uint>("colno");
            }
        }
        
        public object Error
        {
            get
            {
                return this.GetProperty<object>("error");
            }
        }
    }
}
