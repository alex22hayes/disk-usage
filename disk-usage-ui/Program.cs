﻿using disk_usage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace disk_usage_ui
{
    static class Program
    {
        public static Theme Theme;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            
            Theme = Theming.ForVersion(Windows.Version()); //determine theme

#if THEME
            // OVERRIDE
            Theme = Theming.ForVersion(OSVersion.Windows7);
#endif

            Application.Run(new NotificationAreaForm());
        }
    }
}
