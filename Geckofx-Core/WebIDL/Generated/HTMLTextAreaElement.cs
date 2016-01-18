namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLTextAreaElement : WebIDLBase
    {
        
        public HTMLTextAreaElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public bool Autofocus
        {
            get
            {
                return this.GetProperty<bool>("autofocus");
            }
            set
            {
                this.SetProperty("autofocus", value);
            }
        }
        
        public uint Cols
        {
            get
            {
                return this.GetProperty<uint>("cols");
            }
            set
            {
                this.SetProperty("cols", value);
            }
        }
        
        public bool Disabled
        {
            get
            {
                return this.GetProperty<bool>("disabled");
            }
            set
            {
                this.SetProperty("disabled", value);
            }
        }
        
        public nsISupports Form
        {
            get
            {
                return this.GetProperty<nsISupports>("form");
            }
        }
        
        public int MaxLength
        {
            get
            {
                return this.GetProperty<int>("maxLength");
            }
            set
            {
                this.SetProperty("maxLength", value);
            }
        }
        
        public nsAString Name
        {
            get
            {
                return this.GetProperty<nsAString>("name");
            }
            set
            {
                this.SetProperty("name", value);
            }
        }
        
        public nsAString Placeholder
        {
            get
            {
                return this.GetProperty<nsAString>("placeholder");
            }
            set
            {
                this.SetProperty("placeholder", value);
            }
        }
        
        public bool ReadOnly
        {
            get
            {
                return this.GetProperty<bool>("readOnly");
            }
            set
            {
                this.SetProperty("readOnly", value);
            }
        }
        
        public bool Required
        {
            get
            {
                return this.GetProperty<bool>("required");
            }
            set
            {
                this.SetProperty("required", value);
            }
        }
        
        public uint Rows
        {
            get
            {
                return this.GetProperty<uint>("rows");
            }
            set
            {
                this.SetProperty("rows", value);
            }
        }
        
        public nsAString Wrap
        {
            get
            {
                return this.GetProperty<nsAString>("wrap");
            }
            set
            {
                this.SetProperty("wrap", value);
            }
        }
        
        public nsAString Type
        {
            get
            {
                return this.GetProperty<nsAString>("type");
            }
        }
        
        public nsAString DefaultValue
        {
            get
            {
                return this.GetProperty<nsAString>("defaultValue");
            }
            set
            {
                this.SetProperty("defaultValue", value);
            }
        }
        
        public nsAString Value
        {
            get
            {
                return this.GetProperty<nsAString>("value");
            }
            set
            {
                this.SetProperty("value", value);
            }
        }
        
        public uint TextLength
        {
            get
            {
                return this.GetProperty<uint>("textLength");
            }
        }
        
        public bool WillValidate
        {
            get
            {
                return this.GetProperty<bool>("willValidate");
            }
        }
        
        public nsISupports Validity
        {
            get
            {
                return this.GetProperty<nsISupports>("validity");
            }
        }
        
        public nsAString ValidationMessage
        {
            get
            {
                return this.GetProperty<nsAString>("validationMessage");
            }
        }
        
        public uint SelectionStart
        {
            get
            {
                return this.GetProperty<uint>("selectionStart");
            }
            set
            {
                this.SetProperty("selectionStart", value);
            }
        }
        
        public uint SelectionEnd
        {
            get
            {
                return this.GetProperty<uint>("selectionEnd");
            }
            set
            {
                this.SetProperty("selectionEnd", value);
            }
        }
        
        public nsAString SelectionDirection
        {
            get
            {
                return this.GetProperty<nsAString>("selectionDirection");
            }
            set
            {
                this.SetProperty("selectionDirection", value);
            }
        }
        
        public bool CheckValidity()
        {
            return this.CallMethod<bool>("checkValidity");
        }
        
        public void SetCustomValidity(nsAString error)
        {
            this.CallVoidMethod("setCustomValidity", error);
        }
        
        public void Select()
        {
            this.CallVoidMethod("select");
        }
        
        public void SetRangeText(nsAString replacement)
        {
            this.CallVoidMethod("setRangeText", replacement);
        }
        
        public void SetRangeText(nsAString replacement, uint start, uint end)
        {
            this.CallVoidMethod("setRangeText", replacement, start, end);
        }
        
        public void SetRangeText(nsAString replacement, uint start, uint end, SelectionMode selectionMode)
        {
            this.CallVoidMethod("setRangeText", replacement, start, end, selectionMode);
        }
        
        public void SetSelectionRange(uint start, uint end)
        {
            this.CallVoidMethod("setSelectionRange", start, end);
        }
        
        public void SetSelectionRange(uint start, uint end, nsAString direction)
        {
            this.CallVoidMethod("setSelectionRange", start, end, direction);
        }
        
        public nsISupports Controllers
        {
            get
            {
                return this.GetProperty<nsISupports>("controllers");
            }
        }
        
        public nsISupports Editor
        {
            get
            {
                return this.GetProperty<nsISupports>("editor");
            }
        }
        
        public void SetUserInput(nsAString input)
        {
            this.CallVoidMethod("setUserInput", input);
        }
    }
}
