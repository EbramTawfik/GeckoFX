namespace Gecko.IO
{
	public sealed class MimeInputStream
		:InputStream
	{
		private nsIMIMEInputStream _mimeInputStream;

		internal MimeInputStream(nsIMIMEInputStream stream)
			:base(stream)
		{
			_mimeInputStream = stream;
		}

		public bool AddContentLength
		{
			get { return _mimeInputStream.GetAddContentLengthAttribute(); }
			set{_mimeInputStream.SetAddContentLengthAttribute( value );}
		}

		public void AddHeader(string name,string value)
		{
			_mimeInputStream.AddHeader( name, value );
		}

		public void SetData(InputStream stream)
		{
			_mimeInputStream.SetData( stream._inputStream );
		}
	}
}