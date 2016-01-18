namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozInputContextFocusEventDetail : WebIDLBase
    {
        
        public MozInputContextFocusEventDetail(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public MozInputMethodInputContextTypes Type
        {
            get
            {
                return this.GetProperty<MozInputMethodInputContextTypes>("type");
            }
        }
        
        public MozInputMethodInputContextInputTypes InputType
        {
            get
            {
                return this.GetProperty<MozInputMethodInputContextInputTypes>("inputType");
            }
        }
        
        public string Value
        {
            get
            {
                return this.GetProperty<string>("value");
            }
        }
        
        public object Choices
        {
            get
            {
                return this.GetProperty<object>("choices");
            }
        }
        
        public string Min
        {
            get
            {
                return this.GetProperty<string>("min");
            }
        }
        
        public string Max
        {
            get
            {
                return this.GetProperty<string>("max");
            }
        }
    }
}
