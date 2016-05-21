using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

using static SharpUI.NativeMethods;

namespace SharpUI
{
    public class UISpinbox : UIControl
    {
        public UISpinbox(Int64 min, Int64 max)
            : base(CreateSpinbox(min, max), true)
        {
            onChangedDelegate = InternalOnChanged;
            uiSpinboxOnChanged(handle, onChangedDelegate, IntPtr.Zero);
        }

        private static IntPtr CreateSpinbox(Int64 min, Int64 max)
        {
            return uiNewSpinbox(min, max);
        }

        public Int64 Value
        {
            get { return uiSpinboxValue(handle); }
            set { uiSpinboxSetValue(handle, value); }
        }

        private uiSpinboxOnChangedDelegate onChangedDelegate;

        private void InternalOnChanged(IntPtr b, IntPtr data)
        {
            OnChanged?.Invoke();
        }

        public event Action OnChanged;
    }
}
