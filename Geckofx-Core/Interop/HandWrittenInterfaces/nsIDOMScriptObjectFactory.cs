using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko
{
    /*
     * System.IntPtr ptr = (IntPtr)Xpcom.GetService(new Guid("9eb760f0-4380-11d2-b328-00805f8a3859"));
       var instance = (nsIDOMScriptObjectFactory)Xpcom.GetObjectForIUnknown(ptr);
     * */

    [ComImport]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [Guid("2a50e17c-46ff-4150-bb46-d807b336deab")]
    public interface nsIDOMScriptObjectFactory
    {
        // WARNING - not proper COM methods        
        [return: MarshalAs(UnmanagedType.Interface)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [PreserveSig]
        nsIClassInfo DONTUSE_GetClassInfoInstance(uint aID);

        // WARNING - not proper COM methods
        [return: MarshalAs(UnmanagedType.Interface)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [PreserveSig]
        nsISupports DONTUSE_GetExternalClassInfoInstance(
            [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName);

        // TODO: this is untested and most likely won't work without futher changes.       

        // Register the info for an external class. aName must be static
        // data, it will not be deleted by the DOM code. aProtoChainInterface
        // must be registered in the JAVASCRIPT_DOM_INTERFACE category, or
        // prototypes for this class won't work (except if the interface
        // name starts with nsIDOM).
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void RegisterDOMClassInfo(string aName,
            IntPtr /*nsDOMClassInfoExternalConstructorFnc*/ aConstructorFptr,
            System.Guid aProtoChainInterface,
            ref System.Guid aInterfaces,
            uint aScriptableFlags,
            bool aHasClassInterface,
            System.Guid aConstructorCID);

        // see also type for nsDOMClassInfoExternalConstructor:
        /*
         * 
         *    typedef nsXPCClassInfo* (*nsDOMClassInfoExternalConstructorFnc)
         *       (const char* aName);
         * 
         * */
    }
}