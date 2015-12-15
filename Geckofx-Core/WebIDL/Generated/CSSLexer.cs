namespace Gecko.WebIDL
{
    using System;
    
    
    public class CSSLexer : WebIDLBase
    {
        
        public CSSLexer(nsISupports thisObject) : 
                base(thisObject)
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
        
        public nsAString PerformEOFFixup(nsAString inputString, bool preserveBackslash)
        {
            return this.CallMethod<nsAString>("performEOFFixup", inputString, preserveBackslash);
        }
        
        public object NextToken()
        {
            return this.CallMethod<object>("nextToken");
        }
    }
}
