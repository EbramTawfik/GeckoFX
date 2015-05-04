using Gecko.Certificates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gecko.Events
{
	public sealed class CertOverrideEventArgs : System.ComponentModel.HandledEventArgs
	{
		private string _hostname;
		private int _port;
		private Certificate _certificate;

		public CertOverrideEventArgs(string hostname, int port, Certificate cert)
		{
			_certificate = cert;
			_hostname = hostname;
			_port = port;
		}

		public string Host
		{
			get { return _hostname; }
		}

		public int Port
		{
			get { return _port; }
		}

		public Certificate Certificate
		{
			get { return _certificate; }
		}

		/// <summary>
		/// The errors we want to be overriden
		/// </summary>
		public CertOverride OverrideResult { get; set; }

		public bool Temporary { get; set; }
	}

}
