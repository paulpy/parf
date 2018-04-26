using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintAgentRF
{
    public partial class PrintAgenPrincipal : Form
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public PrintAgenPrincipal()
        {
            InitializeComponent();
        }

        private void pmiCerrar_Click(object sender, EventArgs e)
        {
            logger.Warn("Intentando Cerrar el Agente de Impresion por usuario");
            if (MessageBox.Show("Seguro que desea Salir","Salir",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                logger.Info("Cerrando Sistema");
                logger.Debug("Cerrando Sistema");
                logger.Warn("Cerrando el sistema por Accion del usuario");
                Application.Exit();
            }
        }

        private void pmiConfiguracion_Click(object sender, EventArgs e)
        {
            logger.Debug("El usuario Acciona para ir a las configuraciones");
            logger.Info("El usuario Acciona para ir a las configuraciones");
            logger.Warn("Un usuario va a las configuraciones del Sistema");
            Vistas.Configuracion formConfig = new Vistas.Configuracion();
            formConfig.Show();
        }
    }
}
