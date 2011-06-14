using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Skybound.Gecko.XpCom
{
	/// <summary>
	/// Custom Marshaler for xpcom/xulrunner native type wstring wstring
	/// 
	/// To use managed type string as parameter and apply attribute:
	/// [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string
	/// or for string return types use:
	/// [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")]
	/// </summary>
	public class WStringMarshaler : ICustomMarshaler
	{
		public void CleanUpManagedData(object ManagedObj)
		{
			
		}

		public void CleanUpNativeData(IntPtr pNativeData)
		{			
			Xpcom.Free(pNativeData);
		}

		public int GetNativeDataSize()
		{
			return Marshal.SizeOf(IntPtr.Zero);
		}

		/// <summary>
		/// Convert the passed string to Utf16 encoded string 
		/// written to memory allocated by xpcom/xulrunner itself.
		/// </summary>
		/// <param name="ManagedObj"></param>
		/// <returns>ptr to native memory containing utf16 encoded string + null term</returns>
		public IntPtr MarshalManagedToNative(object ManagedObj)
		{			
			var str = ManagedObj as string;
			var bytes = System.Text.Encoding.Unicode.GetBytes(str);
			IntPtr unmangedMemory = Xpcom.Alloc(bytes.Length + 2);
			for (int i = 0; i < bytes.Length; ++i)
			{
				Marshal.WriteByte(unmangedMemory, i, bytes[i]);
			}

			Marshal.WriteByte(unmangedMemory, bytes.Length, 0);
			Marshal.WriteByte(unmangedMemory, bytes.Length + 1, 0);

			return unmangedMemory;
		}

		/// <summary>
		/// Convert 
		/// </summary>
		/// <param name="pNativeData"></param>
		/// <returns>copy of native ut16 string as managed string.</returns>
		public object MarshalNativeToManaged(IntPtr pNativeData)
		{			
			return Marshal.PtrToStringUni(pNativeData);
		}

		static ICustomMarshaler GetInstance(string pstrCookie)
		{			
			return new WStringMarshaler();
		}
	}
}
