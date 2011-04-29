using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Skybound.Gecko.Editor;
using System.Runtime.CompilerServices;

namespace Skybound.Gecko.DOM
{
	[Guid("b33eb56c-3120-418c-892b-774b00c7dde8"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIDOMNSEditableElement : nsISupports
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		nsIEditor GetEditor();

		// This is similar to set .value on nsIDOMInput/TextAreaElements, but
		// handling of the value change is closer to the normal user input, so 
		// 'change' event for example will be dispatched when focusing out the
		// element.
		void SetUserInput([MarshalAs(UnmanagedType.LPStruct)] nsAString input);
	};

}

