using FinancialAssistant.WinFrom.List;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialAssistant.WinFrom
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FM_Login());
            //Application.Run(new Form1());
            //Application.Run(new FM_List());
            Application.Run(new FM_Body());
        }
    }
}
