using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Gecko.IO
{
	public sealed class InputStream
		:System.IO.Stream
	{
		private bool _seekable;
		private nsISeekableStream _seekableStream;
		private nsIInputStream _inputStream;

		private InputStream(nsIInputStream inputStream, nsISeekableStream seekableStream)
		{
			_inputStream = inputStream;
			_seekableStream = seekableStream;
			_seekable = _seekableStream != null;
		}

		public override void Flush()
		{
		}

		public override void Close()
		{
			_inputStream.Close();
		}

		public override long Seek( long offset, SeekOrigin origin )
		{
			//NS_SEEK_SET 	0 	Specifiesthat the offset is relative to the start of the stream.
			//NS_SEEK_CUR 	1 	Specifies that the offset is relative to the current position in the stream.
			//NS_SEEK_END 	2 	Specifies that the offset is relative to the end of the stream.
			_seekableStream.Seek((int)origin, (int)offset);
			return _seekableStream.Tell();
		}

		public override void SetLength( long value )
		{
			throw new NotImplementedException();
		}

		public override int Read( byte[] buffer, int offset, int count )
		{
			throw new NotImplementedException();
		}

		public override void Write( byte[] buffer, int offset, int count )
		{
			throw new NotImplementedException();
		}

		public override bool CanRead
		{
			get { return true; }
		}

		public override bool CanSeek
		{
			get { return _seekable; }
		}

		public override bool CanWrite
		{
			get { return false; }
		}

		public override long Length
		{

			get { throw new NotImplementedException(); }
		}

		public override long Position
		{
			get { return _seekableStream.Tell(); }
			set { _seekableStream.Seek( 0, ( int ) value ); }
		}


		public static InputStream Create(nsIInputStream stream)
		{
			var seekable = Xpcom.QueryInterface<nsISeekableStream>(stream);
			return new InputStream(stream, seekable);
		}
	}


}
