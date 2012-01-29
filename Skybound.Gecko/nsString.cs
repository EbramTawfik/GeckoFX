#region ***** BEGIN LICENSE BLOCK *****
/* Version: MPL 1.1/GPL 2.0/LGPL 2.1
 *
 * The contents of this file are subject to the Mozilla Public License Version
 * 1.1 (the "License"); you may not use this file except in compliance with
 * the License. You may obtain a copy of the License at
 * http://www.mozilla.org/MPL/
 *
 * Software distributed under the License is distributed on an "AS IS" basis,
 * WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
 * for the specific language governing rights and limitations under the
 * License.
 *
 * The Original Code is Skybound Software code.
 *
 * The Initial Developer of the Original Code is Skybound Software.
 * Portions created by the Initial Developer are Copyright (C) 2008-2009
 * the Initial Developer. All Rights Reserved.
 *
 * Contributor(s):
 *
 * Alternatively, the contents of this file may be used under the terms of
 * either the GNU General Public License Version 2 or later (the "GPL"), or
 * the GNU Lesser General Public License Version 2.1 or later (the "LGPL"),
 * in which case the provisions of the GPL or the LGPL are applicable instead
 * of those above. If you wish to allow use of your version of this file only
 * under the terms of either the GPL or the LGPL, and not to allow others to
 * use your version of this file under the terms of the MPL, indicate your
 * decision by deleting the provisions above and replace them with the notice
 * and other provisions required by the GPL or the LGPL. If you do not delete
 * the provisions above, a recipient may use your version of this file under
 * the terms of any one of the MPL, the GPL or the LGPL.
 */
#endregion END LICENSE BLOCK

using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko
{
	/// <summary>
	/// Provides helper methods to get and set string attributes on XPCOM interfaces.
	/// </summary>
	public static class nsString
	{
		#region nsAUTF8String
		
		public delegate void StringAttributeUtf8(nsAUTF8String str);
		
		public static string Get(StringAttributeUtf8 getter)
		{
			using (nsAUTF8String str = new nsAUTF8String())
			{
				getter(str);
				return str.ToString();
			}
		}
		
		public static void Set(StringAttributeUtf8 setter, string value)
		{
			using (nsAUTF8String str = new nsAUTF8String())
			{
				if (!string.IsNullOrEmpty(value))
					str.SetData(value);
				
				setter(str);
			}
		}

		/// <summary>
		/// Passes <paramref name="value"/> to function and return value
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="func"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public static T Pass<T>(Func<nsAUTF8String, T> func, string value)
		{
			T ret;
			using (nsAUTF8String str = new nsAUTF8String(value))
			{
				//this is already checked in nsAUTF8String constructor
				//if (!string.IsNullOrEmpty(value))
				//	str.SetData(value);

				ret = func(str);
			}
			return ret;
		}

		public static T Pass<T,TW> (Func<TW,nsAUTF8String,T> func,TW value,string stringValue )
		{
			T ret;
			using (nsAUTF8String str = new nsAUTF8String(stringValue))
			{
				ret = func( value, str );
			}
			return ret;
		}
		#endregion

		#region nsACString
		
		public delegate void StringAttributeAnsi(nsACString str);
		
		public static string Get(StringAttributeAnsi getter)
		{
			using (nsACString str = new nsACString())
			{
				getter(str);
				return str.ToString();
			}
		}

		public static string Get(Action<nsACString,nsACString> getter,string inValue)
		{
			using (nsACString nativeIn = new nsACString(inValue), nativeOut = new nsACString())
			{
				//if (!string.IsNullOrEmpty(inValue))
				//    nativeIn.SetData( inValue );

				getter( nativeIn, nativeOut );
				return nativeOut.ToString();
			}
		}
		
		public static void Set(StringAttributeAnsi setter, string value)
		{
			using (nsACString str = new nsACString())
			{
				if (!string.IsNullOrEmpty(value))
					str.SetData(value);
				
				setter(str);
			}
		}

		public static void Pass(Action<nsACString, nsACString> func, string value1, string value2)
		{
			using (nsACString native1 = new nsACString(value1), native2 = new nsACString(value2))
			{
				func(native1, native2);
			}
		}
		#endregion
		#region nsAString
		public delegate void StringAttributeUnicode(nsAString str);
		
		public static string Get(StringAttributeUnicode getter)
		{
			using (nsAString str = new nsAString())
			{
				getter(str);
				return str.ToString();
			}
		}
		
		public static void Set(StringAttributeUnicode setter, string value)
		{
			using (nsAString str = new nsAString())
			{
				if (!string.IsNullOrEmpty(value))
					str.SetData(value);
				
				setter(str);
			}
		}

		/// <summary>
		/// Passes <paramref name="value"/> to function and return value
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="func"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public static T Pass<T>(Func<nsAString,T> func,string value)
		{
			T ret;
			using (nsAString str = new nsAString(value))
			{
				ret = func( str );
			}
			return ret;
		}
		#endregion

	}

	// TODO: see comments on class nsAString
	[StructLayout(LayoutKind.Sequential)]
	public class nsAUTF8String : IDisposable
	{
#region unused variables used to ensure struct is correct size on different platforms
		#pragma warning disable 169
		IntPtr mData;
		int mLength;
		int mFlags;
		#pragma warning restore 169
#endregion

		[DllImport("xpcom", CharSet = CharSet.Ansi)]
		static extern int NS_CStringContainerInit(nsAUTF8String container);
		
		[DllImport("xpcom", CharSet = CharSet.Ansi)]
		static extern int NS_CStringSetData(nsAUTF8String str, byte [] data, int length);
		
		[DllImport("xpcom", CharSet = CharSet.Ansi)]
		static extern int NS_CStringGetData(nsAUTF8String str, out IntPtr data, IntPtr nullTerm);
		
		[DllImport("xpcom", CharSet = CharSet.Ansi)]
		static extern int NS_CStringContainerFinish(nsAUTF8String container);
		
		public nsAUTF8String()
		{
			NS_CStringContainerInit(this);
		}
		
		public nsAUTF8String(string value) : this()
		{
			if (value != null)
			{
				SetData(value);
			}
		}
		
		~nsAUTF8String()
		{
			Dispose();
		}
		
		public void Dispose()
		{
			NS_CStringContainerFinish(this);
			GC.SuppressFinalize(this);
		}
		
		public virtual void SetData(string value)
		{
			byte [] utf8 = Encoding.UTF8.GetBytes(value ?? "");
			
			NS_CStringSetData(this, utf8, utf8.Length);
		}
		
		public override string ToString()
		{
			IntPtr data;
			int length = NS_CStringGetData(this, out data, IntPtr.Zero);
			
			if (length > 0)
			{
				byte [] result = new byte[length];
				Marshal.Copy(data, result, 0, length);
				return Encoding.UTF8.GetString(result);
			}
			return "";
		}
	}
	

	// TODO: see comment on class nsAString
	[StructLayout(LayoutKind.Sequential)]
	public class nsACString : IDisposable
	{
#region unused variables used to ensure struct is correct size on different platforms
		#pragma warning disable 169
		IntPtr mData;
		int mLength;
		int mFlags;
		#pragma warning restore 169
#endregion

		[DllImport("xpcom", CharSet = CharSet.Ansi)]
		static extern int NS_CStringContainerInit(nsACString container);
		
		[DllImport("xpcom", CharSet = CharSet.Ansi)]
		static extern int NS_CStringSetData(nsACString str, string data, int length);
		
		[DllImport("xpcom", CharSet = CharSet.Ansi)]
		internal static extern int NS_CStringGetData(nsACString str, out IntPtr data, IntPtr nullTerm);
		
		[DllImport("xpcom", CharSet = CharSet.Ansi)]
		static extern int NS_CStringContainerFinish(nsACString container);
		
		public nsACString()
		{
			NS_CStringContainerInit(this);
		}
		
		public nsACString(string value) : this()
		{
			if (value != null)
			{
				NS_CStringSetData(this, value, value.Length);
			}
		}
		
		~nsACString()
		{
			Dispose();
		}
		
		public void Dispose()
		{
			NS_CStringContainerFinish(this);
			GC.SuppressFinalize(this);
		}
		
		public virtual void SetData(string value)
		{
			NS_CStringSetData(this, value, (value == null) ? 0 : value.Length);
		}
		
		public override string ToString()
		{
			IntPtr data;
			int length = NS_CStringGetData(this, out data, IntPtr.Zero);
			
			if (length > 0)
			{
				return Marshal.PtrToStringAnsi(data, length);
			}
			return "";
		}
	}

	// TODO: internal nsAString is implementation dependant write some unit tests to ensure we at least notice if it breaks.
	// On 32 bit Linux systems it will be 12 bytes
	// On 64 bit Linux Systems it will be 16 bytes.
	[StructLayout(LayoutKind.Sequential)]
	public class nsAString : IDisposable
	{	

#region unused variables used to ensure struct is correct size on different platforms
		#pragma warning disable 169
		IntPtr mData;
		int mLength;
		int mFlags;
		#pragma warning restore 169
#endregion

		[DllImport("xpcom", CharSet = CharSet.Unicode)]
		static extern int NS_StringContainerInit(nsAString container);
		
		[DllImport("xpcom", CharSet = CharSet.Unicode)]
		static extern int NS_StringSetData(nsAString str, string data, int length);
		
		[DllImport("xpcom", CharSet = CharSet.Unicode)]
		static extern int NS_StringGetData(nsAString str, out IntPtr data, IntPtr nullTerm);
		
		[DllImport("xpcom", CharSet = CharSet.Unicode)]
		static extern int NS_StringContainerFinish(nsAString container);
		
		public nsAString()
		{
			NS_StringContainerInit(this);
		}
		
		public nsAString(string value) : this()
		{
			if (value != null)
			{
				NS_StringSetData(this, value, value.Length);
			}
		}
		
		~nsAString()
		{
			Dispose();
		}
		
		public void Dispose()
		{
			NS_StringContainerFinish(this);
			GC.SuppressFinalize(this);
		}
		
		public void SetData(string value)
		{
			NS_StringSetData(this, value, (value == null) ? 0 : value.Length);
		}
		
		public override string ToString()
		{
			IntPtr data;
			int length = NS_StringGetData(this, out data, IntPtr.Zero);
			
			if (length > 0)
			{
				return Marshal.PtrToStringUni(data, length);
			}
			return "";
		}
	}
}
