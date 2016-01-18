namespace Gecko.WebIDL
{
    using System;
    
    
    public class CharacterData : WebIDLBase
    {
        
        public CharacterData(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Data
        {
            get
            {
                return this.GetProperty<string>("data");
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
        
        public string SubstringData(uint offset, uint count)
        {
            return this.CallMethod<string>("substringData", offset, count);
        }
        
        public void AppendData(string data)
        {
            this.CallVoidMethod("appendData", data);
        }
        
        public void InsertData(uint offset, string data)
        {
            this.CallVoidMethod("insertData", offset, data);
        }
        
        public void DeleteData(uint offset, uint count)
        {
            this.CallVoidMethod("deleteData", offset, count);
        }
        
        public void ReplaceData(uint offset, uint count, string data)
        {
            this.CallVoidMethod("replaceData", offset, count, data);
        }
    }
}
