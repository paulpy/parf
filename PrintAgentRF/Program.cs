using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintAgentRF
{
    static class Program
    {
        /*
        Utilizacion del log4net en el sistema
        */
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            logger.Debug("Iniciando Sistema PARestFul");
            logger.Info("Iniciando Sistema PARestFul");
            logger.Warn("Alerta de inicio de sistema");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PrintAgenPrincipal());
        }
    }
}
