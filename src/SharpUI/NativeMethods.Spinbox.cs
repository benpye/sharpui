using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SharpUI
{
    public static partial class NativeMethods
    {
        // _UI_EXTERN intmax_t uiSpinboxValue(uiSpinbox *s);
        [DllImport(DLLNAME)]
        public static extern Int64 uiSpinboxValue(IntPtr s);

        // _UI_EXTERN void uiSpinboxSetValue(uiSpinbox *s, intmax_t value);
        [DllImport(DLLNAME)]
        public static extern void uiSpinboxSetValue(IntPtr s, Int64 value);

        public delegate void uiSpinboxOnChangedDelegate(IntPtr s, IntPtr data);

        // _UI_EXTERN void uiSpinboxOnChanged(uiSpinbox *s, void (*f)(uiSpinbox *s, void *data), void *data);
        [DllImport(DLLNAME)]
        public static extern void uiSpinboxOnChanged(IntPtr s, uiSpinboxOnChangedDelegate f, IntPtr data);

        // _UI_EXTERN uiSpinbox *uiNewSpinbox(intmax_t min, intmax_t max);
        [DllImport(DLLNAME)]
        public static extern IntPtr uiNewSpinbox(Int64 min, Int64 max);
    }
}
