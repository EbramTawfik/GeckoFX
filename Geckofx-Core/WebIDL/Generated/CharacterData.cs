namespace Gecko.WebIDL
{
    using System;
    
    
    public class CharacterData : WebIDLBase
    {
        
        public CharacterData(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString Data
        {
            get
            {
                return this.GetProperty<nsAString>("data");
            }
            set
            {
                this.SetProperty("data", value);
            }
        }
        
        public uint Length
        {
            get
            {
                return this.GetProperty<uint>("length");
            }
        }
        
        public nsAString SubstringData(uint offset, uint count)
        {
            return this.CallMethod<nsAString>("substringData", offset, count);
        }
        
        public void AppendData(nsAString data)
        {
            this.CallVoidMethod("appendData", data);
        }
        
        public void InsertData(uint offset, nsAString data)
        {
            this.CallVoidMethod("insertData", offset, data);
        }
        
        public void DeleteData(uint offset, uint count)
        {
            this.CallVoidMethod("deleteData", offset, count);
        }
        
        public void ReplaceData(uint offset, uint count, nsAString data)
        {
            this.CallVoidMethod("replaceData", offset, count, data);
        }
    }
}
