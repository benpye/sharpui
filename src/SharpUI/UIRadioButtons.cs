using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

using static SharpUI.NativeMethods;

namespace SharpUI
{
    public class UIRadioButtons : UIControl
    {
        public UIRadioButtons()
            : base(CreateRadioButtons(), true)
        { }

        private static IntPtr CreateRadioButtons()
        {
            return uiNewRadioButtons();
        }

        public void Append(string text)
        {
            IntPtr ptr = MarshalHelper.StringToUTF8(text);
            uiRadioButtonsAppend(handle, ptr);
            Marshal.FreeHGlobal(ptr);
        }
    }
}
