using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

using static SharpUI.NativeMethods;

namespace SharpUI
{
    public class UILabel : UIControl
    {
        public UILabel(string text)
            : base(CreateLabel(text), true)
        { }

        private static IntPtr CreateLabel(string text)
        {
            IntPtr ptr = MarshalHelper.StringToUTF8(text);
            IntPtr handle = uiNewLabel(ptr);
            Marshal.FreeHGlobal(ptr);
            return handle;
        }

        public string Text
        {
            get
            {
                IntPtr ptr = uiLabelText(handle);
                string str = MarshalHelper.StringFromUTF8(ptr);
                uiFreeText(ptr);
                return str;
            }

            set
            {
                IntPtr ptr = MarshalHelper.StringToUTF8(value);
                uiLabelSetText(handle, ptr);
                Marshal.FreeHGlobal(ptr);
            }
        }
    }
}
