using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Gecko.Certificates;
using Gecko.Interop;

namespace Gecko.Events
{
	public sealed class GeckoNSSErrorEventArgs : HandledEventArgs
	{
		private int _statusCode;
		private Uri _uri;
		private SSLStatus _sslStatus;

		public GeckoNSSErrorEventArgs(Uri uri, int status, SSLStatus sslStatus)
		{
			_statusCode = status;
			_uri = uri;
			_sslStatus = sslStatus;
		}


		#region public

		public Uri Uri
		{
			get { return _uri; }
		}

		public int StatusCode
		{
			get { return _statusCode; }
		}

		public NSSErrors ErrorCode
		{
			get
			{
				return (NSSErrors)(-(_statusCode & 0xffff));
			}
		}

		public string Message
		{
			get
			{
				using (var svc = Xpcom.GetService2<nsINSSErrorsService>(Contracts.NSSErrorsService))
				{
					return nsString.Get(svc.Instance.GetErrorMessage, _statusCode);
				}
			}
		}

		public int ErrorClass
		{
			get
			{
				ComPtr<nsINSSErrorsService> nssErrorSvc = Xpcom.GetService2<nsINSSErrorsService>(Contracts.NSSErrorsService);
				try
				{
					return (int)nssErrorSvc.Instance.GetErrorClass(_statusCode);
				}
				catch (COMException ex)
				{
					if (ex.ErrorCode == GeckoError.NS_ERROR_UNEXPECTED)
						return (int)nsINSSErrorsServiceConsts.ERROR_CLASS_SSL_PROTOCOL;
					throw;
				}
				finally
				{
					((IDisposable)nssErrorSvc).Dispose();
				}
			}
		}

		public SSLStatus SSLStatus
		{
			get { return _sslStatus; }
		}

		public Certificate Certificate
		{
			get
			{
				if(_sslStatus != null)
					return _sslStatus.ServerCert;
				return null;
			}
		}

		#endregion

	}
}
