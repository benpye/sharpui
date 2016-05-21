using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SharpUI
{
    public static partial class NativeMethods
    {
        // _UI_EXTERN intmax_t uiSliderValue(uiSlider *s);
        [DllImport(DLLNAME)]
        public static extern Int64 uiSliderValue(IntPtr s);

        // _UI_EXTERN void uiSliderSetValue(uiSlider *s, intmax_t value);
        [DllImport(DLLNAME)]
        public static extern void uiSliderSetValue(IntPtr s, Int64 value);

        public delegate void uiSliderOnChangedDelegate(IntPtr s, IntPtr data);

        // _UI_EXTERN void uiSliderOnChanged(uiSlider *s, void (*f)(uiSlider *s, void *data), void *data);
        [DllImport(DLLNAME)]
        public static extern void uiSliderOnChanged(IntPtr s, uiSliderOnChangedDelegate f, IntPtr data);

        // _UI_EXTERN uiSlider *uiNewSlider(intmax_t min, intmax_t max);
        [DllImport(DLLNAME)]
        public static extern IntPtr uiNewSlider(Int64 min, Int64 max);
    }
}
