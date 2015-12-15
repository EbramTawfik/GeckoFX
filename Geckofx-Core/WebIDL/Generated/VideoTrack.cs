namespace Gecko.WebIDL
{
    using System;
    
    
    public class VideoTrack : WebIDLBase
    {
        
        public VideoTrack(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString Id
        {
            get
            {
                return this.GetProperty<nsAString>("id");
            }
        }
        
        public nsAString Kind
        {
            get
            {
                return this.GetProperty<nsAString>("kind");
            }
        }
        
        public nsAString Label
        {
            get
            {
                return this.GetProperty<nsAString>("label");
            }
        }
        
        public nsAString Language
        {
            get
            {
                return this.GetProperty<nsAString>("language");
            }
        }
        
        public bool Selected
        {
            get
            {
                return this.GetProperty<bool>("selected");
            }
            set
            {
                this.SetProperty("selected", value);
            }
        }
    }
}
