namespace Gecko.WebIDL
{
    using System;
    
    
    public class FontFaceSet : WebIDLBase
    {
        
        public FontFaceSet(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public uint Size
        {
            get
            {
                return this.GetProperty<uint>("size");
            }
        }
        
        public Promise Ready
        {
            get
            {
                return this.GetProperty<Promise>("ready");
            }
        }
        
        public FontFaceSetLoadStatus Status
        {
            get
            {
                return this.GetProperty<FontFaceSetLoadStatus>("status");
            }
        }
        
        public void Add(nsISupports font)
        {
            this.CallVoidMethod("add", font);
        }
        
        public bool Has(nsISupports font)
        {
            return this.CallMethod<bool>("has", font);
        }
        
        public bool Delete(nsISupports font)
        {
            return this.CallMethod<bool>("delete", font);
        }
        
        public void Clear()
        {
            this.CallVoidMethod("clear");
        }
        
        public nsISupports Entries()
        {
            return this.CallMethod<nsISupports>("entries");
        }
        
        public nsISupports Values()
        {
            return this.CallMethod<nsISupports>("values");
        }
        
        public Promise < nsISupports[] > Load(nsAString font)
        {
            return this.CallMethod<Promise < nsISupports[] >>("load", font);
        }
        
        public Promise < nsISupports[] > Load(nsAString font, nsAString text)
        {
            return this.CallMethod<Promise < nsISupports[] >>("load", font, text);
        }
        
        public bool Check(nsAString font)
        {
            return this.CallMethod<bool>("check", font);
        }
        
        public bool Check(nsAString font, nsAString text)
        {
            return this.CallMethod<bool>("check", font, text);
        }
    }
}
