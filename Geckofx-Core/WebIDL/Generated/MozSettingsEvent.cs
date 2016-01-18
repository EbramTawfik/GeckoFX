namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozSettingsEvent : WebIDLBase
    {
        
        public MozSettingsEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string SettingName
        {
            get
            {
                return this.GetProperty<string>("settingName");
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
