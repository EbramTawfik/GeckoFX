using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gecko.DOM.Svg
{
	public class SvgElement
		:GeckoDomElement
	{
		private nsIDOMSVGElement _svgElement;

		protected SvgElement(nsIDOMSVGElement svgElement)
			:base(svgElement)
		{
			_svgElement = svgElement;
		}

		public string ID
		{
			get { return nsString.Get( _svgElement.GetIdAttribute ); }
			set{nsString.Set(_svgElement.SetIdAttribute,value  );}
		}

		public SvgSvgElement OwnerSvgElement
		{
			get { return SvgSvgElement.CreateSvgSvgElementWrapper( _svgElement.GetOwnerSVGElementAttribute() ); }
		}
		
		public SvgElement ViewportElement
		{
			get { return CreateSvgElementWrapper( _svgElement.GetViewportElementAttribute() ); }
		}

		public static SvgElement CreateSvgElementWrapper(nsIDOMSVGElement svgElement)
		{
			return svgElement == null ? null : new SvgElement(svgElement);
		}
	}
}
