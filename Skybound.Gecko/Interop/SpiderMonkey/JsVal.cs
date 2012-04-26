using System.Runtime.InteropServices;
using System;
namespace Gecko
{

	/// <summary>
	/// This is just a piece of a JsVal implementation, just enough to get the message out.
	/// netmonkey and spidermonkeydotnet have fuller implementations
	/// </summary>
	/// <remarks>
	/// 		/// WARNING:
	/// https://developer.mozilla.org/En/SpiderMonkey/JSAPI_Reference/Jsval
	/// Says: "jsval is a variant type whose exact representation varies by architecture.  
	///			Embeddings should not rely on observed representation details, the size of jsval, 
	///			or whether jsval is a primitive type."
	///	In the code below, we are just using API calls to access it, except for the attempt to get at the value tag directly (which didn't work).
	///		
	/// </remarks>
	[StructLayout(LayoutKind.Explicit)]
	public struct JsVal
	{
		public static JsVal FromPtr(ulong value)
		{
			return new JsVal() { AsBits = value };
		}

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
		public ulong Ptr;
		[FieldOffset(4)]
		public ValueTag Tag;	//this is suspect

		public enum ValueTag : uint
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

		/// <summary>
		/// Return true if JsVal is a string type.
		/// </summary>
		public bool IsString
		{
			get
			{
				return Type == JSType.JSTYPE_STRING;
			}
		}


		public JSType Type
		{
			get
			{
				using (AutoJSContext context = new AutoJSContext())
				{
					return SpiderMonkey.JS_TypeOfValue(context.ContextPointer, Ptr);
				}
			}
		}

		public override string ToString()
		{
			if (!IsString)
				throw new NotImplementedException("JsVal.ToString() only supported when the type is String.");

			using (AutoJSContext context = new AutoJSContext())
			{
				IntPtr jsString = SpiderMonkey.JS_ValueToString(context.ContextPointer, this);
				return Marshal.PtrToStringAnsi(SpiderMonkey.JS_EncodeString(context.ContextPointer, jsString));
			}
		}
	}
}
