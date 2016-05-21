using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

using static SharpUI.NativeMethods;

namespace SharpUI
{
    public class UICombobox : UIControl
    {
        public UICombobox(bool editable = false)
            : base(CreateCombobox(editable), true)
        {
            onSelectedDelegate = InternalOnSelected;
            uiComboboxOnSelected(handle, onSelectedDelegate, IntPtr.Zero);
        }

        private static IntPtr CreateCombobox(bool editable)
        {
            if (editable)
                return uiNewEditableCombobox();
            else
                return uiNewCombobox();
        }

        public Int64 Selected
        {
            get { return uiComboboxSelected(handle); }
            set { uiComboboxSetSelected(handle, value); }
        }

        public void Append(string text)
        {
            IntPtr ptr = MarshalHelper.StringToUTF8(text);
            uiComboboxAppend(handle, ptr);
            Marshal.FreeHGlobal(ptr);
        }

        private uiComboboxOnSelectedDelegate onSelectedDelegate;

        private void InternalOnSelected(IntPtr b, IntPtr data)
        {
            OnSelected?.Invoke(this);
        }

        public event Action<UICombobox> OnSelected;
    }
}
