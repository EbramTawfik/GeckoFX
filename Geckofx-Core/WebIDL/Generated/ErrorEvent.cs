namespace Gecko.WebIDL
{
    using System;
    
    
    public class ErrorEvent : WebIDLBase
    {
        
        public ErrorEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Message
        {
            get
            {
                return this.GetProperty<string>("message");
            }
        }
        
        public string Filename
        {
            get
            {
                return this.GetProperty<string>("filename");
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
