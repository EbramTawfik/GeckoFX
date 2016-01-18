namespace Gecko.WebIDL
{
    using System;
    
    
    public class MutationRecord : WebIDLBase
    {
        
        public MutationRecord(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Type
        {
            get
            {
                return this.GetProperty<string>("type");
            }
        }
        
        public nsIDOMNode Target
        {
            get
            {
                return this.GetProperty<nsIDOMNode>("target");
            }
        }
        
        public nsISupports AddedNodes
        {
            get
            {
                return this.GetProperty<nsISupports>("addedNodes");
            }
        }
        
        public nsISupports RemovedNodes
        {
            get
            {
                return this.GetProperty<nsISupports>("removedNodes");
            }
        }
        
        public nsIDOMNode PreviousSibling
        {
            get
            {
                return this.GetProperty<nsIDOMNode>("previousSibling");
            }
        }
        
        public nsIDOMNode NextSibling
        {
            get
            {
                return this.GetProperty<nsIDOMNode>("nextSibling");
            }
        }
        
        public string AttributeName
        {
            get
            {
                return this.GetProperty<string>("attributeName");
            }
        }
        
        public string AttributeNamespace
        {
            get
            {
                return this.GetProperty<string>("attributeNamespace");
            }
        }
        
        public string OldValue
        {
            get
            {
                return this.GetProperty<string>("oldValue");
            }
        }
        
        public nsISupports[] AddedAnimations
        {
            get
            {
                return this.GetProperty<nsISupports[]>("addedAnimations");
            }
        }
        
        public nsISupports[] ChangedAnimations
        {
            get
            {
                return this.GetProperty<nsISupports[]>("changedAnimations");
            }
        }
        
        public nsISupports[] RemovedAnimations
        {
            get
            {
                return this.GetProperty<nsISupports[]>("removedAnimations");
            }
        }
    }
}
