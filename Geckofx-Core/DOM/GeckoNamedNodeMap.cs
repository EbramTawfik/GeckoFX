using System;
using System.Collections.Generic;
using Gecko.Interop;

namespace Gecko
{
	public class GeckoNamedNodeMap
		: IEnumerable<GeckoNode>
	{
		private nsIDOMNamedNodeMap _map;

		private GeckoNamedNodeMap(nsIDOMNamedNodeMap map)
		{
			// map should be not null
			this._map = map;
		}
		
		public static GeckoNamedNodeMap Create( nsIDOMNamedNodeMap domNamedNodeMap )
		{
			return new GeckoNamedNodeMap( domNamedNodeMap );
		}
		
		
		/// <summary>
		/// Gets the number of items in the map.
		/// </summary>
		public int Count
		{
			get { return ( int ) _map.GetLengthAttribute(); }
		}
		
		public GeckoNode this[int index]
		{
			get
			{
				if (index < 0 || index >= Count)
					throw new ArgumentOutOfRangeException("index");

				return _map.Item( ( uint ) index ).Wrap( GeckoNode.Create );
			}
		}
		
		public GeckoNode this[string name]
		{
			get { return nsString.Pass(_map.GetNamedItem,name).Wrap(GeckoNode.Create); }
		}
		
		public GeckoNode this[string namespaceUri, string localName]
		{
			get { return nsString.Pass( _map.GetNamedItemNS, namespaceUri, localName ).Wrap( GeckoNode.Create ); }
		}

		#region IEnumerable<GeckoNode> Members

		public IEnumerator<GeckoNode> GetEnumerator()
		{
			int length = Count;
			for (int i = 0; i < length; i++)
			{
				yield return GeckoNode.Create(_map.Item((uint)i));
			}
		}

		#endregion

		#region IEnumerable Members

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		#endregion
	}
}