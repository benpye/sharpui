using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

using static SharpUI.NativeMethods;

namespace SharpUI
{
    public class UIButton : UIControl
    {
        public UIButton(string text)
            : base(CreateButton(text), true)
        {
            onClickedDelegate = InternalOnClicked;
            uiButtonOnClicked(handle, onClickedDelegate, IntPtr.Zero);
        }

        private static IntPtr CreateButton(string text)
        {
            IntPtr ptr = MarshalHelper.StringToUTF8(text);
            IntPtr handle = uiNewButton(ptr);
            Marshal.FreeHGlobal(ptr);
            return handle;
        }

        public string Text
        {
            get
            {
                IntPtr ptr = uiButtonText(handle);
                string str = MarshalHelper.StringFromUTF8(ptr);
                uiFreeText(ptr);
                return str;
            }

            set
            {
                IntPtr ptr = MarshalHelper.StringToUTF8(value);
                uiButtonSetText(handle, ptr);
                Marshal.FreeHGlobal(ptr);
            }
        }

        private uiButtonOnClickedDelegate onClickedDelegate;

        private void InternalOnClicked(IntPtr b, IntPtr data)
        {
            OnClicked?.Invoke(this);
        }

        public event Action<UIButton> OnClicked;
    }
}
