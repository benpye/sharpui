using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

using static SharpUI.NativeMethods;

namespace SharpUI
{
    public class UIProgressBar : UIControl
    {
        public UIProgressBar()
            : base(CreateProgressBar(), true)
        { }

        private static IntPtr CreateProgressBar()
        {
            return uiNewProgressBar();
        }

        public int Value
        {
            get { throw new NotImplementedException("libui lacks implementation for uiProgressBarValue"); }
            set { uiProgressBarSetValue(handle, value); }
        }
    }
}
