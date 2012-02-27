using System.Runtime.CompilerServices;

namespace Gecko.Certificates
{
	public sealed class CertTreeItem
	{
		private nsICertTreeItem _certTreeItem;

		internal CertTreeItem(nsICertTreeItem certTreeItem)
		{
			_certTreeItem = certTreeItem;
		}

		public Certificate Certificate
		{
			get { return Certificate.Create( _certTreeItem.GetCertAttribute() ); }
		}

		public string HostPort
		{
			get { return nsString.Get( _certTreeItem.GetHostPortAttribute ); }
		}
	}
}