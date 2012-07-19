namespace Gecko.DOM.Svg
{
	public class SvgDocument
		:GeckoDomDocument
	{
		private nsIDOMSVGDocument _svgDocument;

		internal SvgDocument(nsIDOMSVGDocument svgDocument)
			:base(svgDocument)
		{
			_svgDocument = svgDocument;
		}

		public string Domain
		{
			get { return nsString.Get( _svgDocument.GetDomainAttribute ); }
		}

		public string Url
		{
			get { return nsString.Get(_svgDocument.GetURLAttribute); }
		}

		public SvgSvgElement RootElement
		{
			get { return SvgSvgElement.CreateSvgSvgElementWrapper( _svgDocument.GetRootElementAttribute() ); }
		}

	}
}