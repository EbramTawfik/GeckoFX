namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozInputContextFocusEventDetail : WebIDLBase
    {
        
        public MozInputContextFocusEventDetail(nsISupports thisObject) : 
                base(thisObject)
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
        
        public nsAString Value
        {
            get
            {
                return this.GetProperty<nsAString>("value");
            }
        }
        
        public object Choices
        {
            get
            {
                return this.GetProperty<object>("choices");
            }
        }
        
        public nsAString Min
        {
            get
            {
                return this.GetProperty<nsAString>("min");
            }
        }
        
        public nsAString Max
        {
            get
            {
                return this.GetProperty<nsAString>("max");
            }
        }
    }
}
