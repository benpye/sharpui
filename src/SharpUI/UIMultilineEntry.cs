using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

using static SharpUI.NativeMethods;

namespace SharpUI
{
    public class UIMultilineEntry : UIControl
    {
        public UIMultilineEntry()
            : base(CreateMultilineEntry(), true)
        {
            onChangedDelegate = InternalOnChanged;
            uiMultilineEntryOnChanged(handle, onChangedDelegate, IntPtr.Zero);
        }

        private static IntPtr CreateMultilineEntry()
        {
            return uiNewMultilineEntry();
        }

        public string Text
        {
            get
            {
                IntPtr ptr = uiMultilineEntryText(handle);
                string str = MarshalHelper.StringFromUTF8(ptr);
                uiFreeText(ptr);
                return str;
            }

            set
            {
                IntPtr ptr = MarshalHelper.StringToUTF8(value);
                uiMultilineEntrySetText(handle, ptr);
                Marshal.FreeHGlobal(ptr);
            }
        }

        public void Append(string text)
        {
            IntPtr ptr = MarshalHelper.StringToUTF8(text);
            uiMultilineEntryAppend(handle, ptr);
            Marshal.FreeHGlobal(ptr);
        }

        public bool ReadOnly
        {
            get { return uiMultilineEntryReadOnly(handle) == 0 ? false : true; }
            set { uiMultilineEntrySetReadOnly(handle, value ? 1 : 0); }
        }

        private uiMultilineEntryOnChangedDelegate onChangedDelegate;

        private void InternalOnChanged(IntPtr b, IntPtr data)
        {
            OnChanged?.Invoke();
        }

        public event Action OnChanged;
    }
}
