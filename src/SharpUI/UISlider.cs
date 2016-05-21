using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

using static SharpUI.NativeMethods;

namespace SharpUI
{
    public class UISlider : UIControl
    {
        public UISlider(Int64 min, Int64 max)
            : base(CreateSlider(min, max), true)
        {
            onChangedDelegate = InternalOnChanged;
            uiSliderOnChanged(handle, onChangedDelegate, IntPtr.Zero);
        }

        private static IntPtr CreateSlider(Int64 min, Int64 max)
        {
            return uiNewSlider(min, max);
        }

        public Int64 Value
        {
            get { return uiSliderValue(handle); }
            set { uiSliderSetValue(handle, value); }
        }

        private uiSliderOnChangedDelegate onChangedDelegate;

        private void InternalOnChanged(IntPtr b, IntPtr data)
        {
            OnChanged?.Invoke();
        }

        public event Action OnChanged;
    }
}
