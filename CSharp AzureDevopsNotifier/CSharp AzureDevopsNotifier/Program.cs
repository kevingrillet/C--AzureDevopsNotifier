using CSharp_AzureDevopsNotifier.Forms;
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace CSharp_AzureDevopsNotifier
{
    [ExcludeFromCodeCoverage]
    internal static class Program
    {
        private static void CatchException(object sender, ThreadExceptionEventArgs e)
        {
            try
            {
                string crashLogFileName = $"crash-{DateTime.UtcNow:yyyy-MM-ddTHH-mm-ss}.txt";
                using StreamWriter sw = new(crashLogFileName);
                Exception ex = e.Exception;
                sw.WriteLine($"{ex.Message}{ex.StackTrace}");
                if (ex.InnerException != null)
                {
                    sw.WriteLine($"Inner Exception: {ex.InnerException.Message}{ex.InnerException.StackTrace}");
                }
                if (ex.Data.Count > 0)
                {
                    sw.WriteLine("Additional Data:");
                    foreach (var key in ex.Data.Keys)
                    {
                        sw.WriteLine($"{key}: {ex.Data[key]}");
                    }
                }
            }
            finally
            {
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// The main entry point for the application.
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
