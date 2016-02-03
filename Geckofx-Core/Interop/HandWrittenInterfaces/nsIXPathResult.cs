using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko
{
    /// <summary>
    /// The IUnknown/nsISupports ptr for this interface can be retrieved by calling JS_GetContextPrivate on a JSContext*.
    /// </summary>
    [ComImport]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [Guid("662f2c9a-c7cd-4cab-9349-e733df5a838c")]
    public interface nsIXPathResult
    {
        // Methods on this object are defined by WebIdl.
        // We call them via the SpiderMonkey api's.
        // (eg. JS_CallFunctionName, JS_GetProperty)
        // Ideally we would generate a nsIXPathResult wrapper class directly from webidl defs.
    }
}