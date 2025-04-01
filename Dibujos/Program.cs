using System;
using System.Windows.Forms;

namespace RectanglesFactoryApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
   
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);


            Application.Run(new Form1());
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            MessageBox.Show("Ocurrió un error: " + e.Exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = (Exception)e.ExceptionObject;
            MessageBox.Show("Ocurrió un error crítico: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
