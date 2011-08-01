using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Skybound.Gecko
{
	public class GeckoMIMEInputStream : IDisposable
	{
		public nsIMIMEInputStream InputStream { get; protected set; }

		public GeckoMIMEInputStream()
		{			
			InputStream = Xpcom.CreateInstance<nsIMIMEInputStream>("@mozilla.org/network/mime-input-stream;1");
		}

		public bool AddContentLength
		{
			set
			{
				InputStream.SetAddContentLengthAttribute(value);
			}
		}

		public void AddHeader(string name, string value)
		{
			InputStream.AddHeader(name, value);
		}	

		public void SetData(string data)
		{
			var instance = Xpcom.CreateInstance<nsIStringInputStream>("@mozilla.org/io/string-input-stream;1");
			instance.SetData(data, data.Length);
			InputStream.SetData(instance);
			Marshal.ReleaseComObject(instance);
		}

		public void Dispose()
		{
			Marshal.ReleaseComObject(InputStream);
		}
	}
}
