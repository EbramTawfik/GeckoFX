namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozInputContext : WebIDLBase
    {
        
        public MozInputContext(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public MozInputMethodInputContextTypes Type
        {
            get
            {
                return this.GetProperty<MozInputMethodInputContextTypes>("type");
            }
        }
        
        public MozInputMethodInputContextInputTypes InputType
        {
            get
            {
                return this.GetProperty<MozInputMethodInputContextInputTypes>("inputType");
            }
        }
        
        public nsAString InputMode
        {
            get
            {
                return this.GetProperty<nsAString>("inputMode");
            }
        }
        
        public nsAString Lang
        {
            get
            {
                return this.GetProperty<nsAString>("lang");
            }
        }
        
        public int SelectionStart
        {
            get
            {
                return this.GetProperty<int>("selectionStart");
            }
        }
        
        public int SelectionEnd
        {
            get
            {
                return this.GetProperty<int>("selectionEnd");
            }
        }
        
        public nsAString TextBeforeCursor
        {
            get
            {
                return this.GetProperty<nsAString>("textBeforeCursor");
            }
        }
        
        public nsAString TextAfterCursor
        {
            get
            {
                return this.GetProperty<nsAString>("textAfterCursor");
            }
        }
        
        public Promise < nsAString > GetText(int offset, int length)
        {
            return this.CallMethod<Promise < nsAString >>("getText", offset, length);
        }
        
        public Promise <bool> SetSelectionRange(int start, int length)
        {
            return this.CallMethod<Promise <bool>>("setSelectionRange", start, length);
        }
        
        public Promise <bool> ReplaceSurroundingText(nsAString text, int offset, int length)
        {
            return this.CallMethod<Promise <bool>>("replaceSurroundingText", text, offset, length);
        }
        
        public Promise <bool> DeleteSurroundingText(int offset, int length)
        {
            return this.CallMethod<Promise <bool>>("deleteSurroundingText", offset, length);
        }
        
        public Promise <bool> SendKey(WebIDLUnion<System.Object,System.Int32> dictOrKeyCode, int charCode, int modifiers, bool repeat)
        {
            return this.CallMethod<Promise <bool>>("sendKey", dictOrKeyCode, charCode, modifiers, repeat);
        }
        
        public Promise <bool> Keydown(object dict)
        {
            return this.CallMethod<Promise <bool>>("keydown", dict);
        }
        
        public Promise <bool> Keyup(object dict)
        {
            return this.CallMethod<Promise <bool>>("keyup", dict);
        }
        
        public Promise <bool> SetComposition(nsAString text, int cursor, object[] clauses, object dict)
        {
            return this.CallMethod<Promise <bool>>("setComposition", text, cursor, clauses, dict);
        }
        
        public Promise <bool> EndComposition(nsAString text, object dict)
        {
            return this.CallMethod<Promise <bool>>("endComposition", text, dict);
        }
    }
}
