using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SharpUI
{
    public static partial class NativeMethods
    {
        // _UI_EXTERN char *uiWindowTitle(uiWindow *w);
        [DllImport(DLLNAME)]
        public static extern IntPtr uiWindowTitle(IntPtr w);

        // _UI_EXTERN void uiWindowSetTitle(uiWindow *w, const char *title);
        [DllImport(DLLNAME)]
        public static extern void uiWindowSetTitle(IntPtr w, IntPtr title);

        public delegate int uiWindowOnClosingDelegate(IntPtr w, IntPtr data);

        // _UI_EXTERN void uiWindowOnClosing(uiWindow *w, int (*f)(uiWindow *w, void *data), void *data);
        [DllImport(DLLNAME)]
        public static extern void uiWindowOnClosing(IntPtr w, uiWindowOnClosingDelegate f, IntPtr data);

        // _UI_EXTERN void uiWindowSetChild(uiWindow *w, uiControl *child);
        [DllImport(DLLNAME)]
        public static extern void uiWindowSetChild(IntPtr w, IntPtr child);

        // _UI_EXTERN int uiWindowMargined(uiWindow *w);
        [DllImport(DLLNAME)]
        public static extern int uiWindowMargined(IntPtr w);

        // _UI_EXTERN void uiWindowSetMargined(uiWindow *w, int margined);
        [DllImport(DLLNAME)]
        public static extern void uiWindowSetMargined(IntPtr w, int margined);

        // _UI_EXTERN uiWindow *uiNewWindow(const char *title, int width, int height, int hasMenubar);
        [DllImport(DLLNAME)]
        public static extern IntPtr uiNewWindow(IntPtr title, int width, int height, int hasMenuBar);

        // _UI_EXTERN char *uiOpenFile(uiWindow *parent);
        [DllImport(DLLNAME)]
        public static extern IntPtr uiOpenFile(IntPtr parent);

        // _UI_EXTERN char *uiSaveFile(uiWindow *parent);
        [DllImport(DLLNAME)]
        public static extern IntPtr uiSaveFile(IntPtr parent);

        // _UI_EXTERN void uiMsgBox(uiWindow *parent, const char *title, const char *description);
        [DllImport(DLLNAME)]
        public static extern void uiMsgBox(IntPtr parent, IntPtr title, IntPtr description);

        // _UI_EXTERN void uiMsgBoxError(uiWindow *parent, const char *title, const char *description);
        [DllImport(DLLNAME)]
        public static extern void uiMsgBoxError(IntPtr parent, IntPtr title, IntPtr description);
    }
}
