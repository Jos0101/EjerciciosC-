using System;
using System.Windows.Forms;

namespace ValidacionFormularioC_
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Inicializa la configuración del entorno gráfico
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Inicia el formulario principal
            Application.Run(new Form1());
        }
    }
}
