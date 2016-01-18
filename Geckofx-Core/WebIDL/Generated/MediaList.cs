namespace Gecko.WebIDL
{
    using System;
    
    
    public class MediaList : WebIDLBase
    {
        
        public MediaList(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string MediaText
        {
            get
            {
                return this.GetProperty<string>("mediaText");
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
        
        public void DeleteMedium(string oldMedium)
        {
            this.CallVoidMethod("deleteMedium", oldMedium);
        }
        
        public void AppendMedium(string newMedium)
        {
            this.CallVoidMethod("appendMedium", newMedium);
        }
    }
}
