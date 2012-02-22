namespace Gecko
{
	public enum NodeType
	{
		Element = nsIDOMNodeConstants.ELEMENT_NODE,
		Attribute = nsIDOMNodeConstants.ATTRIBUTE_NODE,
		Text = nsIDOMNodeConstants.TEXT_NODE,
		CDataSection = nsIDOMNodeConstants.CDATA_SECTION_NODE,
		EntityReference = nsIDOMNodeConstants.ENTITY_REFERENCE_NODE,
		Entity = nsIDOMNodeConstants.ENTITY_NODE,
		ProcessingInstruction = nsIDOMNodeConstants.PROCESSING_INSTRUCTION_NODE,
		Comment = nsIDOMNodeConstants.COMMENT_NODE,
		Document = nsIDOMNodeConstants.DOCUMENT_NODE,
		DocumentType = nsIDOMNodeConstants.DOCUMENT_TYPE_NODE,
		DocumentFragment = nsIDOMNodeConstants.DOCUMENT_FRAGMENT_NODE,
		Notation = nsIDOMNodeConstants.NOTATION_NODE
	}
}