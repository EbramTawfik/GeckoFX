namespace Gecko.WebIDL
{
    using System;
    
    
    public class Range : WebIDLBase
    {
        
        public Range(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsIDOMNode StartContainer
        {
            get
            {
                return this.GetProperty<nsIDOMNode>("startContainer");
            }
        }
        
        public uint StartOffset
        {
            get
            {
                return this.GetProperty<uint>("startOffset");
            }
        }
        
        public nsIDOMNode EndContainer
        {
            get
            {
                return this.GetProperty<nsIDOMNode>("endContainer");
            }
        }
        
        public uint EndOffset
        {
            get
            {
                return this.GetProperty<uint>("endOffset");
            }
        }
        
        public bool Collapsed
        {
            get
            {
                return this.GetProperty<bool>("collapsed");
            }
        }
        
        public nsIDOMNode CommonAncestorContainer
        {
            get
            {
                return this.GetProperty<nsIDOMNode>("commonAncestorContainer");
            }
        }
        
        public void SetStart(nsIDOMNode refNode, uint offset)
        {
            this.CallVoidMethod("setStart", refNode, offset);
        }
        
        public void SetEnd(nsIDOMNode refNode, uint offset)
        {
            this.CallVoidMethod("setEnd", refNode, offset);
        }
        
        public void SetStartBefore(nsIDOMNode refNode)
        {
            this.CallVoidMethod("setStartBefore", refNode);
        }
        
        public void SetStartAfter(nsIDOMNode refNode)
        {
            this.CallVoidMethod("setStartAfter", refNode);
        }
        
        public void SetEndBefore(nsIDOMNode refNode)
        {
            this.CallVoidMethod("setEndBefore", refNode);
        }
        
        public void SetEndAfter(nsIDOMNode refNode)
        {
            this.CallVoidMethod("setEndAfter", refNode);
        }
        
        public void Collapse()
        {
            this.CallVoidMethod("collapse");
        }
        
        public void Collapse(bool toStart)
        {
            this.CallVoidMethod("collapse", toStart);
        }
        
        public void SelectNode(nsIDOMNode refNode)
        {
            this.CallVoidMethod("selectNode", refNode);
        }
        
        public void SelectNodeContents(nsIDOMNode refNode)
        {
            this.CallVoidMethod("selectNodeContents", refNode);
        }
        
        public short CompareBoundaryPoints(ushort how, nsISupports sourceRange)
        {
            return this.CallMethod<short>("compareBoundaryPoints", how, sourceRange);
        }
        
        public void DeleteContents()
        {
            this.CallVoidMethod("deleteContents");
        }
        
        public nsISupports ExtractContents()
        {
            return this.CallMethod<nsISupports>("extractContents");
        }
        
        public nsISupports CloneContents()
        {
            return this.CallMethod<nsISupports>("cloneContents");
        }
        
        public void InsertNode(nsIDOMNode node)
        {
            this.CallVoidMethod("insertNode", node);
        }
        
        public void SurroundContents(nsIDOMNode newParent)
        {
            this.CallVoidMethod("surroundContents", newParent);
        }
        
        public nsISupports CloneRange()
        {
            return this.CallMethod<nsISupports>("cloneRange");
        }
        
        public void Detach()
        {
            this.CallVoidMethod("detach");
        }
        
        public bool IsPointInRange(nsIDOMNode node, uint offset)
        {
            return this.CallMethod<bool>("isPointInRange", node, offset);
        }
        
        public short ComparePoint(nsIDOMNode node, uint offset)
        {
            return this.CallMethod<short>("comparePoint", node, offset);
        }
        
        public bool IntersectsNode(nsIDOMNode node)
        {
            return this.CallMethod<bool>("intersectsNode", node);
        }
        
        public nsISupports CreateContextualFragment(nsAString fragment)
        {
            return this.CallMethod<nsISupports>("createContextualFragment", fragment);
        }
        
        public nsISupports GetClientRects()
        {
            return this.CallMethod<nsISupports>("getClientRects");
        }
        
        public nsISupports GetBoundingClientRect()
        {
            return this.CallMethod<nsISupports>("getBoundingClientRect");
        }
    }
}
