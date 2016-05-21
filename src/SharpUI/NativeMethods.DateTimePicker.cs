using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SharpUI
{
    public static partial class NativeMethods
    {
        // _UI_EXTERN uiDateTimePicker *uiNewDateTimePicker(void);
        [DllImport(DLLNAME)]
        public static extern IntPtr uiNewDateTimePicker();

        // _UI_EXTERN uiDateTimePicker *uiNewDatePicker(void);
        [DllImport(DLLNAME)]
        public static extern IntPtr uiNewDatePicker();

        // _UI_EXTERN uiDateTimePicker *uiNewTimePicker(void);
        [DllImport(DLLNAME)]
        public static extern IntPtr uiNewTimePicker();
    }
}
