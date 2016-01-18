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
        
        public string Name
        {
            get
            {
                return this.GetProperty<string>("name");
            }
            set
            {
                this.SetProperty("name", value);
            }
        }
        
        public string Placeholder
        {
            get
            {
                return this.GetProperty<string>("placeholder");
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
        
        public string Wrap
        {
            get
            {
                return this.GetProperty<string>("wrap");
            }
            set
            {
                this.SetProperty("wrap", value);
            }
        }
        
        public string Type
        {
            get
            {
                return this.GetProperty<string>("type");
            }
        }
        
        public string DefaultValue
        {
            get
            {
                return this.GetProperty<string>("defaultValue");
            }
            set
            {
                this.SetProperty("defaultValue", value);
            }
        }
        
        public string Value
        {
            get
            {
                return this.GetProperty<string>("value");
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
        
        public string ValidationMessage
        {
            get
            {
                return this.GetProperty<string>("validationMessage");
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
        
        public string SelectionDirection
        {
            get
            {
                return this.GetProperty<string>("selectionDirection");
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
        
        public void SetCustomValidity(string error)
        {
            this.CallVoidMethod("setCustomValidity", error);
        }
        
        public void Select()
        {
            this.CallVoidMethod("select");
        }
        
        public void SetRangeText(string replacement)
        {
            this.CallVoidMethod("setRangeText", replacement);
        }
        
        public void SetRangeText(string replacement, uint start, uint end)
        {
            this.CallVoidMethod("setRangeText", replacement, start, end);
        }
        
        public void SetRangeText(string replacement, uint start, uint end, SelectionMode selectionMode)
        {
            this.CallVoidMethod("setRangeText", replacement, start, end, selectionMode);
        }
        
        public void SetSelectionRange(uint start, uint end)
        {
            this.CallVoidMethod("setSelectionRange", start, end);
        }
        
        public void SetSelectionRange(uint start, uint end, string direction)
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
        
        public void SetUserInput(string input)
        {
            this.CallVoidMethod("setUserInput", input);
        }
    }
}
