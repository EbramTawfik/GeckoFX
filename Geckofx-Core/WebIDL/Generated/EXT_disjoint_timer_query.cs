namespace Gecko.WebIDL
{
    using System;
    
    
    public class EXT_disjoint_timer_query : WebIDLBase
    {
        
        public EXT_disjoint_timer_query(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports CreateQueryEXT()
        {
            return this.CallMethod<nsISupports>("createQueryEXT");
        }
        
        public void DeleteQueryEXT(nsISupports query)
        {
            this.CallVoidMethod("deleteQueryEXT", query);
        }
        
        public bool IsQueryEXT(nsISupports query)
        {
            return this.CallMethod<bool>("isQueryEXT", query);
        }
        
        public void BeginQueryEXT(UInt32 target, nsISupports query)
        {
            this.CallVoidMethod("beginQueryEXT", target, query);
        }
        
        public void EndQueryEXT(UInt32 target)
        {
            this.CallVoidMethod("endQueryEXT", target);
        }
        
        public void QueryCounterEXT(nsISupports query, UInt32 target)
        {
            this.CallVoidMethod("queryCounterEXT", query, target);
        }
        
        public object GetQueryEXT(UInt32 target, UInt32 pname)
        {
            return this.CallMethod<object>("getQueryEXT", target, pname);
        }
        
        public object GetQueryObjectEXT(nsISupports query, UInt32 pname)
        {
            return this.CallMethod<object>("getQueryObjectEXT", query, pname);
        }
    }
}
