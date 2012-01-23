using System;

namespace Gecko.Certificates
{
	public sealed class Certificate
		: System.IEquatable<Certificate>
	{
		internal nsIX509Cert _cert1;
		private nsIX509Cert2 _cert2;
		private nsIX509Cert3 _cert3;

		private Certificate(nsIX509Cert cert1,nsIX509Cert2 cert2,nsIX509Cert3 cert3)
		{
			_cert1 = cert1;
			_cert2 = cert2;
			_cert3 = cert3;
		}

		public string Nickname
		{
			get { return nsString.Get(_cert1.GetNicknameAttribute); }
		}

		public string EmailAddress
		{
			get { return nsString.Get(_cert1.GetEmailAddressAttribute); }
		}

		public void GetEmailAddresses(ref uint length,ref IntPtr[] addresses)
		{
			_cert1.GetEmailAddresses( ref length, ref addresses );
		}

		public bool ContainsEmailAddress(string email)
		{
			return nsString.Pass(_cert1.ContainsEmailAddress, email);
		}

		public string SubjectName
		{
			get { return nsString.Get(_cert1.GetSubjectNameAttribute); }
		}

		public string CommonName
		{
			get { return nsString.Get(_cert1.GetCommonNameAttribute); }
		}

		public string Organization
		{
			get { return nsString.Get(_cert1.GetOrganizationAttribute); }
		}

		public string OrganizationalUnit
		{
			get { return nsString.Get(_cert1.GetOrganizationalUnitAttribute); }
		}

		public string Sha1Fingerprint
		{
			get { return nsString.Get(_cert1.GetSha1FingerprintAttribute); }
		}

		public string Md5Fingerprint
		{
			get { return nsString.Get(_cert1.GetMd5FingerprintAttribute); }
		}

		public string TokenName
		{
			get { return nsString.Get(_cert1.GetTokenNameAttribute); }
		}

		public string IssuerName
		{
			get { return nsString.Get(_cert1.GetIssuerNameAttribute); }
		}

		public string SerialNumber
		{
			get { return nsString.Get(_cert1.GetSerialNumberAttribute); }
		}

		public string IssuerCommonName
		{
			get { return nsString.Get(_cert1.GetIssuerCommonNameAttribute); }
		}

		public string IssuerOrganization
		{
			get { return nsString.Get(_cert1.GetIssuerOrganizationAttribute); }
		}

		public string IssuerOrganizationUnit
		{
			get { return nsString.Get( _cert1.GetIssuerOrganizationUnitAttribute ); }
		}

		public Certificate Issuer
		{
			get { return Create( _cert1.GetIssuerAttribute() ); }
		}

		public object Validity
		{
			get { return _cert1.GetValidityAttribute(); }
		}

		public string DbKey
		{
			get { return _cert1.GetDbKeyAttribute(); }
		}

		public string WindowTitle
		{
			get { return _cert1.GetWindowTitleAttribute(); }
		}

		public object Chain
		{
			get { return _cert1.GetChain(); }
		}

		public void GetUsagesArray(bool localOnly,ref uint verified,ref uint count,ref System.IntPtr[] usages)
		{
			_cert1.GetUsagesArray( localOnly, ref verified, ref count, ref usages );
		}

		public string GetUsagesString(bool localOnly,ref uint verified)
		{
			string ret = null;
			using (nsAString str = new nsAString())
			{
				_cert1.GetUsagesString( localOnly, ref verified, str );
				ret = str.ToString();
			}
			return ret;
		}

		public uint VerifyForUsage(uint usage)
		{
			return _cert1.VerifyForUsage( usage );
		}

		public ASN1Object ASN1Structure
		{
			get { return new ASN1Object(_cert1.GetASN1StructureAttribute()); }
		}

		public void GetRawDER(ref uint length,ref System.IntPtr[] data)
		{
			_cert1.GetRawDER( ref length, ref data );
		}

		public uint CertType
		{
			get { return _cert2.GetCertTypeAttribute(); }
		}

		public void MarkForPermDeletion()
		{
			_cert2.MarkForPermDeletion();
		}

		public IntPtr GetCert()
		{
			return _cert2.GetCert();
		}

		//void RequestUsagesArrayAsync([MarshalAs(UnmanagedType.Interface)] nsICertVerificationListener cvl);


		public void ExportAsCMS(uint chainMode, ref uint length, ref System.IntPtr[] data)
		{
			_cert3.ExportAsCMS( chainMode, ref length, ref data );
		}

		public bool IsSelfSigned
		{
			get { return _cert3.GetIsSelfSignedAttribute(); }
		}

		public void GetAllTokenNames(ref uint length, ref System.IntPtr[] tokenNames)
		{
			_cert3.GetAllTokenNames( ref length, ref tokenNames );
		}

		public bool Equals( Certificate other )
		{
			return _cert1.Equals( other._cert1 );
		}

		public override bool Equals(object obj)
		{
			if (obj is Certificate)
			{
				return Equals( ( Certificate ) obj );
			}
			if (obj is nsIX509Cert)
			{
				return _cert1.Equals( ( nsIX509Cert ) obj );
			}
			return false;
		}

		

	


		public static Certificate Create(nsIX509Cert certificate)
		{
			var cert2 = Xpcom.QueryInterface<nsIX509Cert2>( certificate );
			var cert3 = Xpcom.QueryInterface<nsIX509Cert3>( certificate );
			return new Certificate( certificate, cert2, cert3 );
		}
	}
}