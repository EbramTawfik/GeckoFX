namespace Gecko.WebIDL
{
    using System;
    
    
    public class TreeWalker : WebIDLBase
    {
        
        public TreeWalker(nsISupports thisObject) : 
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
        
        public nsIDOMNode CurrentNode
        {
            get
            {
                return this.GetProperty<nsIDOMNode>("currentNode");
            }
            set
            {
                this.SetProperty("currentNode", value);
            }
        }
        
        public nsIDOMNode ParentNode()
        {
            return this.CallMethod<nsIDOMNode>("parentNode");
        }
        
        public nsIDOMNode FirstChild()
        {
            return this.CallMethod<nsIDOMNode>("firstChild");
        }
        
        public nsIDOMNode LastChild()
        {
            return this.CallMethod<nsIDOMNode>("lastChild");
        }
        
        public nsIDOMNode PreviousSibling()
        {
            return this.CallMethod<nsIDOMNode>("previousSibling");
        }
        
        public nsIDOMNode NextSibling()
        {
            return this.CallMethod<nsIDOMNode>("nextSibling");
        }
        
        public nsIDOMNode PreviousNode()
        {
            return this.CallMethod<nsIDOMNode>("previousNode");
        }
        
        public nsIDOMNode NextNode()
        {
            return this.CallMethod<nsIDOMNode>("nextNode");
        }
    }
}
