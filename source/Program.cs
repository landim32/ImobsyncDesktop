using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace ImobsyncDesktop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            /*
            String xulrunnerPath = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), @"xulrunner");
            string profilePath = Path.Combine(xulrunnerPath, "GeckoFX");
            if (!Directory.Exists(profilePath))
                Directory.CreateDirectory(profilePath);
            Xpcom.ProfileDirectory = profilePath;
            Xpcom.Initialize(xulrunnerPath);
             */

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new formNavegador());
        }
    }
}
