using CSharp_AzureDevopsNotifier.Forms;

namespace CSharp_AzureDevopsNotifier
{
    internal static class Program
    {
        private static void CatchException
            (object sender, ThreadExceptionEventArgs e)
        {
            try
            {
                StreamWriter sw = new("crash-" + DateTime.Now.ToString().Replace("/", "-").Replace(":", "-") + ".txt");
                Exception ex = e.Exception;
                sw.WriteLine(ex.Message + ex.StackTrace);
                sw.Close();
            }
            finally
            {
                Application.Exit();
            }
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new TrayApplicationContext());
            Application.ThreadException += new ThreadExceptionEventHandler(CatchException);
        }
    }
}
