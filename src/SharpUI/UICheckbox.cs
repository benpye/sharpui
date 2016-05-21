using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

using static SharpUI.NativeMethods;

namespace SharpUI
{
    public class UICheckbox : UIControl
    {
        public UICheckbox(string text)
            : base(CreateCheckbox(text), true)
        {
            onToggledDelegate = InternalOnToggled;
            uiCheckboxOnToggled(handle, onToggledDelegate, IntPtr.Zero);
        }

        private static IntPtr CreateCheckbox(string text)
        {
            IntPtr ptr = MarshalHelper.StringToUTF8(text);
            IntPtr handle = uiNewCheckbox(ptr);
            Marshal.FreeHGlobal(ptr);
            return handle;
        }

        public string Text
        {
            get
            {
                IntPtr ptr = uiCheckboxText(handle);
                string str = MarshalHelper.StringFromUTF8(ptr);
                uiFreeText(ptr);
                return str;
            }

            set
            {
                IntPtr ptr = MarshalHelper.StringToUTF8(value);
                uiCheckboxSetText(handle, ptr);
                Marshal.FreeHGlobal(ptr);
            }
        }

        public bool Checked
        {
            get { return uiCheckboxChecked(handle) == 0 ? false : true; }
            set { uiCheckboxSetChecked(handle, value ? 1 : 0); }
        }

        private uiCheckboxOnToggledDelegate onToggledDelegate;

        private void InternalOnToggled(IntPtr b, IntPtr data)
        {
            OnToggled?.Invoke();
        }

        public event Action OnToggled;
    }
}
