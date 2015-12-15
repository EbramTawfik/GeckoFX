namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGStringList : WebIDLBase
    {
        
        public SVGStringList(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public uint Length
        {
            get
            {
                return this.GetProperty<uint>("length");
            }
        }
        
        public uint NumberOfItems
        {
            get
            {
                return this.GetProperty<uint>("numberOfItems");
            }
        }
        
        public void Clear()
        {
            this.CallVoidMethod("clear");
        }
        
        public nsAString Initialize(nsAString newItem)
        {
            return this.CallMethod<nsAString>("initialize", newItem);
        }
        
        public nsAString GetItem(uint index)
        {
            return this.CallMethod<nsAString>("getItem", index);
        }
        
        public nsAString InsertItemBefore(nsAString newItem, uint index)
        {
            return this.CallMethod<nsAString>("insertItemBefore", newItem, index);
        }
        
        public nsAString ReplaceItem(nsAString newItem, uint index)
        {
            return this.CallMethod<nsAString>("replaceItem", newItem, index);
        }
        
        public nsAString RemoveItem(uint index)
        {
            return this.CallMethod<nsAString>("removeItem", index);
        }
        
        public nsAString AppendItem(nsAString newItem)
        {
            return this.CallMethod<nsAString>("appendItem", newItem);
        }
    }
}
