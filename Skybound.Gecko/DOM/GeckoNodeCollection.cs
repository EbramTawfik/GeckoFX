using System;
using System.Collections.Generic;

namespace Gecko
{
	/// <summary>
	/// Represents a collection of <see cref="GeckoElement"/> objects.
	/// </summary>
	public class GeckoNodeCollection : IEnumerable<GeckoNode>
	{
		protected GeckoNodeCollection(nsIDOMNodeList list)
		{
			this.List = list;
		}
		nsIDOMNodeList List;

		public virtual int Count
		{
			get { return (int)List.GetLengthAttribute(); }
		}
		
		public virtual GeckoNode this[int index]
		{
			get
			{
				if (index < 0 || index >= Count)
					throw new ArgumentOutOfRangeException("index");

				return GeckoNode.Create(List.Item((uint)index));
			}
		}
		
		#region IEnumerable<GeckoNode> Members

		public virtual IEnumerator<GeckoNode> GetEnumerator()
		{
			int length = Count;
			for (int i = 0; i < length; i++)
			{
				yield return GeckoNode.Create(List.Item((uint)i));
			}
		}
		
		#endregion
		
		#region IEnumerable Members
		
		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			foreach (GeckoNode element in this)
				yield return element;
		}

		#endregion

		internal static GeckoNodeCollection Create(nsIDOMNodeList list)
		{
			return list == null ? null : new GeckoNodeCollection( list );
		}
	}
}