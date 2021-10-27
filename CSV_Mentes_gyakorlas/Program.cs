using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSV_Mentes_gyakorlas
{
    static class Program
    {
        public static Form foablak = null;
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            foablak = new Form1();
            Application.Run(foablak);
        }
    }
}
