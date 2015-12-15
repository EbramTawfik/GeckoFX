namespace Gecko.WebIDL
{
    using System;
    
    
    public class BoxObject : WebIDLBase
    {
        
        public BoxObject(nsISupports thisObject) : 
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
        
        public int X
        {
            get
            {
                return this.GetProperty<int>("x");
            }
        }
        
        public int Y
        {
            get
            {
                return this.GetProperty<int>("y");
            }
        }
        
        public int ScreenX
        {
            get
            {
                return this.GetProperty<int>("screenX");
            }
        }
        
        public int ScreenY
        {
            get
            {
                return this.GetProperty<int>("screenY");
            }
        }
        
        public int Width
        {
            get
            {
                return this.GetProperty<int>("width");
            }
        }
        
        public int Height
        {
            get
            {
                return this.GetProperty<int>("height");
            }
        }
        
        public nsIDOMElement ParentBox
        {
            get
            {
                return this.GetProperty<nsIDOMElement>("parentBox");
            }
        }
        
        public nsIDOMElement FirstChild
        {
            get
            {
                return this.GetProperty<nsIDOMElement>("firstChild");
            }
        }
        
        public nsIDOMElement LastChild
        {
            get
            {
                return this.GetProperty<nsIDOMElement>("lastChild");
            }
        }
        
        public nsIDOMElement NextSibling
        {
            get
            {
                return this.GetProperty<nsIDOMElement>("nextSibling");
            }
        }
        
        public nsIDOMElement PreviousSibling
        {
            get
            {
                return this.GetProperty<nsIDOMElement>("previousSibling");
            }
        }
        
        public nsISupports GetPropertyAsSupports(nsAString propertyName)
        {
            return this.CallMethod<nsISupports>("getPropertyAsSupports", propertyName);
        }
        
        public void SetPropertyAsSupports(nsAString propertyName, nsISupports value)
        {
            this.CallVoidMethod("setPropertyAsSupports", propertyName, value);
        }
        
        public nsAString GetProperty(nsAString propertyName)
        {
            return this.CallMethod<nsAString>("getProperty", propertyName);
        }
        
        public void SetProperty(nsAString propertyName, nsAString propertyValue)
        {
            this.CallVoidMethod("setProperty", propertyName, propertyValue);
        }
        
        public void RemoveProperty(nsAString propertyName)
        {
            this.CallVoidMethod("removeProperty", propertyName);
        }
    }
}
