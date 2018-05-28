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
    public partial class Estados : Form
    {
        public Estados()
        {
            InitializeComponent();
        }
        /*Implementacion de log4net en la clase Configuracion Form*/
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        /*Implementacion de un objeto entidad en la clase configuracion form*/
        private Modelos.parestfEntities parestfContext;
        /*Importacion de metodos de clase impresora*/
        private Clases.Controller.state stateMet = new Clases.Controller.state();

        private void Estados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'parestfDataSet.estados' Puede moverla o quitarla según sea necesario.
            this.estadosTableAdapter.Fill(this.parestfDataSet.estados);
        }

        private void btnAddState_Click(object sender, EventArgs e)
        {
            if (txbState.Text=="")
            {
                MessageBox.Show("El campo esta vacio");
            }
            else
            {
                parestfContext = new Modelos.parestfEntities();
                bool isexists = stateMet.existStateName(txbState.Text);
                if (isexists)
                {
                    MessageBox.Show("El Estado " + txbState.Text+" ya existe");
                }
                else
                {
                    if (stateMet.addstate(txbState.Text))
                    {
                        MessageBox.Show("El Estado " + txbState.Text + " fue agregado Correctamente");
                        dgvStates.Update();
                        txbState.Clear();
                        txbState.Focus();
                    }
                    else
                    {
                        MessageBox.Show("El Estado " + txbState.Text + " no fue agregado");
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            logger.Debug("El usuario Acciona para salir de Estados");
            logger.Info("El usuario Acciona para salir de Estados");
            logger.Warn("Un usuario sale de agregar Estados al Sistema");
            this.Close();
        }
    }
}
