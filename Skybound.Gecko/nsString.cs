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
		// functions that set one or more [gecko string]s and return void
		#region Generic Setters
		private static void GenericSet<TString>(Action<TString> setter, string value)
			where TString : IString, IDisposable, new()
		{
			using (var str = new TString())
			{
				if (!string.IsNullOrEmpty(value))
					str.SetData(value);

				setter(str);
			}
		}

		private static void GenericSet<T,TString>(Action<T,TString> setter,T value, string stringValue)
			where TString : IString, IDisposable, new()
		{
			using (var native = new TString())
			{
				if (!string.IsNullOrEmpty(stringValue))
					native.SetData(stringValue);

				setter(value, native);
			}
		}

		private static void GenericSet<TString>(Action<TString, TString> setter, string value1, string value2)
			where TString : IString, IDisposable, new()
		{
			using (TString native1 = new TString(), native2 = new TString())
			{
				if (!string.IsNullOrEmpty(value1))
					native1.SetData(value1);

				if (!string.IsNullOrEmpty(value2))
					native2.SetData(value2);

				setter( native1, native2 );
			}
		}

		private static void GenericSet<TString>(Action<TString, TString, TString> setter, string value1, string value2, string value3)
			where TString : IString, IDisposable, new()
		{
			using (TString native1 = new TString(),
				native2 = new TString(),
				native3 = new TString())
			{
				if (!string.IsNullOrEmpty(value1))
					native1.SetData(value1);

				if (!string.IsNullOrEmpty(value2))
					native2.SetData(value2);

				if (!string.IsNullOrEmpty(value3))
					native3.SetData(value3);

				setter( native1, native2, native3 );
			}
		}

		private static void GenericSet<T1, T2, TString>(Action<T1, T2, TString> func, T1 value1, T2 value2, string stringValue)
			where TString : IString, IDisposable, new()
		{
			using (var native = new TString())
			{
				if (!string.IsNullOrEmpty(stringValue))
					native.SetData(stringValue);

				func(value1, value2, native);
			}
		}

		private static void GenericSet<T1, TString, T2>(Action<T1,TString, T2 > func, T1 value1,string stringValue, T2 value2)
			where TString : IString, IDisposable, new()
		{
			using (var native = new TString())
			{
				if (!string.IsNullOrEmpty(stringValue))
					native.SetData(stringValue);

				func(value1, native, value2);
			}
		}
		#endregion

		// functions that get [gecko string]
		#region Generic Getters
		/// <summary>
		/// Generic string getter
		/// 1-st gecko string - OUTPUT
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="getter"></param>
		/// <returns></returns>
		private static string GenericGet<TString>(Action<TString> getter)
			where TString : IString, IDisposable, new()
		{
			string ret;
			using (var str = new TString())
			{
				getter(str);
				ret= str.ToString();
			}
			return ret;
		}

		/// <summary>
		/// Generic string getter
		/// 1-st gecko string - INPUT
		/// 2-nd gecko string - OUTPUT
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="getter"></param>
		/// <param name="inValue">input value</param>
		/// <returns></returns>
		private static string GenericGet<TString>(Action<TString, TString> getter, string inValue)
			where TString : IString, IDisposable, new()
		{
			string ret;
			using (TString nativeIn = new TString(), nativeOut = new TString())
			{
				if (!string.IsNullOrEmpty(inValue))
					nativeIn.SetData(inValue);
				getter(nativeIn, nativeOut);
				ret = nativeOut.ToString();
			}
			return ret;
		}

		/// <summary>
		/// first parameter - INPUT
		/// gecko string - OUTPUT
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <typeparam name="TString"></typeparam>
		/// <param name="func"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		private static string GenericGet<T, TString>(Action<T, TString> func, T value)
			where TString : IString, IDisposable, new()
		{
			string ret;
			using (TString native = new TString())
			{
				func(value, native);
				ret = native.ToString();
			}
			return ret;
		}

		/// <summary>
		/// first and second parameters - INPUT
		/// gecko string - OUTPUT
		/// </summary>
		/// <typeparam name="T1"></typeparam>
		/// <typeparam name="T2"></typeparam>
		/// <typeparam name="TString"></typeparam>
		/// <param name="func"></param>
		/// <param name="value1"></param>
		/// <param name="value2"></param>
		/// <returns></returns>
		private static string GenericGet<T1,T2, TString>(Action<T1, T2, TString> func, T1 value1, T2 value2)
			where TString : IString, IDisposable, new()
		{
			string ret;
			using (var native = new TString())
			{
				func(value1,value2, native);
				ret = native.ToString();
			}
			return ret;
		}
		#endregion

		// functions that get [T value] and pass [gecko string]s and other arguments
		#region Generic Passers
		/// <summary>
		/// input - gecko String
		/// output - T
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <typeparam name="TString"></typeparam>
		/// <param name="func"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		private static T GenericPass<T, TString>(Func<TString, T> func, string value)
			where TString : IString, IDisposable, new()
		{
			T ret;
			using (var str = new TString())
			{
				if (!string.IsNullOrEmpty(value))
					str.SetData(value);

				ret = func(str);
			}
			return ret;
		}

		/// <summary>
		/// gecko string and T1 - INPUT
		/// T2 - OUTPUT
		/// </summary>
		/// <typeparam name="T1"></typeparam>
		/// <typeparam name="TString"></typeparam>
		/// <typeparam name="T2"></typeparam>
		/// <param name="func"></param>
		/// <param name="value"></param>
		/// <param name="stringValue"></param>
		/// <returns></returns>
		private static T2 GenericPass<T1, TString, T2>(Func<T1, TString, T2> func, T1 value, string stringValue)
			where TString : IString, IDisposable, new()
		{
			T2 ret;
			using (TString native = new TString())
			{
				if (!string.IsNullOrEmpty(stringValue))
					native.SetData(stringValue);

				ret = func(value, native);
			}
			return ret;
		}

		/// <summary>
		/// 2x gecko strings - INPUT
		/// T - OUTPUT
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <typeparam name="TString"></typeparam>
		/// <param name="func"></param>
		/// <param name="value1"></param>
		/// <param name="value2"></param>
		/// <returns></returns>
		private static T GenericPass<T, TString>(Func<TString, TString, T> func, string value1, string value2)
			where TString : IString, IDisposable, new()
		{
			T ret;
			using (TString str1 = new TString(), str2 =new TString())
			{
				if (!string.IsNullOrEmpty(value1))
					str1.SetData(value1);
				if (!string.IsNullOrEmpty(value2))
					str2.SetData(value2);
				ret = func(str1, str2);
			}
			return ret;
		}
		#endregion

		#region nsAUTF8String
		public static string Get(Action<nsAUTF8String> getter)
		{
			return GenericGet( getter );
		}

		public static string Get(Action<nsAUTF8String, nsAUTF8String> getter, string inValue)
		{
			return GenericGet( getter, inValue );
		}

		public static void Set(Action<nsAUTF8String> setter, string value)
		{
			GenericSet( setter, value );
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
			return GenericPass( func, value );
		}

		public static T Pass<T,TW> (Func<TW,nsAUTF8String,T> func,TW value,string stringValue )
		{
			return GenericPass( func, value, stringValue );
		}
		#endregion

		#region nsACString

		public static string Get(Action<nsACString> getter)
		{
			return GenericGet( getter );
		}

		public static string Get(Action<nsACString,nsACString> getter,string inValue)
		{
			return GenericGet( getter, inValue );
		}

		public static string Get<T>(Action<T, nsACString> func, T value)
		{
			return GenericGet(func, value);
		}

		public static void Set(Action<nsACString> setter, string value)
		{
			GenericSet( setter, value );
		}

		public static void Set(Action<nsACString, nsACString> func, string value1, string value2)
		{
			GenericSet( func, value1, value2 );
		}

		/// <summary>
		/// Passes <paramref name="value1"/> and <paramref name="value2"/> to function and return value
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="func"></param>
		/// <param name="value1"></param>
		/// <param name="value2"></param>
		/// <returns></returns>
		public static T Pass<T>(Func<nsACString, nsACString, T> func, string value1, string value2)
		{
			return GenericPass(func, value1, value2);
		}
		#endregion

		#region nsAString

		#region nsAString Getters
		
		public static string Get(Action<nsAString> getter)
		{
			return GenericGet(getter);
		}

		public static string Get(Action<nsAString, nsAString> getter, string inValue)
		{
			return GenericGet(getter, inValue);
		}


		public static string Get<T>(Action<T, nsAString> func, T value)
		{
			return GenericGet( func, value );
		}

		public static string Get<T1,T2>(Action<T1,T2,nsAString> func,T1 value1,T2 value2)
		{
			return GenericGet( func, value1, value2 );
		}
		#endregion

		#region nsAString Setters

		public static void Set(Action<nsAString> setter, string value)
		{
			GenericSet( setter, value );
		}

		public static void Set(Action<nsAString, nsAString> func, string value1, string value2)
		{
			GenericSet( func, value1, value2 );
		}

		public static void Set<T>(Action<T, nsAString> func, T value1, string value2)
		{
			GenericSet(func, value1, value2);
		}

		public static void Set(Action<nsAString,nsAString,nsAString>func, string value1, string value2,string value3)
		{
			GenericSet( func, value1, value2, value3 );
		}

		public static void Set<T1,T2>(Action<T1,T2,nsAString> func,T1 value1,T2 value2, string stringValue)
		{
			GenericSet( func, value1, value2, stringValue );
		}

		public static void Set<T1, T2>(Action<T1,nsACString, T2 > func, T1 value1,string stringValue, T2 value2 )
		{
			GenericSet( func, value1, stringValue, value2 );
		}
		#endregion

		#region nsAString Passers
		/// <summary>
		/// Passes <paramref name="value"/> to function and return value
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="func"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public static T Pass<T>(Func<nsAString,T> func,string value)
		{
			return GenericPass(func, value);
		}

		/// <summary>
		/// Passes <paramref name="value1"/> and <paramref name="value2"/> to function and return value
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="func"></param>
		/// <param name="value1"></param>
		/// <param name="value2"></param>
		/// <returns></returns>
		public static T Pass<T>(Func<nsAString,nsAString, T> func, string value1,string value2)
		{
			return GenericPass( func, value1, value2 );
		}
		
		#endregion

		#endregion
	}

	/// <summary>
	/// Internal helper interface for generics
	/// </summary>
	internal interface IString
	{
		void SetData( string value );
	}

	#region nsAUTF8String
	[StructLayout(LayoutKind.Sequential)]
	public class nsAUTF8StringBase
		: IString
	{
		protected nsAUTF8StringBase() { }

		[DllImport("xpcom", CharSet = CharSet.Ansi)]
		protected static extern int NS_CStringContainerInit(nsAUTF8StringBase container);

		[DllImport("xpcom", CharSet = CharSet.Ansi)]
		protected static extern int NS_CStringSetData(nsAUTF8StringBase str, byte[] data, int length);

		[DllImport("xpcom", CharSet = CharSet.Ansi)]
		protected static extern int NS_CStringGetData(nsAUTF8StringBase str, out IntPtr data, IntPtr nullTerm);

		[DllImport("xpcom", CharSet = CharSet.Ansi)]
		protected static extern int NS_CStringContainerFinish(nsAUTF8StringBase container);

		#region unused variables used to ensure struct is correct size on different platforms
#pragma warning disable 169
		IntPtr mData;
		int mLength;
		int mFlags;
#pragma warning restore 169
		#endregion

		public virtual void SetData(string value)
		{
			byte[] utf8 = Encoding.UTF8.GetBytes(value ?? string.Empty);

			NS_CStringSetData(this, utf8, utf8.Length);
		}

		public override string ToString()
		{
			IntPtr data;
			int length = NS_CStringGetData(this, out data, IntPtr.Zero);

			if (length > 0)
			{
				byte[] result = new byte[length];
				Marshal.Copy(data, result, 0, length);
				return Encoding.UTF8.GetString(result);
			}
			return string.Empty;
		}

	}

	// TODO: see comments on class nsAString
	[StructLayout(LayoutKind.Sequential)]
	public class nsAUTF8String : nsAUTF8StringBase, IDisposable
	{				
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
	}
	#endregion

	#region nsACString
	[StructLayout(LayoutKind.Sequential)]
	public class nsACStringBase
		: IString
	{
		protected nsACStringBase() { }

		[DllImport("xpcom", CharSet = CharSet.Ansi)]
		protected static extern int NS_CStringContainerInit(nsACStringBase container);

		[DllImport("xpcom", CharSet = CharSet.Ansi)]
		protected static extern int NS_CStringSetData(nsACStringBase str, string data, int length);

		[DllImport("xpcom", CharSet = CharSet.Ansi)]
		protected internal static extern int NS_CStringGetData(nsACStringBase str, out IntPtr data, IntPtr nullTerm);

		[DllImport("xpcom", CharSet = CharSet.Ansi)]
		protected static extern int NS_CStringContainerFinish(nsACStringBase container);

		#region unused variables used to ensure struct is correct size on different platforms
#pragma warning disable 169
		IntPtr mData;
		int mLength;
		int mFlags;
#pragma warning restore 169
		#endregion

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
			return string.Empty;
		}
	}


	// TODO: see comment on class nsAString
	[StructLayout(LayoutKind.Sequential)]
	public class nsACString : nsACStringBase, IDisposable
	{		
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
	}
	#endregion

	#region nsAString
	[StructLayout(LayoutKind.Sequential)]
	public class nsAStringBase
		: IString
	{
		protected nsAStringBase() { }

		[DllImport("xpcom", CharSet = CharSet.Unicode)]
		protected static extern int NS_StringContainerInit(nsAStringBase container);

		[DllImport("xpcom", CharSet = CharSet.Unicode)]
		protected static extern int NS_StringSetData(nsAStringBase str, string data, int length);

		[DllImport("xpcom", CharSet = CharSet.Unicode)]
		protected static extern int NS_StringGetData(nsAStringBase str, out IntPtr data, IntPtr nullTerm);

		[DllImport("xpcom", CharSet = CharSet.Unicode)]
		protected static extern int NS_StringContainerFinish(nsAStringBase container);

		#region unused variables used to ensure struct is correct size on different platforms
		#pragma warning disable 169
		IntPtr mData;
		int mLength;
		int mFlags;
		#pragma warning restore 169
		#endregion

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
			return string.Empty;
		}
	}

	// TODO: internal nsAString is implementation dependant write some unit tests to ensure we at least notice if it breaks.
	// On 32 bit Linux systems it will be 12 bytes
	// On 64 bit Linux Systems it will be 16 bytes.
	[StructLayout(LayoutKind.Sequential)]
	public class nsAString : nsAStringBase, IDisposable
	{					
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
	}
	#endregion
}
