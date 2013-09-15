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
		public ValueTag Tag;

		public enum ValueTag : uint
		{
			Clear = 0xFFFFFF80,
			Int32 = Clear | 1,
			Undefined = Clear | 2,
			String = Clear | 5,
			Boolean = Clear | 3,
			Magic = Clear | 4,
			Null = Clear | 6,
			Object = Clear | 7
		}

		public bool IsNull
		{
			get { return Tag == ValueTag.Null; }
		}

		public bool IsUndefined
		{
			get { return Tag == ValueTag.Undefined; }
		}

		public bool IsBoolean
		{
			get { return Tag == ValueTag.Boolean; }
		}

		public bool IsNumber
		{
			get { return Tag <= ValueTag.Int32; }
		}

		public bool IsInt
		{
			get { return Tag == ValueTag.Int32; }
		}

		public bool IsDouble
		{
			get { return Tag <= ValueTag.Clear; }
		}

		public bool IsString
		{
			get { return Tag == ValueTag.String; }
		}

		public bool IsObject
		{
			get { return Tag == ValueTag.Object; }
		}

		public bool ToBoolean()
		{
			return Boo != 0;
		}

		public double ToDouble()
		{
			return AsDouble;
		}

		public int ToInteger()
		{
			return I32;
		}

		public override string ToString()
		{
			using (var context = new AutoJSContext())
			{
				var stringPointer = SpiderMonkey.JS_ValueToString(context.ContextPointer, this);
				var encodedStringPointer = SpiderMonkey.JS_EncodeString(context.ContextPointer, stringPointer);
				var text = Marshal.PtrToStringAnsi(encodedStringPointer);

				return text ?? "";
			}
		}

		public object ToObject()
		{
			if (IsNull)
			{
				return null;
			}
			if (IsUndefined)
			{
				return "Undefined";
			}

			if (IsBoolean)
			{
				return ToBoolean();
			}

			if (IsInt)
			{
				return ToInteger();
			}

			if (IsDouble)
			{
				return ToDouble();
			}

			if (IsString)
			{
				return ToString();
			}

			if (IsObject)
			{
				return ToComObject();
			}

			return null;
		}

		private Object ToComObject()
		{
			using (var context = new AutoJSContext())
			{
				var jsObject = SpiderMonkey.JS_ValueToObject(context.ContextPointer, this);

				var guid = typeof(nsISupports).GUID;
				var pUnk = IntPtr.Zero;
				try
				{
					pUnk = Xpcom.XPConnect.Instance.WrapJS(context.ContextPointer, jsObject, ref guid);
					var comObj = Xpcom.GetObjectForIUnknown(pUnk);

					return comObj;
				}
				finally
				{
					if (pUnk != IntPtr.Zero)
					{
						Marshal.Release(pUnk);
					}
				}
			}
		}

		public JSType Type
		{
			get
			{
				using (var context = new AutoJSContext())
				{
					return SpiderMonkey.JS_TypeOfValue(context.ContextPointer, this);
				}
			}
		}
	}
}