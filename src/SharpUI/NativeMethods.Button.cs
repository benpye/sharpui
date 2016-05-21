using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SharpUI
{
    public static partial class NativeMethods
    {
        // _UI_EXTERN char *uiButtonText(uiButton *b);
        [DllImport(DLLNAME)]
        public static extern IntPtr uiButtonText(IntPtr b);

        // _UI_EXTERN void uiButtonSetText(uiButton *b, const char *text);
        [DllImport(DLLNAME)]
        public static extern void uiButtonSetText(IntPtr b, IntPtr text);

        public delegate void uiButtonOnClickedDelegate(IntPtr b, IntPtr data);

        // _UI_EXTERN void uiButtonOnClicked(uiButton *b, void (*f)(uiButton *b, void *data), void *data);
        [DllImport(DLLNAME)]
        public static extern void uiButtonOnClicked(IntPtr b, uiButtonOnClickedDelegate f, IntPtr data);

        // _UI_EXTERN uiButton *uiNewButton(const char *text);
        [DllImport(DLLNAME)]
        public static extern IntPtr uiNewButton(IntPtr text);
    }
}
