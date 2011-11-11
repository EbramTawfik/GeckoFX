using System;

namespace Skybound.Gecko
{

	public class GeckoMarkupDocumentViewer
	{
		nsIMarkupDocumentViewer m_markupDocumentViewer;

		public GeckoMarkupDocumentViewer(nsIMarkupDocumentViewer markupDocumentView)
		{
			m_markupDocumentViewer = markupDocumentView;
		}

		/// <summary>
		///Scrolls to a given DOM content node.
		///	</summary>
		public void ScrollToNode(GeckoNode node)
		{
			m_markupDocumentViewer.ScrollToNode(node.DomObject);
		}

		/// <summary>
		///The amount by which to scale all text. Default is 1.0. 
		/// </summary>		
		public float GetTextZoomAttribute()
		{
			return m_markupDocumentViewer.GetTextZoomAttribute();
		}

		/// <summary>
		///The amount by which to scale all text. Default is 1.0. 
		/// </summary>		
		public void SetTextZoomAttribute(float aTextZoom)
		{
			m_markupDocumentViewer.SetTextZoomAttribute(aTextZoom);
		}

		/// <summary>
		///The amount by which to scale all lengths. Default is 1.0. 
		///</summary>		
		public float GetFullZoomAttribute()
		{
			return m_markupDocumentViewer.GetFullZoomAttribute();
		}

		/// <summary>
		///The amount by which to scale all lengths. Default is 1.0. 
		///</summary>		
		public void SetFullZoomAttribute(float aFullZoom)
		{
			m_markupDocumentViewer.SetFullZoomAttribute(aFullZoom);
		}

		/// <summary>
		///Disable entire author style level (including HTML presentation hints) 
		/// </summary>		
		public bool GetAuthorStyleDisabledAttribute()
		{
			return m_markupDocumentViewer.GetAuthorStyleDisabledAttribute();
		}

		/// <summary>
		///Disable entire author style level (including HTML presentation hints) 
		/// </summary>		
		public void SetAuthorStyleDisabledAttribute(bool aAuthorStyleDisabled)
		{
			m_markupDocumentViewer.SetAuthorStyleDisabledAttribute(aAuthorStyleDisabled);
		}

		public string GetDefaultCharacterSetAttribute()
		{
			return nsString.Get(m_markupDocumentViewer.GetDefaultCharacterSetAttribute);
		}


		public void SetDefaultCharacterSetAttribute(string aDefaultCharacterSet)
		{
			nsString.Set(m_markupDocumentViewer.SetDefaultCharacterSetAttribute, aDefaultCharacterSet);			
		}

		public string GetForceCharacterSetAttribute()
		{
			return nsString.Get(m_markupDocumentViewer.GetForceCharacterSetAttribute);
		}


		public void SetForceCharacterSetAttribute(string aForceCharacterSet)
		{
			nsString.Set(m_markupDocumentViewer.SetForceCharacterSetAttribute, aForceCharacterSet);
		}

		public string GetHintCharacterSetAttribute()
		{
			return nsString.Get(m_markupDocumentViewer.GetHintCharacterSetAttribute);
		}

		public void SetHintCharacterSetAttribute(string aHintCharacterSet)
		{
			nsString.Set(m_markupDocumentViewer.GetHintCharacterSetAttribute, aHintCharacterSet);
		}

		public int GetHintCharacterSetSourceAttribute()
		{
			return m_markupDocumentViewer.GetHintCharacterSetSourceAttribute();
		}

		public void SetHintCharacterSetSourceAttribute(int aHintCharacterSetSource)
		{
			m_markupDocumentViewer.SetHintCharacterSetSourceAttribute(aHintCharacterSetSource);
		}
		
		public string GetPrevDocCharacterSetAttribute()
		{
			return nsString.Get(m_markupDocumentViewer.GetPrevDocCharacterSetAttribute);
		}

		
		public void SetPrevDocCharacterSetAttribute(string aPrevDocCharacterSet)
		{
			nsString.Set(m_markupDocumentViewer.SetPrevDocCharacterSetAttribute, aPrevDocCharacterSet);
		}

		/// <summary>
		/// Tell the container to shrink-to-fit or grow-to-fit its contents
		///	</summary>		
		public void SizeToContent()
		{
			m_markupDocumentViewer.SizeToContent();
		}

		/// <summary>
		/// Use this attribute to access all the Bidi options in one operation
		/// </summary>	
		public uint GetBidiOptionsAttribute()
		{
			return m_markupDocumentViewer.GetBidiOptionsAttribute();
		}

		/// <summary>
		/// Use this attribute to access all the Bidi options in one operation
		/// </summary>
		public void SetBidiOptionsAttribute(uint aBidiOptions)
		{
			m_markupDocumentViewer.SetBidiOptionsAttribute(aBidiOptions);
		}

		/// <summary>
		///The minimum font size 
		///</summary>		
		public int GetMinFontSizeAttribute()
		{
			return m_markupDocumentViewer.GetMinFontSizeAttribute();
		}

		/// <summary>
		///The minimum font size 
		///</summary>		
		public void SetMinFontSizeAttribute(int aMinFontSize)
		{
			m_markupDocumentViewer.SetMinFontSizeAttribute(aMinFontSize);
		}
	}
}