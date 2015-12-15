namespace Gecko.WebIDL
{
    using System;
    
    
    public class MenuBoxObject : WebIDLBase
    {
        
        public MenuBoxObject(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsIDOMElement ActiveChild
        {
            get
            {
                return this.GetProperty<nsIDOMElement>("activeChild");
            }
            set
            {
                this.SetProperty("activeChild", value);
            }
        }
        
        public bool OpenedWithKey
        {
            get
            {
                return this.GetProperty<bool>("openedWithKey");
            }
        }
        
        public void OpenMenu(bool openFlag)
        {
            this.CallVoidMethod("openMenu", openFlag);
        }
        
        public bool HandleKeyPress(nsISupports keyEvent)
        {
            return this.CallMethod<bool>("handleKeyPress", keyEvent);
        }
    }
}
