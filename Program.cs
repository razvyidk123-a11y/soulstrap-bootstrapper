using System;
using System.Windows.Forms;

namespace SoulStrap
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            ThemeManager.LoadTheme();
            Application.Run(new Forms.MainForm());
        }
    }
}
