using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

using static SharpUI.NativeMethods;

namespace SharpUI
{
    public enum UIDateTimePickerType
    {
        Date,
        Time,
        DateTime
    }

    public class UIDateTimePicker : UIControl
    {
        public UIDateTimePicker(UIDateTimePickerType type)
            : base(CreateDateTimePicker(type), true)
        { }

        private static IntPtr CreateDateTimePicker(UIDateTimePickerType type)
        {
            switch(type)
            {
                case UIDateTimePickerType.DateTime:
                    return uiNewDateTimePicker();
                case UIDateTimePickerType.Date:
                    return uiNewDatePicker();
                case UIDateTimePickerType.Time:
                    return uiNewTimePicker();
                default:
                    throw new ArgumentException($"{nameof(type)} is an invalid value");
            }
        }
    }
}
