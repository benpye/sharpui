using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SharpUI
{
    public static partial class NativeMethods
    {
        // _UI_EXTERN void uiRadioButtonsAppend(uiRadioButtons *r, const char *text);
        [DllImport(DLLNAME)]
        public static extern void uiRadioButtonsAppend(IntPtr r, IntPtr text);

        // _UI_EXTERN uiRadioButtons *uiNewRadioButtons(void);
        [DllImport(DLLNAME)]
        public static extern IntPtr uiNewRadioButtons();
    }
}
