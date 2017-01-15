using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadLab3
{
    public static class ControlExtension
    {
        /// <summary>
        /// A method used by threads to update the UI
        /// </summary>
        /// <param name="control"></param>
        /// <param name="action"></param>
        public static void InvokeUI(this Control control, Action action)
        {
            control.BeginInvoke(new MethodInvoker(action), null);
        }
    }
}
