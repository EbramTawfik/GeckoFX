using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Runtime.CompilerServices;

namespace Skybound.Gecko.Editor
{
	[Guid("972e54e1-dec3-4e3f-87ec-408a7dbcfd92"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIEditor
	{

		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		nsISelection GetSelection();

		/**
		 * Init is to tell the implementation of nsIEditor to begin its services
		 * @param aDoc          The dom document interface being observed
		 * @param aPresShell    TEMP: The presentation shell displaying the document.
		 *                      Once events can tell us from what pres shell
		 *                      they originated, this will no longer be
		 *                      necessary, and the editor will no longer be
		 *                      linked to a single pres shell.
		 * @param aRoot         This is the root of the editable section of this
		 *                      document. If it is null then we get root
		 *                      from document body.
		 * @param aSelCon       this should be used to get the selection location
		 * @param aFlags        A bitmask of flags for specifying the behavior
		 *                      of the editor.
   
		 */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Init([MarshalAs(UnmanagedType.Interface)]nsIDOMDocument doc, IntPtr/*nsIPresShellPtr*/ shell,
							 IntPtr/*nsIContent*/ aRoot,
							 IntPtr/*nsISelectionController*/ aSelCon,
							 ulong aFlags);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetAttributeOrEquivalent([MarshalAs(UnmanagedType.Interface)]nsIDOMElement element,
									  [MarshalAs(UnmanagedType.LPStruct)] nsACString sourceAttrName,
									  [MarshalAs(UnmanagedType.LPStruct)] nsACString sourceAttrValue,
									  bool aSuppressTransaction);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void RemoveAttributeOrEquivalent([MarshalAs(UnmanagedType.Interface)]nsIDOMElement element,
										 [MarshalAs(UnmanagedType.LPStruct)] nsACString sourceAttrName,
										 bool aSuppressTransaction);

		/**
		 * postCreate should be called after Init, and is the time that the editor
		 * tells its documentStateObservers that the document has been created.
		 */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void PostCreate();

		/**
		 * preDestroy is called before the editor goes away, and gives the editor a
		 * chance to tell its documentStateObservers that the document is going away.
		 * @param aDestroyingFrames set to true when the frames being edited
		 * are being destroyed (so there is no need to modify any nsISelections,
		 * nor is it safe to do so)
		 */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void PreDestroy(bool aDestroyingFrames);

		/** edit flags for this editor.  May be set at any time. */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		ulong GetFlags();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetFlags(ulong flags);

		/**
		 * the MimeType of the document
		 */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void GetContentsMIMEType([MarshalAs(UnmanagedType.LPStruct)] nsACString type);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetContentsMIMEType([MarshalAs(UnmanagedType.LPStruct)] nsACString type);

		/** Returns true if we have a document that is not marked read-only */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		bool GetIsDocumentEditable();

		/**
		 * the DOM Document this editor is associated with, refcounted.
		 */
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		nsIDOMDocument GetDocument();

		/** the body element, i.e. the root of the editable document.
		 */

		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		nsIDOMElement GetRootElement();

		/**
		 * the selection controller for the current presentation, refcounted.
		 */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		IntPtr/*nsISelectionController*/ GetSelectionController();


		/* ------------ Selected content removal -------------- */

		/** 
		 * DeleteSelection removes all nodes in the current selection.
		 * @param aDir  if eNext, delete to the right (for example, the DEL key)
		 *              if ePrevious, delete to the left (for example, the BACKSPACE key)
		 */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void DeleteSelection(short action);


		/* ------------ Document info and file methods -------------- */

		/** Returns true if the document has no *meaningful* content */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		bool GetDocumentIsEmpty();

		/** Returns true if the document is modifed and needs saving */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		bool GetDocumentModified();

		/** Sets the current 'Save' document character set */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void GetDocumentCharacterSet([MarshalAs(UnmanagedType.LPStruct)] nsACString charSet);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetDocumentCharacterSet([MarshalAs(UnmanagedType.LPStruct)] nsACString charSet);

		/** to be used ONLY when we need to override the doc's modification
		  * state (such as when it's saved).
		  */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void ResetModificationCount();

		/** Gets the modification count of the document we are editing.
		  * @return the modification count of the document being edited.
		  *         Zero means unchanged.
		  */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		long GetModificationCount();

		/** called each time we modify the document.
		  * Increments the modification count of the document.
		  * @param  aModCount  the number of modifications by which
		  *                    to increase or decrease the count
		  */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void IncrementModificationCount(long aModCount);

		/* ------------ Transaction methods -------------- */

		/** transactionManager Get the transaction manager the editor is using.
		  */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		IntPtr/*nsITransactionManager*/ GetTransactionManager();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetTransactionManager(IntPtr /*nsITransactionManager*/ manager);

		/** doTransaction() fires a transaction.
		  * It is provided here so clients can create their own transactions.
		  * If a transaction manager is present, it is used.  
		  * Otherwise, the transaction is just executed directly.
		  *
		  * @param aTxn the transaction to execute
		  */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void DoTransaction(IntPtr/*nsITransaction*/ txn);


		/** turn the undo system on or off
		  * @param aEnable  if PR_TRUE, the undo system is turned on if available
		  *                 if PR_FALSE the undo system is turned off if it
		  *                 was previously on
		  * @return         if aEnable is PR_TRUE, returns NS_OK if
		  *                 the undo system could be initialized properly
		  *                 if aEnable is PR_FALSE, returns NS_OK.
		  */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void EnableUndo(bool enable);

		/** undo reverses the effects of the last Do operation,
		  * if Undo is enabled in the editor.
		  * It is provided here so clients need no knowledge of whether
		  * the editor has a transaction manager or not.
		  * If a transaction manager is present, it is told to undo,
		  * and the result of that undo is returned.  
		  * Otherwise, the Undo request is ignored and an
		  * error NS_ERROR_NOT_AVAILABLE is returned.
		  *
		  */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Undo(ulong count);

		/** returns state information about the undo system.
		  * @param aIsEnabled [OUT] PR_TRUE if undo is enabled
		  * @param aCanUndo   [OUT] PR_TRUE if at least one transaction is
		  *                         currently ready to be undone.
		  */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void CanUndo(bool isEnabled, bool canUndo);

		/** redo reverses the effects of the last Undo operation
		  * It is provided here so clients need no knowledge of whether
		  * the editor has a transaction manager or not.
		  * If a transaction manager is present, it is told to redo and the
		  * result of the previously undone transaction is reapplied to the document.
		  * If no transaction is available for Redo, or if the document
		  * has no transaction manager, the Redo request is ignored and an
		  * error NS_ERROR_NOT_AVAILABLE is returned.
		  *
		  */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Redo(ulong count);

		/** returns state information about the redo system.
		  * @param aIsEnabled [OUT] PR_TRUE if redo is enabled
		  * @param aCanRedo   [OUT] PR_TRUE if at least one transaction is
									currently ready to be redone.
		  */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void CanRedo(bool isEnabled, bool canRedo);

		/** beginTransaction is a signal from the caller to the editor that
		  * the caller will execute multiple updates to the content tree
		  * that should be treated as a single logical operation,
		  * in the most efficient way possible.<br>
		  * All transactions executed between a call to beginTransaction and
		  * endTransaction will be undoable as an atomic action.<br>
		  * endTransaction must be called after beginTransaction.<br>
		  * Calls to beginTransaction can be nested, as long as endTransaction
		  * is called once per beginUpdate.
		  */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void BeginTransaction();

		/** endTransaction is a signal to the editor that the caller is
		  * finished updating the content model.<br>
		  * beginUpdate must be called before endTransaction is called.<br>
		  * Calls to beginTransaction can be nested, as long as endTransaction
		  * is called once per beginTransaction.
		  */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void EndTransaction();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void BeginPlaceHolderTransaction(IntPtr/*nsIAtom*/ name);
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void EndPlaceHolderTransaction();
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		bool ShouldTxnSetSelection();

		/** Set the flag that prevents insertElementTxn from changing the selection
		  * @param   should  Set false to suppress changing the selection;
		  *                  i.e., before using InsertElement() to insert
		  *                  under <head> element
		  * WARNING: You must be very careful to reset back to PR_TRUE after
		  *          setting PR_FALSE, else selection/caret is trashed
		  *          for further editing.
		  */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetShouldTxnSetSelection(bool should);

		/* ------------ Inline Spell Checking methods -------------- */

		/** Returns the inline spell checker associated with this object. The spell
		  * checker is lazily created, so this function may create the object for
		  * you during this call.
		  * @param  autoCreate  If true, this will create a spell checker object
		  *                     if one does not exist yet for this editor. If false
		  *                     and the object has not been created, this function
		  *                     WILL RETURN NULL.
		  */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		nsIInlineSpellChecker GetInlineSpellChecker(bool autoCreate);

		/** Resyncs spellchecking state (enabled/disabled).  This should be called
		  * when anything that affects spellchecking state changes, such as the
		  * spellcheck attribute value.
		  */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SyncRealTimeSpell();

		/** Called when the user manually overrides the spellchecking state for this
		  * editor.
		  * @param  enable  The new state of spellchecking in this editor, as
		  *                 requested by the user.
		  */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetSpellcheckUserOverride(bool enable);

		/* ------------ Clipboard methods -------------- */

		/** cut the currently selected text, putting it into the OS clipboard
		  * What if no text is selected?
		  * What about mixed selections?
		  * What are the clipboard formats?
		  */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Cut();

		/** Can we cut? True if the doc is modifiable, and we have a non-
		  * collapsed selection.
		  */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		bool CanCut();

		/** copy the currently selected text, putting it into the OS clipboard
		  * What if no text is selected?
		  * What about mixed selections?
		  * What are the clipboard formats?
		  */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Copy();

		/** Can we copy? True if we have a non-collapsed selection.
		  */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		bool CanCopy();

		/** paste the text in the OS clipboard at the cursor position, replacing
		  * the selected text (if any)
		  */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Paste(long aSelectionType);

		/** Paste the text in |aTransferable| at the cursor position, replacing the
		  * selected text (if any).
		  */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void PasteTransferable(IntPtr/*nsITransferable*/ aTransferable);

		/** Can we paste? True if the doc is modifiable, and we have
		  * pasteable data in the clipboard.
		  */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		bool CanPaste(long aSelectionType);

		/** Can we paste |aTransferable| or, if |aTransferable| is null, will a call
		  * to pasteTransferable later possibly succeed if given an instance of
		  * nsITransferable then? True if the doc is modifiable, and, if
		  * |aTransfeable| is non-null, we have pasteable data in |aTransfeable|.
		  */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		bool CanPasteTransferable(IntPtr/*nsITransferable*/ aTransferable);

		/* ------------ Selection methods -------------- */

		/** sets the document selection to the entire contents of the document */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SelectAll();

		/** sets the document selection to the beginning of the document */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void BeginningOfDocument();

		/** sets the document selection to the end of the document */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void EndOfDocument();

		/* ------------ Drag/Drop methods -------------- */

		/** 
		 * canDrag decides if a drag should be started
		 * (for example, based on the current selection and mousepoint).
		 */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		bool CanDrag(nsIDOMEvent aEvent);

		/** 
		 * doDrag transfers the relevant data (as appropriate)
		 * to a transferable so it can later be dropped.
		 */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void DoDrag(nsIDOMEvent aEvent);

		/** 
		 * insertFromDrop looks for a dragsession and inserts the
		 * relevant data in response to a drop.
		 */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void InsertFromDrop(nsIDOMEvent aEvent);

		/* ------------ Node manipulation methods -------------- */

		/**
		 * setAttribute() sets the attribute of aElement.
		 * No checking is done to see if aAttribute is a legal attribute of the node,
		 * or if aValue is a legal value of aAttribute.
		 *
		 * @param aElement    the content element to operate on
		 * @param aAttribute  the string representation of the attribute to set
		 * @param aValue      the value to set aAttribute to
		 */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetAttribute(nsIDOMElement aElement, [MarshalAs(UnmanagedType.LPStruct)] nsACString attributestr,
						  [MarshalAs(UnmanagedType.LPStruct)] nsACString attvalue);

		/**
		 * getAttributeValue() retrieves the attribute's value for aElement.
		 *
		 * @param aElement      the content element to operate on
		 * @param aAttribute    the string representation of the attribute to get
		 * @param aResultValue  [OUT] the value of aAttribute.
		 *                      Only valid if aResultIsSet is PR_TRUE
		 * @return              PR_TRUE if aAttribute is set on the current node,
		 *                      PR_FALSE if it is not.
		 */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		bool GetAttributeValue(nsIDOMElement aElement,
								  [MarshalAs(UnmanagedType.LPStruct)] nsACString attributestr,
								  [MarshalAs(UnmanagedType.LPStruct)] nsACString resultValue);

		/**
		 * removeAttribute() deletes aAttribute from the attribute list of aElement.
		 * If aAttribute is not an attribute of aElement, nothing is done.
		 *
		 * @param aElement      the content element to operate on
		 * @param aAttribute    the string representation of the attribute to get
		 */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void RemoveAttribute(nsIDOMElement aElement,
							 [MarshalAs(UnmanagedType.LPStruct)] nsACString aAttribute);

		/**
		 * cloneAttribute() copies the attribute from the source node to
		 * the destination node and delete those not in the source.
		 *
		 * The supplied nodes MUST BE ELEMENTS (most callers are working with nodes)
		 * @param aAttribute    the name of the attribute to copy
		 * @param aDestNode     the destination element to operate on
		 * @param aSourceNode   the source element to copy attributes from
		 * @exception NS_ERROR_NULL_POINTER at least one of the nodes is null
		 * @exception NS_ERROR_NO_INTERFACE at least one of the nodes is not an
		 *                                  element
		 */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void CloneAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACString aAttribute,
							nsIDOMNode aDestNode, nsIDOMNode aSourceNode);

		/**
		 * cloneAttributes() is similar to nsIDOMNode::cloneNode(),
		 *   it assures the attribute nodes of the destination are identical
		 *   with the source node by copying all existing attributes from the
		 *   source and deleting those not in the source.
		 *   This is used when the destination node (element) already exists
		 *
		 * The supplied nodes MUST BE ELEMENTS (most callers are working with nodes)
		 * @param aDestNode     the destination element to operate on
		 * @param aSourceNode   the source element to copy attributes from
		 */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void CloneAttributes(nsIDOMNode destNode, nsIDOMNode sourceNode);

		/** 
		 * createNode instantiates a new element of type aTag and inserts it
		 * into aParent at aPosition.
		 * @param aTag      The type of object to create
		 * @param aParent   The node to insert the new object into
		 * @param aPosition The place in aParent to insert the new node
		 * @return          The node created.  Caller must release aNewNode.
		 */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		nsIDOMNode CreateNode([MarshalAs(UnmanagedType.LPStruct)] nsACString tag,
							  nsIDOMNode parent,
							  long position);

		/** 
		 * insertNode inserts aNode into aParent at aPosition.
		 * No checking is done to verify the legality of the insertion.
		 * That is the responsibility of the caller.
		 * @param aNode     The DOM Node to insert.
		 * @param aParent   The node to insert the new object into
		 * @param aPosition The place in aParent to insert the new node
		 *                  0=first child, 1=second child, etc.
		 *                  any number > number of current children = last child
		 */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void InsertNode(nsIDOMNode node,
						nsIDOMNode parent,
						long aPosition);

		/** 
		 * splitNode() creates a new node identical to an existing node,
		 * and split the contents between the two nodes
		 * @param aExistingRightNode   the node to split.
		 *                             It will become the new node's next sibling.
		 * @param aOffset              the offset of aExistingRightNode's
		 *                             content|children to do the split at
		 * @param aNewLeftNode         [OUT] the new node resulting from the split,
		 *                             becomes aExistingRightNode's previous sibling.
		 */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SplitNode(nsIDOMNode existingRightNode,
					   long offset,
					   out nsIDOMNode newLeftNode);

		/** 
		 * joinNodes() takes 2 nodes and merge their content|children.
		 * @param aLeftNode     The left node.  It will be deleted.
		 * @param aRightNode    The right node. It will remain after the join.
		 * @param aParent       The parent of aExistingRightNode
		 *
		 *                      There is no requirement that the two nodes be
		 *                      of the same type.  However, a text node can be
		 *                      merged only with another text node.
		 */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void JoinNodes(nsIDOMNode leftNode,
					   nsIDOMNode rightNode,
					   nsIDOMNode parent);

		/** 
		 * deleteNode removes aChild from aParent.
		 * @param aChild    The node to delete
		 */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void DeleteNode(nsIDOMNode child);

		/** 
		 * markNodeDirty() sets a special dirty attribute on the node.
		 * Usually this will be called immediately after creating a new node.
		 * @param aNode      The node for which to insert formatting.
		 */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void MarkNodeDirty(nsIDOMNode node);

		/* ---------- direction controller ---------- */

		/** 
		 * Switches the editor element direction; from "Left-to-Right" to
		 * "Right-to-Left", and vice versa.
		 */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SwitchTextDirection();

		/* ------------ Output methods -------------- */
		/**
		  * Output methods:
		  * aFormatType is a mime type, like text/plain.
		  */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void OutputToString([MarshalAs(UnmanagedType.LPStruct)]nsAString formatType,
                          ulong flags, [MarshalAs(UnmanagedType.LPStruct)]nsAString retval);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void OutputToStream(IntPtr /*nsIOutputStream*/ aStream,
                       [MarshalAs(UnmanagedType.LPStruct)]nsAString formatType,
                       [MarshalAs(UnmanagedType.LPStruct)]nsACString charsetOverride,
                       ulong flags);
 
 
		/* ------------ Various listeners methods --------------
		  * nsIEditor holds strong references to the editor observers, action listeners
		  * and document state listeners.
		  */
   
		/** add an EditorObserver to the editors list of observers. */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void AddEditorObserver(IntPtr/*nsIEditorObserver*/ observer);
 
		/** Remove an EditorObserver from the editor's list of observers. */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void RemoveEditorObserver(IntPtr/*nsIEditorObserver*/ observer);
 
		/** add an EditActionListener to the editors list of listeners. */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void AddEditActionListener(IntPtr /*nsIEditActionListener*/ listener);
 
		/** Remove an EditActionListener from the editor's list of listeners. */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void RemoveEditActionListener(IntPtr /*nsIEditActionListener*/ listener);
 
		/** Add a DocumentStateListener to the editors list of doc state listeners. */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void AddDocumentStateListener(IntPtr /*nsIDocumentStateListener*/ listener);
 
		/** Remove a DocumentStateListener to the editors list of doc state listeners. */
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void RemoveDocumentStateListener(IntPtr /*nsIDocumentStateListener*/ listener);
	}
}

