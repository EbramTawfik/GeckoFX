using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gecko.Certificates
{
	public sealed class CertificateValidity
	{
		private nsIX509CertValidity _validity;

		internal CertificateValidity(nsIX509CertValidity validity)
		{
			_validity = validity;
		}

		public uint NotBefore
		{
			get { return _validity.GetNotBeforeAttribute(); }
		}

		public string NotBeforeLocalTime
		{
			get { return nsString.Get( _validity.GetNotBeforeLocalTimeAttribute ); }
		}

		public string NotBeforeLocalDay
		{
			get { return nsString.Get( _validity.GetNotBeforeLocalDayAttribute ); }
		}

		public string NotBeforeGMT
		{
			get { return nsString.Get( _validity.GetNotBeforeGMTAttribute ); }
		}
	
		public uint NotAfter
		{
			get { return _validity.GetNotAfterAttribute(); }
		}

		public string NotAfterLocalTime
		{
			get { return nsString.Get( _validity.GetNotAfterLocalTimeAttribute ); }
		}

		public string NotAfterLocalDay
		{
			get { return nsString.Get( _validity.GetNotAfterLocalDayAttribute ); }
		}

		public string NotAfterGMT
		{
			get { return nsString.Get( _validity.GetNotAfterGMTAttribute ); }
		}
	}
}
