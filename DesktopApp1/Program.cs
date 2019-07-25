using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace DesktopApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static ManualResetEvent _event = new ManualResetEvent(true);
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var DAthread = new Thread(ThreadStart);
            // allow UI with ApartmentState.STA though [STAThread] above should give that to you
            DAthread.TrySetApartmentState(ApartmentState.STA);
            Application.Run(new Form2( ref DAthread,ref _event));
            DAthread.Abort();
        }
        private static void ThreadStart()
        {
            _event.WaitOne();
            Application.Run(new Form1()); // <-- other form started on its own UI thread
        }
    }
}
