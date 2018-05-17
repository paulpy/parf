using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace PrintAgentRF.Vistas
{
    public partial class Configuracion : Form
    {
        /*Implementacion de log4net en la clase Configuracion Form*/
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        /*Implementacion de un objeto entidad en la clase configuracion form*/
        private Modelos.parestfEntities parestfContext;
        public List<Modelos.configuracion> configList;

        public Configuracion()
        {
            InitializeComponent();
        }

        /*Metodo para cerrar la ventana de configuraciones y cerrar el contexto o coneccion abierto 
         * para el trabajo con datos*/
        private void btnConfCancelar_Click(object sender, EventArgs e)
        {
            logger.Debug("El usuario Acciona para salir a las configuraciones");
            logger.Info("El usuario Acciona para salir a las configuraciones");
            logger.Warn("Un usuario sale de slas configuraciones del Sistema");
            logger.Debug("Cerrando el contexto Configuracion");
            parestfContext.Dispose();
            this.Close();
        }

        /*Metodo _load
         dicho metodo se ejecuta al abrir la ventana de configuraciones
         al cargar la ventana consulta las configuraciones que estan guardadas en la entidad para 
         disponibilizarlas al usuario en la ventana Configuracion*/
        private void Configuracion_Load(object sender, EventArgs e)
        {
            parestfContext = new Modelos.parestfEntities();
            var configuracionQuery = from c in parestfContext.configuracion
                                     orderby c.id
                                     select c;
            try
            {
                foreach (Modelos.configuracion config in configuracionQuery)
                {
                    txbConfNombreAgent.Text = config.nombreagente;
                    txbConfContrasena.Text = config.contrasenarf;
                    txbConfIpAgente.Text = config.ipequipo;
                    txbConfPuerto.Text = Convert.ToString(config.puerto);
                    txbConfHost.Text = config.hostps;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+" No Se encontraron datos");
                logger.Debug("Excepcion en try-catch de configuracion_load "+ ex.Message);
                logger.Error("Excepcion en try-catch de configuracion_load "+ ex.Message);
            }
        }

        /*Metodo de actualizar configuracion_click
         * Pregunta si algunos de los campos estas vacios si es asi avisa que deben llenarse
         * si estan llenos toma los datos y guarda en la base de datos las configuraciones
         * actualmente trabaja con datos cargados ya en la base de datos no con base de datos vacio
        */
        private void btnConfActualizar_Click(object sender, EventArgs e)
        {
            if ((txbConfNombreAgent.Text=="")||(txbConfContrasena.Text== "") 
                || (txbConfIpAgente.Text== "") || (txbConfPuerto.Text== "") || (txbConfHost.Text== ""))
            {
                MessageBox.Show("Existen Campos sin Completar");
            }
            else
            {
                var configUpdate = parestfContext.configuracion.Where(configactual => configactual.id.Equals(1));
                foreach(var newconf in configUpdate)
                {
                    newconf.nombreagente = newconf.nombreagente.Replace(newconf.nombreagente, txbConfNombreAgent.Text);
                    newconf.contrasenarf = newconf.contrasenarf.Replace(newconf.contrasenarf, txbConfContrasena.Text);
                    newconf.hostps = newconf.hostps.Replace(newconf.hostps, txbConfHost.Text);
                    newconf.puerto = Convert.ToInt64(txbConfPuerto.Text);
                    try
                    {
                        parestfContext.SaveChanges();
                        logger.Info("Cambios guardados en configuracion");
                        logger.Debug("Cambios guardados en configuracion");
                        logger.Warn("Cambios Guardados en configuracion por usuario");
                        MessageBox.Show("Cambios Guardados Exitosamente");
                    }
                    catch (Exception ex)
                    {
                        logger.Debug("Excepcion en try-catch de configuracionactualizar_clic " + ex.Message);
                        logger.Error("Excepcion en try-catch de configuracionactualizar_clic " + ex.Message);
                        MessageBox.Show("Cambios no Guardados");
                    }
                }
            }
        }
    }
}
