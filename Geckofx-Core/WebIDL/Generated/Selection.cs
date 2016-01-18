namespace Gecko.WebIDL
{
    using System;
    
    
    public class Selection : WebIDLBase
    {
        
        public Selection(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsIDOMNode AnchorNode
        {
            get
            {
                return this.GetProperty<nsIDOMNode>("anchorNode");
            }
        }
        
        public uint AnchorOffset
        {
            get
            {
                return this.GetProperty<uint>("anchorOffset");
            }
        }
        
        public nsIDOMNode FocusNode
        {
            get
            {
                return this.GetProperty<nsIDOMNode>("focusNode");
            }
        }
        
        public uint FocusOffset
        {
            get
            {
                return this.GetProperty<uint>("focusOffset");
            }
        }
        
        public bool IsCollapsed
        {
            get
            {
                return this.GetProperty<bool>("isCollapsed");
            }
        }
        
        public uint RangeCount
        {
            get
            {
                return this.GetProperty<uint>("rangeCount");
            }
        }
        
        public void Collapse(nsIDOMNode node, uint offset)
        {
            this.CallVoidMethod("collapse", node, offset);
        }
        
        public void CollapseToStart()
        {
            this.CallVoidMethod("collapseToStart");
        }
        
        public void CollapseToEnd()
        {
            this.CallVoidMethod("collapseToEnd");
        }
        
        public void Extend(nsIDOMNode node, uint offset)
        {
            this.CallVoidMethod("extend", node, offset);
        }
        
        public void SelectAllChildren(nsIDOMNode node)
        {
            this.CallVoidMethod("selectAllChildren", node);
        }
        
        public void DeleteFromDocument()
        {
            this.CallVoidMethod("deleteFromDocument");
        }
        
        public nsISupports GetRangeAt(uint index)
        {
            return this.CallMethod<nsISupports>("getRangeAt", index);
        }
        
        public void AddRange(nsISupports range)
        {
            this.CallVoidMethod("addRange", range);
        }
        
        public void RemoveRange(nsISupports range)
        {
            this.CallVoidMethod("removeRange", range);
        }
        
        public void RemoveAllRanges()
        {
            this.CallVoidMethod("removeAllRanges");
        }
        
        public bool ContainsNode(nsIDOMNode node, bool allowPartialContainment)
        {
            return this.CallMethod<bool>("containsNode", node, allowPartialContainment);
        }
        
        public void Modify(nsAString alter, nsAString direction, nsAString granularity)
        {
            this.CallVoidMethod("modify", alter, direction, granularity);
        }
        
        public bool InterlinePosition
        {
            get
            {
                return this.GetProperty<bool>("interlinePosition");
            }
            set
            {
                this.SetProperty("interlinePosition", value);
            }
        }
        
        public System.Nullable<short> CaretBidiLevel
        {
            get
            {
                return this.GetProperty<System.Nullable<short>>("caretBidiLevel");
            }
            set
            {
                this.SetProperty("caretBidiLevel", value);
            }
        }
        
        public short Type
        {
            get
            {
                return this.GetProperty<short>("type");
            }
        }
        
        public nsAString ToStringWithFormat(nsAString formatType, uint flags, int wrapColumn)
        {
            return this.CallMethod<nsAString>("toStringWithFormat", formatType, flags, wrapColumn);
        }
        
        public void AddSelectionListener(nsISupports newListener)
        {
            this.CallVoidMethod("addSelectionListener", newListener);
        }
        
        public void RemoveSelectionListener(nsISupports listenerToRemove)
        {
            this.CallVoidMethod("removeSelectionListener", listenerToRemove);
        }
        
        public nsISupports[] GetRangesForInterval(nsIDOMNode beginNode, int beginOffset, nsIDOMNode endNode, int endOffset, bool allowAdjacent)
        {
            return this.CallMethod<nsISupports[]>("GetRangesForInterval", beginNode, beginOffset, endNode, endOffset, allowAdjacent);
        }
        
        public void ScrollIntoView(short aRegion, bool aIsSynchronous, short aVPercent, short aHPercent)
        {
            this.CallVoidMethod("scrollIntoView", aRegion, aIsSynchronous, aVPercent, aHPercent);
        }
    }
}
