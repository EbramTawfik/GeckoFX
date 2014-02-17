using System.Runtime.InteropServices;

namespace Gecko
{
	/// <summary>
	/// The IUnknown/nsISupports ptr for this interface can be retrieved by calling JS_GetContextPrivate on a JSContext*.
	/// </summary>
	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("513c2c1a-f4f1-44da-8e38-f40c309a5def")]
	public interface nsIScriptContext
	{
		// Methods on this interface aren't directly callable via (XP)COM, due to
		// them having the wrong calling convention. It may be possible to invoke the
		// methods by via the vtable.
	}
}