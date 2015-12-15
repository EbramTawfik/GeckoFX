namespace Gecko.WebIDL
{
    using System;
    
    
    public class AudioNodePassThrough : WebIDLBase
    {
        
        public AudioNodePassThrough(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public bool PassThrough
        {
            get
            {
                return this.GetProperty<bool>("passThrough");
            }
            set
            {
                this.SetProperty("passThrough", value);
            }
        }
    }
}
