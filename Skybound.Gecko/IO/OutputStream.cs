using System;
using System.IO;

namespace Gecko.IO
{
	public sealed class OutputStream
		:Stream
	{
		private bool _seekable;
		private nsISeekableStream _seekableStream;
		internal nsIOutputStream _outputStream;
		private nsIBinaryOutputStream _binaryOutputStream;

		private OutputStream(nsIOutputStream outputStream, nsISeekableStream seekableStream)
		{
			_outputStream = outputStream;
			_seekableStream = seekableStream;
			_seekable = _seekableStream != null;
			var binaryOutputStream = Xpcom.CreateInstance<nsIBinaryOutputStream>( "@mozilla.org/binaryoutputstream;1" );
			_binaryOutputStream = Xpcom.QueryInterface<nsIBinaryOutputStream>( binaryOutputStream );
			_binaryOutputStream.SetOutputStream(_outputStream  ); 
		}

		public override void Close()
		{
			_binaryOutputStream.Close();
			_outputStream.Close();
		}

		public override void Flush()
		{
			_binaryOutputStream.Flush();
			_outputStream.Flush();
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
			int current = _seekableStream.Tell();
			_seekableStream.Seek( 0,(int)value );
			_seekableStream.SetEOF();
			_seekableStream.Seek(0, current);
		}

		public override int Read( byte[] buffer, int offset, int count )
		{
			throw new NotImplementedException();
		}

		public override void WriteByte(byte value)
		{
			_binaryOutputStream.Write8( value );
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
			if ( offset == 0 )
			{
				_binaryOutputStream.WriteByteArray( buffer, ( uint ) count );
				return;
			}
			byte[] newArray = new byte[count - offset];
			Array.Copy( buffer, offset, newArray, 0, newArray.Length );
			_binaryOutputStream.WriteByteArray( newArray, ( uint ) newArray.Length );
		}

		public override bool CanRead
		{
			get { return false; }
		}

		public override bool CanSeek
		{
			get { return _seekable; }
		}

		public override bool CanWrite
		{
			get { return true; }
		}

		public override long Length
		{
			get { return _seekableStream.Tell(); }
		}

		public override long Position
		{
			get { return _seekableStream.Tell(); }
			set { _seekableStream.Seek( 0, ( int ) Position ); }
		}

		public static OutputStream Create(nsIOutputStream stream)
		{
			var seekable=Xpcom.QueryInterface<nsISeekableStream>( stream );
			return new OutputStream( stream, seekable );
		}
	}
}