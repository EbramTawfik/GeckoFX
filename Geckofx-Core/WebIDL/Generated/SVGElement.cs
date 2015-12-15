namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGElement : WebIDLBase
    {
        
        public SVGElement(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString Id
        {
            get
            {
                return this.GetProperty<nsAString>("id");
            }
            set
            {
                this.SetProperty("id", value);
            }
        }
        
        public nsISupports ClassName
        {
            get
            {
                return this.GetProperty<nsISupports>("className");
            }
        }
        
        public nsIDOMCSSStyleDeclaration Style
        {
            get
            {
                return this.GetProperty<nsIDOMCSSStyleDeclaration>("style");
            }
        }
        
        public nsISupports OwnerSVGElement
        {
            get
            {
                return this.GetProperty<nsISupports>("ownerSVGElement");
            }
        }
        
        public nsISupports ViewportElement
        {
            get
            {
                return this.GetProperty<nsISupports>("viewportElement");
            }
        }
    }
}
