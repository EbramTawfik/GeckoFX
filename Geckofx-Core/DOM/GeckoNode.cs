using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Diagnostics;
using Gecko.DOM;
using Gecko.Interop;

namespace Gecko
{
	/// <summary>
	/// Provides a base class for DOM nodes.
	/// </summary>
	public class GeckoNode
	{
		static GeckoWrapperCache<nsIDOMNode, GeckoNode> m_nodeCache = new GeckoWrapperCache<nsIDOMNode, GeckoNode>(DOMSelector.CreateDomNodeWrapper);

		#region fields
		nsIDOMNode _domNode;
		#endregion

		#region ctor & creation methods
		internal GeckoNode(nsIDOMNode domObject)
		{
			//ComDebug.WriteDebugInfo( domObject );
			_domNode = domObject;
		}

		internal static GeckoNode Create(nsIDOMNode domObject)
		{
			return m_nodeCache.Get(domObject);
		}
		#endregion


		#region Properties for Native XPCOM objects access
		/// <summary>
		/// Gets the underlying XPCOM object.
		/// </summary>
		public nsIDOMNode DomObject
		{
			get { return _domNode; }
		}
		#endregion


		public override bool Equals(object obj)
		{
			if (this == obj) return true;
			if ( obj is GeckoNode )
			{
				// compare native objects, NOT wrappers
				return this._domNode.GetHashCode() == ( ( GeckoNode ) obj )._domNode.GetHashCode();
			}
			return false;
		}

		public override int GetHashCode()
		{
			return _domNode.GetHashCode();
			//IntPtr pUnk = Marshal.GetIUnknownForObject(this._domNode);
			//try
			//{
			//    return pUnk.GetHashCode();
			//}
			//finally
			//{
			//    if (pUnk != IntPtr.Zero)
			//        Marshal.Release(pUnk);
			//}
		}

		/// <summary>
		/// Gets the text contents of the node.
		/// </summary>
		public string TextContent
		{
			get { return nsString.Get(_domNode.GetTextContentAttribute); }
			set { nsString.Set(_domNode.SetTextContentAttribute, value); }
		}

		/// <summary>
		/// Gets or sets the value of the node.
		/// </summary>
		public string NodeValue
		{
			get { return nsString.Get(_domNode.GetNodeValueAttribute); }
			set { nsString.Set(_domNode.SetNodeValueAttribute, value); }
		}

		/// <summary>
		/// Gets a collection containing all child nodes of this node.
		/// </summary>
		public GeckoNodeCollection ChildNodes
		{
			get { return _domNode.GetChildNodesAttribute().Wrap( GeckoNodeCollection.Create ); }
		}

		public GeckoNode FirstChild { get { return _domNode.GetFirstChildAttribute().Wrap(Create); } }
		public GeckoNode LastChild { get { return _domNode.GetLastChildAttribute().Wrap(Create); } }
		public GeckoNode NextSibling { get { return _domNode.GetNextSiblingAttribute().Wrap(Create); } }
		public GeckoNode PreviousSibling { get { return _domNode.GetPreviousSiblingAttribute().Wrap(Create); } }
		public bool HasChildNodes { get { return _domNode.HasChildNodes(); } }
		public bool HasAttributes { get { return _domNode.HasAttributes(); } }

		public GeckoDocument OwnerDocument
		{
			get { return GeckoDocument.Create(Xpcom.QueryInterface<nsIDOMHTMLDocument>(_domNode.GetOwnerDocumentAttribute())); }
		}

		public GeckoNode AppendChild(GeckoNode node)
		{
			if (node == null)
				throw new ArgumentNullException("node");

			_domNode.AppendChild(node._domNode);
			return node;
		}

		public GeckoNode CloneNode(bool deep)
		{
			return GeckoNode.Create(_domNode.CloneNode(deep, 1));
		}

		public GeckoNode InsertBefore(GeckoNode newChild, GeckoNode before)
		{
			if (newChild == null)
				throw new ArgumentNullException("newChild");
			if (before == null)
				throw new ArgumentNullException("before");

			_domNode.InsertBefore(newChild._domNode, before._domNode);
			return newChild;
		}

		public GeckoNode RemoveChild(GeckoNode node)
		{
			if (node == null)
				throw new ArgumentNullException("node");

			_domNode.RemoveChild(node._domNode);
			return node;
		}

		public GeckoNode ReplaceChild(GeckoNode newChild, GeckoNode oldChild)
		{
			if (newChild == null)
				throw new ArgumentNullException("newChild");
			if (oldChild == null)
				throw new ArgumentNullException("oldChild");

			_domNode.ReplaceChild(newChild._domNode, oldChild._domNode);
			return newChild;
		}

		public string NamespaceURI
		{
			get { return nsString.Get(_domNode.GetNamespaceURIAttribute); }
		}

		public string Prefix
		{
			get { return nsString.Get(_domNode.GetPrefixAttribute); }
		}

		public string LocalName
		{
			get { return nsString.Get(_domNode.GetLocalNameAttribute); }
		}

		public GeckoNamedNodeMap Attributes
		{
			get { return _domNode.GetAttributesAttribute().Wrap( GeckoNamedNodeMap.Create ); }
		}

		private NodeType m_cachedType;

		public NodeType NodeType
		{
			get {
				if (m_cachedType != 0)
					return m_cachedType;

				return m_cachedType = (NodeType)_domNode.GetNodeTypeAttribute(); 
			}
		}

		public GeckoNode ParentNode
		{
			get { return _domNode.GetParentNodeAttribute().Wrap( Create ); }
		}

		public GeckoElement ParentElement
		{
			get
			{
				nsIDOMNode node = _domNode.GetParentNodeAttribute();
				while ( node != null && !( node is nsIDOMElement ) )
				{
					node = node.GetParentNodeAttribute();
				}
				// after cycle node is nsIDOMElement or null

				return ((nsIDOMElement)node).Wrap(GeckoElement.CreateDomElementWrapper);
			}
		}

		/// <summary>
		/// Get GeckoNodes from give xpath expression.
		/// </summary>
		/// <param name="xpath"></param>
		/// <returns></returns>
		public IEnumerable<GeckoNode> GetNodes(string xpath)
		{
			var evaluator = Xpcom.CreateInstance2<nsIDOMXPathEvaluator>( Contracts.XPathEvaluator );
			nsIDOMNode node = (nsIDOMNode)this.DomObject;
			nsIDOMXPathNSResolver resolver = evaluator.Instance.CreateNSResolver(node);
			nsIDOMXPathResult result = (nsIDOMXPathResult)evaluator.Instance.Evaluate(new nsAString(xpath), node, resolver, 0, null);

			return new GeckoNodeEnumerable(result);
		}

		/// <summary>
		/// Get GeckoNodes from give xpath expression.
		/// </summary>
		/// <param name="xpath"></param>
		/// <returns></returns>
		public IEnumerable<GeckoHtmlElement> GetElements(string xpath)
		{
			var evaluator = Xpcom.CreateInstance2<nsIDOMXPathEvaluator>(Contracts.XPathEvaluator);
			nsIDOMNode node = (nsIDOMNode)this.DomObject;
			nsIDOMXPathNSResolver resolver = evaluator.Instance.CreateNSResolver(node);
			nsIDOMXPathResult result = (nsIDOMXPathResult)evaluator.Instance.Evaluate(new nsAString(xpath), node, resolver, 0, null);

			return new GeckoElementEnumerable(result);
		}


		public DomEventTarget GetEventTarget()
		{
			var eventTarget = Xpcom.QueryInterface<nsIDOMEventTarget>( _domNode );
			return eventTarget.Wrap( DomEventTarget.Create );
		}
	}
}
