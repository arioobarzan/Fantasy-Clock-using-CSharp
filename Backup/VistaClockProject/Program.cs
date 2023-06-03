//##########################################################################
//★★★★★★★           http://www.cnpopsoft.com           ★★★★★★★
//★★          VB & C# source code and articles for free !!!           ★★
//★★★★★★★                Davidwu                       ★★★★★★★
//##########################################################################

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CNPOPSOFT.Controls
{
    static class Program
    {
        /// <summary>
        /// AppEntrance
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmDemo());
        }
    }
}