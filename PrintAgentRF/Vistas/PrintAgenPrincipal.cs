using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using PrintAgentRF.Clases.Controller;

namespace PrintAgentRF
{
    public partial class PrintAgenPrincipal : Form
    {
        //implementacion de logger en la clase
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        /*Implementacion de un objeto entidad en la clase configuracion form*/
        private Modelos.parestfEntities parestfContext;
        /*Implementacion de clase impresora para el uso de metodos*/
        private impresora printMet = new impresora();
        public PrintAgenPrincipal()
        {
            InitializeComponent();
        }

        private void pmiCerrar_Click(object sender, EventArgs e)
        {
            logger.Warn("Intentando Cerrar el Agente de Impresion por usuario");
            if (MessageBox.Show("Seguro que desea Salir", "Salir", MessageBoxButtons.OKCancel) == DialogResult.OK)
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
        /* Metodo _load de Pagina Principal
         * Al arrancar el sistema pregunta al Sistema Operativo la ip actual del equipo 
         * Guarda en la base de datos dicha IP para la configuracion y publicacion del puerto de Web services
         */
        private void PrintAgenPrincipal_Load(object sender, EventArgs e)
        {
            parestfContext = new Modelos.parestfEntities();
            IPHostEntry host;
            string localIP = "";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localIP = ip.ToString();
                }
            }
            var configUp = parestfContext.configuracion.Where(confCurrent => confCurrent.id.Equals(1));
            foreach (var newconf in configUp)
            {
                newconf.ipequipo = newconf.ipequipo.Replace(newconf.ipequipo, localIP);
                try
                {
                    parestfContext.SaveChanges();
                    logger.Info("Cambios guardados en configuracion sobre IP");
                    logger.Debug("Cambios guardados en configuracion sobre IP");
                    logger.Warn("Alerta Cambios Guardados en configuracion por usuario sobre IP");
                }
                catch (Exception ex)
                {
                    logger.Debug("Excepcion en try-catch de PrintAgentPrincipal_load " + ex.Message);
                    logger.Error("Excepcion en try-catch de PrintAgentPrincipal_load " + ex.Message);
                }
            }
        }

        private void verificarImrpesorasInstaladasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logger.Debug("El usuario Acciona para verificar y actualizar las Impresoras");
            logger.Info("El usuario Acciona para verificar y actualizar las Impresoras");
            logger.Warn("Un usuario verificara y actualizar las Impresoras");
            var message = String.Join(Environment.NewLine, printMet.printersAdd(printMet.printerSuffix()));
            if (message != "")
            {
                MessageBox.Show(message);
            }
            else
            {
                MessageBox.Show("No hay nuevas Impresoras");
            }
            
        }

        private void estadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logger.Debug("El usuario Acciona para ir a Estados");
            logger.Info("El usuario Acciona para ir a Estados");
            logger.Warn("Un usuario va a los Estados del Sistema");
            Vistas.Estados stateInBd = new Vistas.Estados();
            stateInBd.Show();
        }
    }
}
