using Gecko.IO;

namespace Gecko.Net
{
	public sealed class UploadChannel
	{
		private nsIUploadChannel _uploadChannel;

		internal UploadChannel(nsIUploadChannel uploadChannel)
		{
			_uploadChannel = uploadChannel;
		}

		public InputStream GetUploadStream()
		{
			return InputStream.Create( _uploadChannel.GetUploadStreamAttribute() );
		}

		public void SetInputStream(InputStream stream,string contentType,int len)
		{
			nsString.Set( _uploadChannel.SetUploadStream, stream._inputStream, contentType, len );
		}
	}
}