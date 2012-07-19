namespace Gecko.DOM.Svg
{
	public class SvgSvgElement
		:SvgElement
	{
		protected SvgSvgElement(nsIDOMSVGSVGElement svgSvgElement)
			:base(svgSvgElement)
		{
			
		}

		public static SvgSvgElement CreateSvgSvgElementWrapper(nsIDOMSVGSVGElement svgSvgElement)
		{
			return svgSvgElement == null ? null : new SvgSvgElement( svgSvgElement );
		}
	}
}