namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozInputMethod : WebIDLBase
    {
        
        public MozInputMethod(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Mgmt
        {
            get
            {
                return this.GetProperty<nsISupports>("mgmt");
            }
        }
        
        public nsISupports Inputcontext
        {
            get
            {
                return this.GetProperty<nsISupports>("inputcontext");
            }
        }
        
        public void SetActive(bool isActive)
        {
            this.CallVoidMethod("setActive", isActive);
        }
        
        public Promise AddInput(string inputId, object inputManifest)
        {
            return this.CallMethod<Promise>("addInput", inputId, inputManifest);
        }
        
        public Promise RemoveInput(string id)
        {
            return this.CallMethod<Promise>("removeInput", id);
        }
        
        public void RemoveFocus()
        {
            this.CallVoidMethod("removeFocus");
        }
        
        public void SetValue(string value)
        {
            this.CallVoidMethod("setValue", value);
        }
        
        public void SetSelectedOption(int index)
        {
            this.CallVoidMethod("setSelectedOption", index);
        }
        
        public void SetSelectedOptions(int[] indexes)
        {
            this.CallVoidMethod("setSelectedOptions", indexes);
        }
    }
}
