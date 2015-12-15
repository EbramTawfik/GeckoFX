namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozInputMethodManager : WebIDLBase
    {
        
        public MozInputMethodManager(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public void ShowAll()
        {
            this.CallVoidMethod("showAll");
        }
        
        public void Next()
        {
            this.CallVoidMethod("next");
        }
        
        public bool SupportsSwitching()
        {
            return this.CallMethod<bool>("supportsSwitching");
        }
        
        public void Hide()
        {
            this.CallVoidMethod("hide");
        }
        
        public void SetSupportsSwitchingTypes(MozInputMethodInputContextInputTypes[] types)
        {
            this.CallVoidMethod("setSupportsSwitchingTypes", types);
        }
    }
}
