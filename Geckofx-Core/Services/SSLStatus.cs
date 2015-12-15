using Gecko.Certificates;
using Gecko.Interop;
using System;


namespace Gecko
{
	public sealed class SSLStatus : ComPtr<nsISSLStatus>
	{
		public static SSLStatus Create(nsISSLStatus instance)
		{
			return new SSLStatus(instance);
		}

		public SSLStatus(nsISSLStatus instance)
			: base(instance)
		{


		}


		public string CipherName
		{
			get { return nsString.Get(Instance.GetCipherNameAttribute); }
		}

		public bool IsDomainMismatch
		{
			get { return Instance.GetIsDomainMismatchAttribute(); }
		}

		public bool IsExtendedValidation
		{
			get { return Instance.GetIsExtendedValidationAttribute(); }
		}

		public Certificate ServerCert
		{
			get { return Instance.GetServerCertAttribute().Wrap(Certificate.Create); }
		}

		public int SecretKeyLength
		{
			get { return (int)Instance.GetSecretKeyLengthAttribute(); }
		}

		public int KeyLength
		{
			get { return (int)Instance.GetKeyLengthAttribute(); }
		}

		public bool IsUntrusted
		{
			get { return Instance.GetIsUntrustedAttribute(); }
		}

		public bool IsNotValidAtThisTime
		{
			get { return Instance.GetIsNotValidAtThisTimeAttribute(); }
		}
	}
}
