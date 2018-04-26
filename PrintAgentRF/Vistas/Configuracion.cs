using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintAgentRF.Vistas
{
    public partial class Configuracion : Form
    {
        /*Implementacion de log4net en la clase Configuracion Form*/
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Configuracion()
        {
            InitializeComponent();
        }

        private void btnConfCancelar_Click(object sender, EventArgs e)
        {
            logger.Debug("El usuario Acciona para salir a las configuraciones");
            logger.Info("El usuario Acciona para salir a las configuraciones");
            logger.Warn("Un usuario sale de slas configuraciones del Sistema");
            this.Close();
        }
    }
}
