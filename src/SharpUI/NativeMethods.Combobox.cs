using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SharpUI
{
    public static partial class NativeMethods
    {
        // _UI_EXTERN void uiComboboxAppend(uiCombobox *c, const char *text);
        [DllImport(DLLNAME)]
        public static extern void uiComboboxAppend(IntPtr c, IntPtr text);

        // _UI_EXTERN intmax_t uiComboboxSelected(uiCombobox *c);
        [DllImport(DLLNAME)]
        public static extern Int64 uiComboboxSelected(IntPtr c);

        // _UI_EXTERN void uiComboboxSetSelected(uiCombobox *c, intmax_t n);
        [DllImport(DLLNAME)]
        public static extern void uiComboboxSetSelected(IntPtr c, Int64 n);

        public delegate void uiComboboxOnSelectedDelegate(IntPtr c, IntPtr data);

        // _UI_EXTERN void uiComboboxOnSelected(uiCombobox *c, void (*f)(uiCombobox *c, void *data), void *data);
        [DllImport(DLLNAME)]
        public static extern void uiComboboxOnSelected(IntPtr c, uiComboboxOnSelectedDelegate f, IntPtr data);

        // _UI_EXTERN uiCombobox *uiNewCombobox(void);
        [DllImport(DLLNAME)]
        public static extern IntPtr uiNewCombobox();

        // _UI_EXTERN uiCombobox *uiNewEditableCombobox(void);
        [DllImport(DLLNAME)]
        public static extern IntPtr uiNewEditableCombobox();
    }
}
