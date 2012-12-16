using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Gecko
{
	public class GeckoMIMEInputStream
		:IDisposable
	{
		private InstanceWrapper<nsIMIMEInputStream> _inputStream;

		public nsIMIMEInputStream InputStream
		{
			get { return _inputStream.Instance; }
		}

		public GeckoMIMEInputStream()
		{
			_inputStream = new InstanceWrapper<nsIMIMEInputStream>( Contracts.MimeInputStream );
		}

		public void Dispose()
		{
			Xpcom.DisposeObject( ref _inputStream );
		}

		public bool AddContentLength
		{
			set
			{
				_inputStream.Instance.SetAddContentLengthAttribute(value);
			}
		}

		public void AddHeader(string name, string value)
		{
			_inputStream.Instance.AddHeader(name, value);
		}	

		public void SetData(string data)
		{
			using ( var stringInputStream = new InstanceWrapper<nsIStringInputStream>( Contracts.StringInputStream ) ) 
			{
				stringInputStream.Instance.SetData(data, data.Length);
				_inputStream.Instance.SetData(stringInputStream.Instance);
			}
			
			
		}
	}
}
