using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SharpUI
{
    public static partial class NativeMethods
    {
        // _UI_EXTERN char *uiCheckboxText(uiCheckbox *c);
        [DllImport(DLLNAME)]
        public static extern IntPtr uiCheckboxText(IntPtr c);

        // _UI_EXTERN void uiCheckboxSetText(uiCheckbox *c, const char *text);
        [DllImport(DLLNAME)]
        public static extern void uiCheckboxSetText(IntPtr c, IntPtr text);

        public delegate void uiCheckboxOnToggledDelegate(IntPtr c, IntPtr data);

        // _UI_EXTERN void uiCheckboxOnToggled(uiCheckbox *c, void (*f)(uiCheckbox *c, void *data), void *data);
        [DllImport(DLLNAME)]
        public static extern void uiCheckboxOnToggled(IntPtr c, uiCheckboxOnToggledDelegate f, IntPtr data);

        // _UI_EXTERN int uiCheckboxChecked(uiCheckbox *c);
        [DllImport(DLLNAME)]
        public static extern int uiCheckboxChecked(IntPtr c);

        // _UI_EXTERN void uiCheckboxSetChecked(uiCheckbox *c, int checked);
        [DllImport(DLLNAME)]
        public static extern void uiCheckboxSetChecked(IntPtr c, int @checked);

        // _UI_EXTERN uiCheckbox *uiNewCheckbox(const char *text);
        [DllImport(DLLNAME)]
        public static extern IntPtr uiNewCheckbox(IntPtr text);
    }
}
