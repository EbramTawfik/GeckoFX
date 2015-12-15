namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozSettingsEvent : WebIDLBase
    {
        
        public MozSettingsEvent(nsISupports thisObject) : 
                base(thisObject)
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
