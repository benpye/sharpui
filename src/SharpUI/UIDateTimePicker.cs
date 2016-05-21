using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

using static SharpUI.NativeMethods;

namespace SharpUI
{
    public class UIDateTimePicker : UIControl
    {
        public UIDateTimePicker(bool date, bool time)
            : base(CreateDateTimePicker(date, time), true)
        { }

        private static IntPtr CreateDateTimePicker(bool date, bool time)
        {
            if (date && time)
                return uiNewDateTimePicker();
            else if (date)
                return uiNewDatePicker();
            else if (time)
                return uiNewTimePicker();
            else
                throw new ArgumentException($"Either {nameof(date)} or {nameof(time)} or both must be true");
        }
    }
}
