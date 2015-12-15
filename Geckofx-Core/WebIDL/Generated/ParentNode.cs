namespace Gecko.WebIDL
{
    using System;
    
    
    public class ParentNode : WebIDLBase
    {
        
        public ParentNode(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports Children
        {
            get
            {
                return this.GetProperty<nsISupports>("children");
            }
        }
        
        public nsIDOMElement FirstElementChild
        {
            get
            {
                return this.GetProperty<nsIDOMElement>("firstElementChild");
            }
        }
        
        public nsIDOMElement LastElementChild
        {
            get
            {
                return this.GetProperty<nsIDOMElement>("lastElementChild");
            }
        }
        
        public uint ChildElementCount
        {
            get
            {
                return this.GetProperty<uint>("childElementCount");
            }
        }
    }
}
