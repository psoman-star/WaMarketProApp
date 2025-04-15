using Krypton.Toolkit;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WaMarketProApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {

    
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


             Application.Run(new FrmMain());
 
        }

         

        
    }
}
