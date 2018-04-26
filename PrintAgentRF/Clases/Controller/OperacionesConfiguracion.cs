using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintAgentRF.Clases
{
    class OperacionesConfiguracion
    {
        /*Implementacion de log4net en Operaciones de las configuraciones*/

        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private Modelos.configuracion configuraciones = new Modelos.configuracion();

        
    }
}
