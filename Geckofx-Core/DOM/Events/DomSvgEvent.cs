using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gecko.DOM.Events
{
	public sealed class DomSvgZoomEvent
		:DomEventArgs
	{
		private nsIDOMSVGZoomEvent _domSvgEvent;

        private DomSvgZoomEvent(nsIDOMSVGZoomEvent domSvgEvent)
			:base(domSvgEvent)
		{
			_domSvgEvent = domSvgEvent;
		}

		public static DomSvgZoomEvent Create( nsIDOMSVGZoomEvent domSvgEvent )
		{
			return new DomSvgZoomEvent( domSvgEvent );
		}
	}
}
