namespace Gecko.WebIDL
{
    using System;
    
    
    public class MediaList : WebIDLBase
    {
        
        public MediaList(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString MediaText
        {
            get
            {
                return this.GetProperty<nsAString>("mediaText");
            }
            set
            {
                this.SetProperty("mediaText", value);
            }
        }
        
        public uint Length
        {
            get
            {
                return this.GetProperty<uint>("length");
            }
        }
        
        public void DeleteMedium(nsAString oldMedium)
        {
            this.CallVoidMethod("deleteMedium", oldMedium);
        }
        
        public void AppendMedium(nsAString newMedium)
        {
            this.CallVoidMethod("appendMedium", newMedium);
        }
    }
}
