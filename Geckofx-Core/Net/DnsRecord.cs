using System;
using System.Collections;
using System.Collections.Generic;

namespace Gecko.Net
{
	public sealed class DnsRecord
		:IEnumerable<string>
	{
		private InstanceWrapper<nsIDNSRecord> _record;

		private DnsRecord( nsIDNSRecord record )
		{
			_record = new InstanceWrapper<nsIDNSRecord>( record );
		}

		public static DnsRecord Create(nsIDNSRecord record)
		{
			return record == null ? null : new DnsRecord( record );
		}

		public string CanonicalName
		{
			get { return nsString.Get( _record.Instance.GetCanonicalNameAttribute ); }
		}

		public IEnumerator<string> GetEnumerator()
		{
			return new DnsRecordEnumerator(_record.Instance);
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