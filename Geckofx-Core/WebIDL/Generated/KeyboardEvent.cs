namespace Gecko.WebIDL
{
    using System;
    
    
    public class KeyboardEvent : WebIDLBase
    {
        
        public KeyboardEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public uint CharCode
        {
            get
            {
                return this.GetProperty<uint>("charCode");
            }
        }
        
        public uint KeyCode
        {
            get
            {
                return this.GetProperty<uint>("keyCode");
            }
        }
        
        public bool AltKey
        {
            get
            {
                return this.GetProperty<bool>("altKey");
            }
        }
        
        public bool CtrlKey
        {
            get
            {
                return this.GetProperty<bool>("ctrlKey");
            }
        }
        
        public bool ShiftKey
        {
            get
            {
                return this.GetProperty<bool>("shiftKey");
            }
        }
        
        public bool MetaKey
        {
            get
            {
                return this.GetProperty<bool>("metaKey");
            }
        }
        
        public uint Location
        {
            get
            {
                return this.GetProperty<uint>("location");
            }
        }
        
        public bool Repeat
        {
            get
            {
                return this.GetProperty<bool>("repeat");
            }
        }
        
        public bool IsComposing
        {
            get
            {
                return this.GetProperty<bool>("isComposing");
            }
        }
        
        public string Key
        {
            get
            {
                return this.GetProperty<string>("key");
            }
        }
        
        public string Code
        {
            get
            {
                return this.GetProperty<string>("code");
            }
        }
        
        public bool GetModifierState(string key)
        {
            return this.CallMethod<bool>("getModifierState", key);
        }
    }
}
