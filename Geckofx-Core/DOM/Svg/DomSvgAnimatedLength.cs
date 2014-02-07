using Gecko.Interop;

namespace Gecko.DOM.Svg
{

#if DELME
	public class DomSvgAnimatedLength
	{
		private InstanceWrapper<nsIDOMSVGAnimatedLength> _domSvgAnimatedLength;

		private DomSvgAnimatedLength( nsIDOMSVGAnimatedLength domSvgAnimatedLength )
		{
			_domSvgAnimatedLength = new InstanceWrapper<nsIDOMSVGAnimatedLength>( domSvgAnimatedLength );
		}

		public DomSvgLength AnimVal
		{
			get { return _domSvgAnimatedLength.Instance.GetAnimValAttribute().Wrap(DomSvgLength.Create); }
		}

		public DomSvgLength BaseVal
		{
			get { return _domSvgAnimatedLength.Instance.GetBaseValAttribute().Wrap(DomSvgLength.Create); }
		}
	}
#endif
}