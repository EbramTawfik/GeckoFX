using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gecko.Interop;

namespace Gecko.DOM.Svg
{
	internal class SvgMatrix
	{
		private InstanceWrapper<nsIDOMSVGMatrix> _domSvgMatrix;

		private SvgMatrix( nsIDOMSVGMatrix domSvgMatrix )
		{
			_domSvgMatrix = new InstanceWrapper<nsIDOMSVGMatrix>( domSvgMatrix );
		}

		public static SvgMatrix Create( nsIDOMSVGMatrix domSvgMatrix )
		{
			return new SvgMatrix( domSvgMatrix );
		}


		public float A
		{
			get { return _domSvgMatrix.Instance.GetAAttribute(); }
			set { _domSvgMatrix.Instance.SetAAttribute( value ); }
		}

		/// <summary>
		/// raises DOMException on setting
		/// </summary>
		public float B
		{
			get { return _domSvgMatrix.Instance.GetBAttribute(); }
			set { _domSvgMatrix.Instance.SetBAttribute(value); }
		}

		/// <summary>
		/// raises DOMException on setting
		/// </summary>
		public float C
		{
			get { return _domSvgMatrix.Instance.GetCAttribute(); }
			set { _domSvgMatrix.Instance.SetCAttribute(value); }
		}

		/// <summary>
		/// raises DOMException on setting
		/// </summary>
		public float D
		{
			get { return _domSvgMatrix.Instance.GetDAttribute(); }
			set { _domSvgMatrix.Instance.SetDAttribute(value); }
		}

		/// <summary>
		/// raises DOMException on setting
		/// </summary>
		public float E
		{
			get { return _domSvgMatrix.Instance.GetEAttribute(); }
			set { _domSvgMatrix.Instance.SetEAttribute(value); }
		}

		/// <summary>
		/// raises DOMException on setting
		/// </summary>
		public float F
		{
			get { return _domSvgMatrix.Instance.GetFAttribute(); }
			set { _domSvgMatrix.Instance.SetFAttribute(value); }
		}

		public SvgMatrix Multiply(SvgMatrix secondMatrix)
		{
			return _domSvgMatrix.Instance.Multiply( secondMatrix._domSvgMatrix.Instance ).Wrap( Create );
		}

		public SvgMatrix Inverse()
		{
			return _domSvgMatrix.Instance.Inverse().Wrap( Create );
		}

		public SvgMatrix Translate( float x, float y )
		{
			return _domSvgMatrix.Instance.Translate( x, y ).Wrap( Create );
		}

		public SvgMatrix Scale( float scaleFactor )
		{
			return _domSvgMatrix.Instance.Scale( scaleFactor ).Wrap( Create );
		}

		public SvgMatrix ScaleNonUniform( float scaleFactorX, float scaleFactorY )
		{
			return _domSvgMatrix.Instance.ScaleNonUniform( scaleFactorX, scaleFactorY ).Wrap( Create );
		}

		public SvgMatrix Rotate( float angle )
		{
			return _domSvgMatrix.Instance.Rotate( angle ).Wrap( Create );
		}

		public SvgMatrix RotateFromVector( float x, float y )
		{
			return _domSvgMatrix.Instance.RotateFromVector( x, y ).Wrap( Create );
		}

		public SvgMatrix FlipX()
		{
			return _domSvgMatrix.Instance.FlipX().Wrap( Create );
		}

		public SvgMatrix FlipY()
		{
			return _domSvgMatrix.Instance.FlipY().Wrap(Create);
		}

		public SvgMatrix SkewX( float angle )
		{
			return _domSvgMatrix.Instance.SkewX( angle ).Wrap( Create );
		}

		public SvgMatrix SkewY(float angle)
		{
			return _domSvgMatrix.Instance.SkewY(angle).Wrap(Create);
		}
		
	}
}
