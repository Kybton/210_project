using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using _210_project.Properties;

namespace _210_project
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (Settings.Default.username != string.Empty)
            {
                if (Settings.Default.role.Equals("admin")) Application.Run(new formAdminMainMenu());
                if (Settings.Default.role.Equals("member")) Application.Run(new memberMainMenu());
            }

            Application.Run(new loginForm());
        }
    }
}
