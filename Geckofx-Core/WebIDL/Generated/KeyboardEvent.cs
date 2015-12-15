namespace Gecko.WebIDL
{
    using System;
    
    
    public class KeyboardEvent : WebIDLBase
    {
        
        public KeyboardEvent(nsISupports thisObject) : 
                base(thisObject)
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
        
        public nsAString Key
        {
            get
            {
                return this.GetProperty<nsAString>("key");
            }
        }
        
        public nsAString Code
        {
            get
            {
                return this.GetProperty<nsAString>("code");
            }
        }
        
        public bool GetModifierState(nsAString key)
        {
            return this.CallMethod<bool>("getModifierState", key);
        }
    }
}
