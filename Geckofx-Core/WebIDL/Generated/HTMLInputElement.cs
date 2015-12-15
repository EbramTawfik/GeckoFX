namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLInputElement : WebIDLBase
    {
        
        public HTMLInputElement(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString Accept
        {
            get
            {
                return this.GetProperty<nsAString>("accept");
            }
            set
            {
                this.SetProperty("accept", value);
            }
        }
        
        public nsAString Alt
        {
            get
            {
                return this.GetProperty<nsAString>("alt");
            }
            set
            {
                this.SetProperty("alt", value);
            }
        }
        
        public nsAString Autocomplete
        {
            get
            {
                return this.GetProperty<nsAString>("autocomplete");
            }
            set
            {
                this.SetProperty("autocomplete", value);
            }
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
        
        public bool DefaultChecked
        {
            get
            {
                return this.GetProperty<bool>("defaultChecked");
            }
            set
            {
                this.SetProperty("defaultChecked", value);
            }
        }
        
        public bool Checked
        {
            get
            {
                return this.GetProperty<bool>("checked");
            }
            set
            {
                this.SetProperty("checked", value);
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
        
        public nsISupports Files
        {
            get
            {
                return this.GetProperty<nsISupports>("files");
            }
        }
        
        public nsAString FormAction
        {
            get
            {
                return this.GetProperty<nsAString>("formAction");
            }
            set
            {
                this.SetProperty("formAction", value);
            }
        }
        
        public nsAString FormEnctype
        {
            get
            {
                return this.GetProperty<nsAString>("formEnctype");
            }
            set
            {
                this.SetProperty("formEnctype", value);
            }
        }
        
        public nsAString FormMethod
        {
            get
            {
                return this.GetProperty<nsAString>("formMethod");
            }
            set
            {
                this.SetProperty("formMethod", value);
            }
        }
        
        public bool FormNoValidate
        {
            get
            {
                return this.GetProperty<bool>("formNoValidate");
            }
            set
            {
                this.SetProperty("formNoValidate", value);
            }
        }
        
        public nsAString FormTarget
        {
            get
            {
                return this.GetProperty<nsAString>("formTarget");
            }
            set
            {
                this.SetProperty("formTarget", value);
            }
        }
        
        public uint Height
        {
            get
            {
                return this.GetProperty<uint>("height");
            }
            set
            {
                this.SetProperty("height", value);
            }
        }
        
        public bool Indeterminate
        {
            get
            {
                return this.GetProperty<bool>("indeterminate");
            }
            set
            {
                this.SetProperty("indeterminate", value);
            }
        }
        
        public nsAString InputMode
        {
            get
            {
                return this.GetProperty<nsAString>("inputMode");
            }
            set
            {
                this.SetProperty("inputMode", value);
            }
        }
        
        public nsISupports List
        {
            get
            {
                return this.GetProperty<nsISupports>("list");
            }
        }
        
        public nsAString Max
        {
            get
            {
                return this.GetProperty<nsAString>("max");
            }
            set
            {
                this.SetProperty("max", value);
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
        
        public nsAString Min
        {
            get
            {
                return this.GetProperty<nsAString>("min");
            }
            set
            {
                this.SetProperty("min", value);
            }
        }
        
        public bool Multiple
        {
            get
            {
                return this.GetProperty<bool>("multiple");
            }
            set
            {
                this.SetProperty("multiple", value);
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
        
        public nsAString Pattern
        {
            get
            {
                return this.GetProperty<nsAString>("pattern");
            }
            set
            {
                this.SetProperty("pattern", value);
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
        
        public uint Size
        {
            get
            {
                return this.GetProperty<uint>("size");
            }
            set
            {
                this.SetProperty("size", value);
            }
        }
        
        public nsAString Src
        {
            get
            {
                return this.GetProperty<nsAString>("src");
            }
            set
            {
                this.SetProperty("src", value);
            }
        }
        
        public nsAString Step
        {
            get
            {
                return this.GetProperty<nsAString>("step");
            }
            set
            {
                this.SetProperty("step", value);
            }
        }
        
        public nsAString Type
        {
            get
            {
                return this.GetProperty<nsAString>("type");
            }
            set
            {
                this.SetProperty("type", value);
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
        
        public IntPtr ValueAsDate
        {
            get
            {
                return this.GetProperty<IntPtr>("valueAsDate");
            }
            set
            {
                this.SetProperty("valueAsDate", value);
            }
        }
        
        public double ValueAsNumber
        {
            get
            {
                return this.GetProperty<double>("valueAsNumber");
            }
            set
            {
                this.SetProperty("valueAsNumber", value);
            }
        }
        
        public uint Width
        {
            get
            {
                return this.GetProperty<uint>("width");
            }
            set
            {
                this.SetProperty("width", value);
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
        
        public int SelectionStart
        {
            get
            {
                return this.GetProperty<int>("selectionStart");
            }
            set
            {
                this.SetProperty("selectionStart", value);
            }
        }
        
        public int SelectionEnd
        {
            get
            {
                return this.GetProperty<int>("selectionEnd");
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
        
        public void StepUp(int n)
        {
            this.CallVoidMethod("stepUp", n);
        }
        
        public void StepDown(int n)
        {
            this.CallVoidMethod("stepDown", n);
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
        
        public void SetRangeText(nsAString replacement, uint start, uint end, SelectionMode selectionMode)
        {
            this.CallVoidMethod("setRangeText", replacement, start, end, selectionMode);
        }
        
        public nsAString Align
        {
            get
            {
                return this.GetProperty<nsAString>("align");
            }
            set
            {
                this.SetProperty("align", value);
            }
        }
        
        public nsAString UseMap
        {
            get
            {
                return this.GetProperty<nsAString>("useMap");
            }
            set
            {
                this.SetProperty("useMap", value);
            }
        }
        
        public nsISupports Controllers
        {
            get
            {
                return this.GetProperty<nsISupports>("controllers");
            }
        }
        
        public int TextLength
        {
            get
            {
                return this.GetProperty<int>("textLength");
            }
        }
        
        public nsISupports OwnerNumberControl
        {
            get
            {
                return this.GetProperty<nsISupports>("ownerNumberControl");
            }
        }
        
        public void SetSelectionRange(int start, int end, nsAString direction)
        {
            this.CallVoidMethod("setSelectionRange", start, end, direction);
        }
        
        public nsAString[] MozGetFileNameArray()
        {
            return this.CallMethod<nsAString[]>("mozGetFileNameArray");
        }
        
        public void MozSetFileNameArray(nsAString[] fileNames)
        {
            this.CallVoidMethod("mozSetFileNameArray", fileNames);
        }
        
        public void MozSetFileArray(nsISupports[] files)
        {
            this.CallVoidMethod("mozSetFileArray", files);
        }
        
        public bool MozIsTextField(bool aExcludePassword)
        {
            return this.CallMethod<bool>("mozIsTextField", aExcludePassword);
        }
        
        public object GetAutocompleteInfo()
        {
            return this.CallMethod<object>("getAutocompleteInfo");
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
        
        public bool Directory
        {
            get
            {
                return this.GetProperty<bool>("directory");
            }
            set
            {
                this.SetProperty("directory", value);
            }
        }
        
        public bool IsFilesAndDirectoriesSupported
        {
            get
            {
                return this.GetProperty<bool>("isFilesAndDirectoriesSupported");
            }
        }
        
        public Promise < WebIDLUnion<nsISupports,nsISupports>> GetFilesAndDirectories()
        {
            return this.CallMethod<Promise < WebIDLUnion<nsISupports,nsISupports>>>("getFilesAndDirectories");
        }
        
        public void ChooseDirectory()
        {
            this.CallVoidMethod("chooseDirectory");
        }
    }
}
