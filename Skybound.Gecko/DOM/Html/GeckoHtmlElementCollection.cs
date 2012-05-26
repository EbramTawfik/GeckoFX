using System;
using System.Collections.Generic;

namespace Gecko
{
	public class GeckoHtmlElementCollection : GeckoElementCollection
	{
		internal GeckoHtmlElementCollection(nsIDOMHTMLCollection col) : base(null)
		{
			this.Collection = col;
		}
		nsIDOMHTMLCollection Collection;

		public override int Count
		{
			get { return (Collection == null) ? 0 : (int)Collection.GetLengthAttribute(); }
		}

		public override GeckoElement this[int index]
		{
			get
			{
				if (index < 0 || index >= Count)
					throw new ArgumentOutOfRangeException("index");

				return GeckoElement.Create((nsIDOMHTMLElement)Collection.Item((uint)index));
			}
		}

		public override IEnumerator<GeckoElement> GetEnumerator()
		{
			int length = Count;
			for (int i = 0; i < length; i++)
			{
				yield return GeckoElement.Create((nsIDOMHTMLElement)Collection.Item((uint)i));
			}
		}
	}
}