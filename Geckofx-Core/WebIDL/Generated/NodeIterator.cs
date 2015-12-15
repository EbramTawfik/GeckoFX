namespace Gecko.WebIDL
{
    using System;
    
    
    public class NodeIterator : WebIDLBase
    {
        
        public NodeIterator(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsIDOMNode Root
        {
            get
            {
                return this.GetProperty<nsIDOMNode>("root");
            }
        }
        
        public nsIDOMNode ReferenceNode
        {
            get
            {
                return this.GetProperty<nsIDOMNode>("referenceNode");
            }
        }
        
        public bool PointerBeforeReferenceNode
        {
            get
            {
                return this.GetProperty<bool>("pointerBeforeReferenceNode");
            }
        }
        
        public uint WhatToShow
        {
            get
            {
                return this.GetProperty<uint>("whatToShow");
            }
        }
        
        public nsISupports Filter
        {
            get
            {
                return this.GetProperty<nsISupports>("filter");
            }
        }
        
        public nsIDOMNode NextNode()
        {
            return this.CallMethod<nsIDOMNode>("nextNode");
        }
        
        public nsIDOMNode PreviousNode()
        {
            return this.CallMethod<nsIDOMNode>("previousNode");
        }
        
        public void Detach()
        {
            this.CallVoidMethod("detach");
        }
    }
}
