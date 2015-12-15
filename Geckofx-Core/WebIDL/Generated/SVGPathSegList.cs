namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGPathSegList : WebIDLBase
    {
        
        public SVGPathSegList(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public uint NumberOfItems
        {
            get
            {
                return this.GetProperty<uint>("numberOfItems");
            }
        }
        
        public uint Length
        {
            get
            {
                return this.GetProperty<uint>("length");
            }
        }
        
        public void Clear()
        {
            this.CallVoidMethod("clear");
        }
        
        public nsISupports Initialize(nsISupports newItem)
        {
            return this.CallMethod<nsISupports>("initialize", newItem);
        }
        
        public nsISupports InsertItemBefore(nsISupports newItem, uint index)
        {
            return this.CallMethod<nsISupports>("insertItemBefore", newItem, index);
        }
        
        public nsISupports ReplaceItem(nsISupports newItem, uint index)
        {
            return this.CallMethod<nsISupports>("replaceItem", newItem, index);
        }
        
        public nsISupports RemoveItem(uint index)
        {
            return this.CallMethod<nsISupports>("removeItem", index);
        }
        
        public nsISupports AppendItem(nsISupports newItem)
        {
            return this.CallMethod<nsISupports>("appendItem", newItem);
        }
    }
}
