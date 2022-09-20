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
            
            var frmIniciarSesion = new FrmInicioSesion();

            Application.Run(frmIniciarSesion);

            if (frmIniciarSesion.DialogResult == DialogResult.OK)
            {
                Application.Exit();

                var frmPrincipal = new FrmPrincipal(frmIniciarSesion.ObtenerUsuarioLogeado());

                Application.Run(frmPrincipal);

                if (frmPrincipal.DialogResult == DialogResult.Retry)
                {
                    Application.Restart();
                }
            }
            else
            {
                Application.Exit();
            }            
        }
    }
}
