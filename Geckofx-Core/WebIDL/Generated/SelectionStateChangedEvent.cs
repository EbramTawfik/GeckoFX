namespace Gecko.WebIDL
{
    using System;
    
    
    public class SelectionStateChangedEvent : WebIDLBase
    {
        
        public SelectionStateChangedEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public bool Visible
        {
            get
            {
                return this.GetProperty<bool>("visible");
            }
        }
        
        public nsAString SelectedText
        {
            get
            {
                return this.GetProperty<nsAString>("selectedText");
            }
        }
        
        public nsISupports BoundingClientRect
        {
            get
            {
                return this.GetProperty<nsISupports>("boundingClientRect");
            }
        }
        
        public SelectionState[] States
        {
            get
            {
                return this.GetProperty<SelectionState[]>("states");
            }
        }
    }
}
