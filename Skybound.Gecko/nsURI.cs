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

namespace Gecko
{
	/// <summary>
	/// Provides a wrapper for Mozilla nsIURI objects.
	/// </summary>

	// Mono needs a little help to get the size of this struct right.
	// (I think because it contains a __ComObject ref.)
	// This should work on .NET as well.
	[StructLayout(LayoutKind.Explicit, Size=8)]
	public struct nsURI
	{
		internal nsURI(nsIURI instance)
		{
			this.Instance = instance;
		}
		
		/// <summary>
		/// Initializes a new instance of <see cref="nsURI"/> from the given object, which must implement the unmanaged
		/// nsIURI interface.
		/// </summary>
		/// <param name="instance"></param>
		public nsURI(object instance)
		{
			this.Instance = (nsIURI)instance;
		}
		
		#region Equality Methods
		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return this.Instance == null;
			}
			else if (obj is nsURI)
			{
				return this.Instance == ((nsURI)obj).Instance;
			}
			else if (obj is nsIURI)
			{
				return this.Instance == obj;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return Instance.GetHashCode();
		}
		
		public static bool operator == (nsURI a, nsURI b)
		{
			return a.Instance == b.Instance;
		}
		
		public static bool operator != (nsURI a, nsURI b)
		{
			return a.Instance != b.Instance;
		}
		
		public bool IsNull { get { return Instance == null; } }
		#endregion
		
		/// <summary>
		/// Gets the underlying <b>nsIURI</b> object.
		/// </summary>
		/// <returns></returns>
		public object GetInstance() { return Instance; }

		[FieldOffset(0)]
		nsIURI Instance;

		public string Spec { get { return nsString.Get(Instance.GetSpecAttribute); } set { nsString.Set(Instance.SetSpecAttribute, value); } }
		public string PrePath { get { return nsString.Get(Instance.GetPrePathAttribute); } }
		public string Scheme { get { return nsString.Get(Instance.GetSchemeAttribute); } set { nsString.Set(Instance.SetSchemeAttribute, value); } }
		public string UserPass { get { return nsString.Get(Instance.GetUserPassAttribute); } set { nsString.Set(Instance.SetUserPassAttribute, value); } }
		public string Username { get { return nsString.Get(Instance.GetUsernameAttribute); } set { nsString.Set(Instance.SetUsernameAttribute, value); } }
		public string Password { get { return nsString.Get(Instance.GetPasswordAttribute); } set { nsString.Set(Instance.SetPasswordAttribute, value); } }
		public string HostPort { get { return nsString.Get(Instance.GetHostPortAttribute); } set { nsString.Set(Instance.SetHostPortAttribute, value); } }
		public string Host { get { return nsString.Get(Instance.GetHostAttribute); } set { nsString.Set(Instance.SetHostAttribute, value); } }
		public int Port { get { return Instance.GetPortAttribute(); } set { Instance.SetPortAttribute(value); } }
		public string Path { get { return nsString.Get(Instance.GetPathAttribute); } set { nsString.Set(Instance.SetPathAttribute, value); } }
		public bool SchemeIs(string s) { return Instance.SchemeIs(s); }
		public bool Equals(nsURI uri) { return Instance.Equals(uri); }
		public nsURI Clone() { return new nsURI(Instance.Clone()); }
		public void Resolve(string relativePath, string resolved) 
		{
			var retval = new nsAUTF8String();
			Instance.Resolve(new nsAUTF8String(relativePath), retval); 
			resolved = retval.ToString();
		}
		public string AsciiSpec { get { return nsString.Get(Instance.GetAsciiSpecAttribute); } }
		public string AsciiHost { get { return nsString.Get(Instance.GetAsciiHostAttribute); } }
		public string OriginCharset { get { return nsString.Get(Instance.GetOriginCharsetAttribute); } }

		public Uri ToUri()
		{
			if (!IsNull)
			{
				Uri result;
				return Uri.TryCreate(Spec, UriKind.Absolute, out result) ? result : null;
			}

			return null;
		}

		#region Static creation functions
		
		public static nsURI Create(string url)
		{
			return new nsURI(CreateInternal(url));
		}

		internal static nsIURI CreateInternal(string url)
		{
			nsIURI returnValue;
			nsIIOService service = Xpcom.GetService<nsIIOService>("@mozilla.org/network/io-service;1");
			using (var str = new nsAUTF8String(url))
			{
				returnValue = service.NewURI(str, null, null);
			}

			Marshal.ReleaseComObject(service);
			return returnValue;
		}
		#endregion

		internal static Uri ToUri(nsIURI value )
		{
			if (value == null) return null;
			var spec=nsString.Get( value.GetSpecAttribute );
			Uri result;
			return Uri.TryCreate(spec, UriKind.Absolute, out result) ? result : null;
		}

	}
	
}
