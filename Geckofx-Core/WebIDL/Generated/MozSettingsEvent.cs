namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozSettingsEvent : WebIDLBase
    {
        
        public MozSettingsEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString SettingName
        {
            get
            {
                return this.GetProperty<nsAString>("settingName");
            }
        }
        
        public object SettingValue
        {
            get
            {
                return this.GetProperty<object>("settingValue");
            }
        }
    }
}
