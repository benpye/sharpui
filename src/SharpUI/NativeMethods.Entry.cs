using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SharpUI
{
    public static partial class NativeMethods
    {
        // _UI_EXTERN char *uiEntryText(uiEntry *e);
        [DllImport(DLLNAME)]
        public static extern IntPtr uiEntryText(IntPtr e);

        // _UI_EXTERN void uiEntrySetText(uiEntry *e, const char *text);
        [DllImport(DLLNAME)]
        public static extern void uiEntrySetText(IntPtr e, IntPtr text);

        public delegate void uiEntryOnChangedDelegate(IntPtr e, IntPtr data);

        // _UI_EXTERN void uiEntryOnChanged(uiEntry *e, void (*f)(uiEntry *e, void *data), void *data);
        [DllImport(DLLNAME)]
        public static extern void uiEntryOnChanged(IntPtr e, uiEntryOnChangedDelegate f, IntPtr data);

        // _UI_EXTERN int uiEntryReadOnly(uiEntry *e);
        [DllImport(DLLNAME)]
        public static extern int uiEntryReadOnly(IntPtr e);

        // _UI_EXTERN void uiEntrySetReadOnly(uiEntry *e, int readonly);
        [DllImport(DLLNAME)]
        public static extern void uiEntrySetReadOnly(IntPtr e, int @readonly);

        // _UI_EXTERN uiEntry *uiNewEntry(void);
        [DllImport(DLLNAME)]
        public static extern IntPtr uiNewEntry();
    }
}
