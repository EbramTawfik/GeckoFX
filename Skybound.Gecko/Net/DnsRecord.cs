using System;
using System.Collections;
using System.Collections.Generic;

namespace Gecko.Net
{
	public sealed class DnsRecord
		:IEnumerable<string>
	{
		private nsIDNSRecord _record;

		internal DnsRecord( nsIDNSRecord record )
		{
			_record = record;
		}

		public string CanonicalName
		{
			get { return nsString.Get( _record.GetCanonicalNameAttribute ); }
		}

		public IEnumerator<string> GetEnumerator()
		{
			return new DnsRecordEnumerator( _record );
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		private sealed class DnsRecordEnumerator
			: IEnumerator<string>
		{
			private nsIDNSRecord _record;
			private string _current;

			internal DnsRecordEnumerator(nsIDNSRecord record)
			{
				_record = record;
			}

			~DnsRecordEnumerator()
			{
				_record.Rewind();
				_record = null;
			}

			public void Dispose()
			{
				_record.Rewind();
				_record = null;
				GC.SuppressFinalize(this);
			}

			public bool MoveNext()
			{
				if (_record.HasMore())
				{
					_current = nsString.Get(_record.GetNextAddrAsString);
					return true;
				}
				return false;
			}

			public void Reset()
			{
				_record.Rewind();
				_current = null;
			}

			public string Current
			{
				get { return _current; }
			}

			object IEnumerator.Current
			{
				get { return Current; }
			}
		}
	}
}