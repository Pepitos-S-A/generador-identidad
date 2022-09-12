using System;
using System.Windows.Forms;
using Duisv.Formularios;

namespace Duisv
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var frmInicioSesion = new FrmInicioSesion();

            if (frmInicioSesion.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FrmPrincipal());
            }            
        }
    }
}
