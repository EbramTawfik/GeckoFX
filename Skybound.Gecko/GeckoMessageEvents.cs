//License MPL, the GPL or the LGPL.

using System;
using System.Runtime.InteropServices;

namespace Skybound.Gecko
{
	/// <summary>
	/// Provides data about a DOM event.
	/// </summary>
	public class GeckoDomMessageEventArgs : GeckoDomEventArgs
	{

		private nsIDOMMessageEvent _event;

		internal GeckoDomMessageEventArgs(nsIDOMMessageEvent ev)
			: base(ev)
		{
			_event = ev;
		}
		
		public string Message
		{
			get
			{
				IntPtr jsVal = _event.GetDataAttribute();
				using (AutoJSContext context = new AutoJSContext())
				{
					return Marshal.PtrToStringAnsi(JS_EncodeString(context.ContextPointer, ValToString(jsVal)));
				}
			}
		}

		#region Interop
		private enum ValueTag : uint
		{
			Clear = 0xFFFF0000,
			Int32 = Clear | 1,
			Undefined = Clear | 2,
			String = Clear | 5,
			Boolean = Clear | 3,
			Magic = Clear | 4,
			Null = Clear | 6,
			Object = Clear | 7
		}

		[StructLayout(LayoutKind.Explicit)]
		private struct JSValLayout
		{
			[FieldOffset(0)]
			public ulong AsBits;
			[FieldOffset(0)]
			public double AsDouble;
			[FieldOffset(0)]
			public IntPtr AsPtr;
			[FieldOffset(0)]
			public int I32;
			[FieldOffset(0)]
			public uint U32;
			[FieldOffset(0)]
			public int Boo;
			[FieldOffset(0)]
			public IntPtr Ptr;
			[FieldOffset(4)]
			public ValueTag Tag;
		}

		[DllImport("mozjs", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr JS_EncodeString(IntPtr cx, IntPtr str);
		private IntPtr ValToString(IntPtr value)
		{
			var layout = new JSValLayout();
			layout.AsBits = (ulong) value;
			return layout.Ptr;
		}
		#endregion
	}
}
