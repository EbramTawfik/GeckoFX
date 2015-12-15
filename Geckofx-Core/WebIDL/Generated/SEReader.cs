namespace Gecko.WebIDL
{
    using System;
    
    
    public class SEReader : WebIDLBase
    {
        
        public SEReader(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public bool IsSEPresent
        {
            get
            {
                return this.GetProperty<bool>("isSEPresent");
            }
        }
        
        public SEType Type
        {
            get
            {
                return this.GetProperty<SEType>("type");
            }
        }
        
        public Promise < nsISupports > OpenSession()
        {
            return this.CallMethod<Promise < nsISupports >>("openSession");
        }
        
        public Promise CloseAll()
        {
            return this.CallMethod<Promise>("closeAll");
        }
    }
}
