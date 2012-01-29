using System;
using System.Collections.Generic;
using Gecko.Collections;

namespace Gecko.IO
{
	public sealed class ZipReader
	{
		private nsIZipReader _zipReader;

		public ZipReader()
		{
			var zipReader = Xpcom.CreateInstance<nsIZipReader>(Contracts.ZipReader);
			_zipReader = Xpcom.QueryInterface<nsIZipReader>(zipReader);
		}

		public void Open(string fileName)
		{
			_zipReader.Open(( nsIFile ) Xpcom.NewNativeLocalFile(fileName));

			
		}

		public IEnumerator<string> FindEntries(string pattern)
		{
			return new Utf8StringEnumerator( _zipReader.FindEntries( pattern ) );
		}

		public void Close()
		{
			_zipReader.Close();
		}

		public bool HasEntry(string entry)
		{
			return nsString.Pass( _zipReader.HasEntry, entry );
		}

		public bool Test(string entry=null)
		{
			bool ret;
			try
			{
				_zipReader.Test(entry);
				ret = true;
			}
			catch ( Exception )
			{
				ret = false;
			}
			return ret;
		}
		
	}
}