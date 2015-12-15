namespace Gecko.WebIDL
{
    using System;
    
    
    public class XPathResult : WebIDLBase
    {
        
        public XPathResult(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public ushort ResultType
        {
            get
            {
                return this.GetProperty<ushort>("resultType");
            }
        }
        
        public double NumberValue
        {
            get
            {
                return this.GetProperty<double>("numberValue");
            }
        }
        
        public nsAString StringValue
        {
            get
            {
                return this.GetProperty<nsAString>("stringValue");
            }
        }
        
        public bool BooleanValue
        {
            get
            {
                return this.GetProperty<bool>("booleanValue");
            }
        }
        
        public nsIDOMNode SingleNodeValue
        {
            get
            {
                return this.GetProperty<nsIDOMNode>("singleNodeValue");
            }
        }
        
        public bool InvalidIteratorState
        {
            get
            {
                return this.GetProperty<bool>("invalidIteratorState");
            }
        }
        
        public uint SnapshotLength
        {
            get
            {
                return this.GetProperty<uint>("snapshotLength");
            }
        }
        
        public nsIDOMNode IterateNext()
        {
            return this.CallMethod<nsIDOMNode>("iterateNext");
        }
        
        public nsIDOMNode SnapshotItem(uint index)
        {
            return this.CallMethod<nsIDOMNode>("snapshotItem", index);
        }
    }
}
