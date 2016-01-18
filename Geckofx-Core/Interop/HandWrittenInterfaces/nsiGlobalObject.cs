using System;
using System.Runtime.InteropServices;

namespace Gecko
{

    [UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.ThisCall)]
    internal delegate IntPtr GetGlobalJSObject([MarshalAs(UnmanagedType.Interface)] nsIGlobalObject @this);

    /*#define NS_IGLOBALOBJECT_IID \
{ 0x11afa8be, 0xd997, 0x4e07, \
{ 0xa6, 0xa3, 0x6f, 0x87, 0x2e, 0xc3, 0xee, 0x7f } }*/

    [ComImport]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [Guid("11afa8be-d997-4e07-a6a3-6f872ec3ee7f")]
    public interface nsIGlobalObject
    {
        IntPtr GetGlobalJSObject();
    }
}