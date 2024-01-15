using CSharp_AzureDevopsNotifier.Forms;
using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace CSharp_AzureDevopsNotifier
{
    internal static class Program
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0063:Utiliser une instruction 'using' simple", Justification = "<En attente>")]
        private static void CatchException
            (object sender, ThreadExceptionEventArgs e)
        {
            try
            {
                using (StreamWriter sw = new("crash-" + DateTime.UtcNow.ToString("yyyy-MM-ddTHH-mm-ss") + ".txt"))
                {
                    Exception ex = e.Exception;
                    sw.WriteLine(ex.Message + ex.StackTrace);
                }
            }
            finally
            {
                Environment.Exit(0);
            }
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += CatchException;
            Application.Run(new TrayApplicationContext());
        }
    }
}
