using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

using static SharpUI.NativeMethods;

namespace SharpUI
{
    public class UISeparator : UIControl
    {
        public UISeparator(bool vertical = false)
            : base(CreateSeparator(vertical), true)
        { }

        private static IntPtr CreateSeparator(bool vertical)
        {
            if (vertical)
                throw new NotImplementedException("libui lacks implementation for uiNewVerticalSeparator");
            else
                return uiNewHorizontalSeparator();
        }
    }
}
