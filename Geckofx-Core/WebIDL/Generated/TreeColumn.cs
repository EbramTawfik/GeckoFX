namespace Gecko.WebIDL
{
    using System;
    
    
    public class TreeColumn : WebIDLBase
    {
        
        public TreeColumn(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsIDOMElement Element
        {
            get
            {
                return this.GetProperty<nsIDOMElement>("element");
            }
        }
        
        public nsISupports Columns
        {
            get
            {
                return this.GetProperty<nsISupports>("columns");
            }
        }
        
        public int X
        {
            get
            {
                return this.GetProperty<int>("x");
            }
        }
        
        public int Width
        {
            get
            {
                return this.GetProperty<int>("width");
            }
        }
        
        public nsAString Id
        {
            get
            {
                return this.GetProperty<nsAString>("id");
            }
        }
        
        public int Index
        {
            get
            {
                return this.GetProperty<int>("index");
            }
        }
        
        public bool Primary
        {
            get
            {
                return this.GetProperty<bool>("primary");
            }
        }
        
        public bool Cycler
        {
            get
            {
                return this.GetProperty<bool>("cycler");
            }
        }
        
        public bool Editable
        {
            get
            {
                return this.GetProperty<bool>("editable");
            }
        }
        
        public bool Selectable
        {
            get
            {
                return this.GetProperty<bool>("selectable");
            }
        }
        
        public short Type
        {
            get
            {
                return this.GetProperty<short>("type");
            }
        }
        
        public nsISupports GetNext()
        {
            return this.CallMethod<nsISupports>("getNext");
        }
        
        public nsISupports GetPrevious()
        {
            return this.CallMethod<nsISupports>("getPrevious");
        }
        
        public void Invalidate()
        {
            this.CallVoidMethod("invalidate");
        }
    }
}
