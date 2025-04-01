using System;
using System.Windows.Forms;

namespace RectanglesFactoryApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // Habilitar estilos visuales para la aplicación
            Application.EnableVisualStyles();
            // Establecer la compatibilidad de renderizado de texto
            Application.SetCompatibleTextRenderingDefault(false);

            // Manejo global de excepciones no controladas
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            // Ejecutar el formulario principal de la aplicación
            Application.Run(new Form1());
        }

        // Método para manejar excepciones no controladas en el hilo de la aplicación
        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            MessageBox.Show("Ocurrió un error: " + e.Exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Método para manejar excepciones no controladas en el dominio de la aplicación
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = (Exception)e.ExceptionObject;
            MessageBox.Show("Ocurrió un error crítico: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
