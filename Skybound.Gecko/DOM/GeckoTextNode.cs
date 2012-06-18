namespace Gecko.DOM
{
	public class GeckoTextNode
		:DomCharacterData
	{
		private nsIDOMText _domText;

		internal GeckoTextNode(nsIDOMText domText)
			:base(domText)
		{
			_domText = domText;
		}

		public static GeckoTextNode CreateTextNodeWrapper(nsIDOMText domText)
		{
			return domText == null ? null : new GeckoTextNode( domText );
		}


		public GeckoTextNode SplitText(uint offset)
		{
			return CreateTextNodeWrapper( _domText.SplitText( offset ) );
		}


		public string WholeText
		{
			get { return nsString.Get( _domText.GetWholeTextAttribute ); }
		}
	}
}