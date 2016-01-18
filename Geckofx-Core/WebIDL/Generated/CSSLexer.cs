namespace Gecko.WebIDL
{
    using System;
    
    
    public class CSSLexer : WebIDLBase
    {
        
        public CSSLexer(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public uint LineNumber
        {
            get
            {
                return this.GetProperty<uint>("lineNumber");
            }
        }
        
        public uint ColumnNumber
        {
            get
            {
                return this.GetProperty<uint>("columnNumber");
            }
        }
        
        public string PerformEOFFixup(string inputString, bool preserveBackslash)
        {
            return this.CallMethod<string>("performEOFFixup", inputString, preserveBackslash);
        }
        
        public object NextToken()
        {
            return this.CallMethod<object>("nextToken");
        }
    }
}
