using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

using static SharpUI.NativeMethods;

namespace SharpUI
{
    public class UIEntry : UIControl
    {
        public UIEntry()
            : base(CreateEntry(), true)
        {
            onChangedDelegate = InternalOnChanged;
            uiEntryOnChanged(handle, onChangedDelegate, IntPtr.Zero);
        }

        private static IntPtr CreateEntry()
        {
            return uiNewEntry();
        }

        public string Text
        {
            get
            {
                IntPtr ptr = uiEntryText(handle);
                string str = MarshalHelper.StringFromUTF8(ptr);
                uiFreeText(ptr);
                return str;
            }

            set
            {
                IntPtr ptr = MarshalHelper.StringToUTF8(value);
                uiEntrySetText(handle, ptr);
                Marshal.FreeHGlobal(ptr);
            }
        }

        public bool ReadOnly
        {
            get { return uiEntryReadOnly(handle) == 0 ? false : true; }
            set { uiEntrySetReadOnly(handle, value ? 1 : 0); }
        }

        private uiEntryOnChangedDelegate onChangedDelegate;

        private void InternalOnChanged(IntPtr b, IntPtr data)
        {
            OnChanged?.Invoke();
        }

        public event Action OnChanged;
    }
}
