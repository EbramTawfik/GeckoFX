using System;
using System.Collections.Generic;

namespace Gecko
{
	public class GeckoNamedNodeMap : IEnumerable<GeckoNode>
	{
		internal GeckoNamedNodeMap(nsIDOMNamedNodeMap map)
		{
			this.Map = map;
		}
		
		nsIDOMNamedNodeMap Map;
		
		/// <summary>
		/// Gets the number of items in the map.
		/// </summary>
		public int Count
		{
			get { return (Map == null) ? 0 : (int)Map.GetLengthAttribute(); }
		}
		
		public GeckoNode this[int index]
		{
			get
			{
				if (index < 0 || index >= Count)
					throw new ArgumentOutOfRangeException("index");

				return GeckoNode.Create(Map.Item((uint)index));
			}
		}
		
		public GeckoNode this[string name]
		{
			get
			{
				return GeckoNode.Create(Map.GetNamedItem(new nsAString(name)));
			}
		}
		
		public GeckoNode this[string namespaceUri, string localName]
		{
			get
			{
				return GeckoNode.Create(Map.GetNamedItemNS(new nsAString(namespaceUri), new nsAString(localName)));
			}
		}

		#region IEnumerable<GeckoNode> Members

		public IEnumerator<GeckoNode> GetEnumerator()
		{
			int length = Count;
			for (int i = 0; i < length; i++)
			{
				yield return GeckoNode.Create(Map.Item((uint)i));
			}
		}

		#endregion

		#region IEnumerable Members

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			foreach (GeckoNode node in this)
				yield return node;
		}

		#endregion
	}
}