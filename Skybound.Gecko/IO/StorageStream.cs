using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gecko.IO
{
	public sealed class StorageStream
	{
		internal nsIStorageStream _storageStream;
		public StorageStream()
		{
			var storageStream = Xpcom.CreateInstance<nsIStorageStream>(Contracts.StorageStream);
			_storageStream = Xpcom.QueryInterface<nsIStorageStream>(storageStream);

			_storageStream.Init( 1024 * 32, 1024 * 1024 * 16, null );

		}

		public OutputStream GetOutputStream(int position)
		{
			return OutputStream.Create( _storageStream.GetOutputStream( position ) );
		}


		public InputStream NewInputStream(int position)
		{
			return InputStream.Create( _storageStream.NewInputStream( position ) );
		}

		public uint Length
		{
			get { return _storageStream.GetLengthAttribute(); }
			set { _storageStream.SetLengthAttribute( value ); }
		}
	}
}
