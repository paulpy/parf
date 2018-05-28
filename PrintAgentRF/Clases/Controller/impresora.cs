using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using Fargo.PrinterSDK;

namespace PrintAgentRF.Clases.Controller
{
    public class impresora
    {
        /*Implementacion de log4net en la clase Configuracion Form*/
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        /*Implementacion de un objeto entidad en la clase configuracion form*/
        private Modelos.parestfEntities parestfContext;
        

        public impresora()
        {

        }
        /*
         * Metodo que retorna una lista de Impresoras agregadas a la Base de datos
         * Method that returns a List of printers adhered to the database
         */
        public List<String> printersAdd(String printerSuffix)
        {
            List<String> adheredPrintes = new List<String>();
            Modelos.impresoras printerNewData = new Modelos.impresoras();
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                if (printer.Contains(printerSuffix))
                {
                    if (!existPrintName(printer))
                    {
                        try
                        {
                            parestfContext = new Modelos.parestfEntities();
                            printerNewData.nombreenequipo = printer.ToString();
                            printerNewData.estado = 2;
                            parestfContext.impresoras.Add(printerNewData);
                            parestfContext.SaveChanges();
                            parestfContext.Dispose();
                            adheredPrintes.Add(printer);
                            logger.Info("Agregando Impresora");
                            logger.Debug("Agregando Impresora");
                            logger.Warn("Agregando Impresora a la BD mediante el Sistema");
                        }
                        catch (Exception ex)
                        {
                            logger.Debug("Excepcion en try-catch de metodo printersAdd " + ex.Message);
                            logger.Error("Excepcion en try-catch de metodo printersAdd " + ex.Message);
                        }
                    }
                    else
                    {
                        Console.WriteLine(printer+" Existe ya en BD");
                        logger.Info("Impresora Existente");
                        logger.Debug("Impresora Existente");
                        logger.Warn("Impresora Existente buscando mediante sistema");
                    }
                }
            }
            return adheredPrintes;
        }
        /*
         * Metodo que devuelve el subfijo o clave para identifcar una impresora para el sistema
         * Method that returns the suffix or key to identify a printer for the system
         */
        public String printerSuffix()
        {
            parestfContext = new Modelos.parestfEntities();
            String printerNameDB = null;
            var configuracionQuery = from c in parestfContext.configuracion
                                     orderby c.id
                                     select c;
            foreach(Modelos.configuracion config in configuracionQuery)
            {
                printerNameDB = config.ref_print;
            }
            parestfContext.Dispose();
            return printerNameDB;
        }
        /*
         * Metodo que devuelve verdadero su existe el nombre de la impresora o falso si no existe en la base de datos
         * Method that return true of the name of the printer exists or false if is does not exist in the Database
         */
        public bool existPrintName(String printNameInPC)
        {
            parestfContext = new Modelos.parestfEntities();
            if (parestfContext.impresoras.Any(i => i.nombreenequipo == printNameInPC))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /*
         * Metodo que retorna el estado actual de las impresoras intaladas segun el subfijo HDP
         * Method that returns the current state of printers installed according to the subfix HDP
         */
        public String statePrinterHDP(String printerName)
        {
            String currentStatePrinter = "";
            string query = string.Format("SELECT * from Win32_Printer WHERE Name LIKE '%{0}'", printerName);
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            searcher.Options.ReturnImmediately = true;
            ManagementObjectCollection coll = searcher.Get();
            foreach (ManagementObject printer in coll)
            {
                foreach (PropertyData property in printer.Properties)
                {
                    PrinterInfo printerFargo = new PrinterInfo(printerName);
                    if (printerFargo.CurrentActivity().ToString().Equals("CurrentActivityReady"))
                    {
                        currentStatePrinter = "Ready";
                    }
                    else if (printerFargo.CurrentActivity().ToString().Equals("CurrentActivityUnknown"))
                    {
                        currentStatePrinter = "Offline";
                    }
                }
            }
            return currentStatePrinter;
        }
        /*
         * Metodo que retorna el estado actual de las impresoras intaladas segun el subfijo 
         * Method that returns the current state of printers installed according to the 
         */
        public String statePrinter(String printerName)
        {
            String currentStatePrinter = "";
            string query = string.Format("SELECT * from Win32_Printer WHERE Name LIKE '%{0}'", printerName);
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            searcher.Options.ReturnImmediately = true;
            ManagementObjectCollection coll = searcher.Get();
            foreach (ManagementObject printer in coll)
            {
                foreach (PropertyData property in printer.Properties)
                {
                    if (property.Name.Equals("PrinterStatus"))
                    {
                        // TO DO: PROBAR CON IMPRESORA LASER ESTADOS 7 (POWER OFF) Y 8 (OFFLINE)
                        switch (Convert.ToInt32(property.Value))
                        {
                            case 2:
                                logger.Info("[Mensajero (checkPrinterStatus)] Estado de la impresora UNKNOWN");
                                currentStatePrinter = "Unknown";
                                break;
                            case 3:
                                logger.Info("[Mensajero (checkPrinterStatus)] Estado de la impresora LISTA");
                                currentStatePrinter = "lista";
                                break;
                            case 4:
                                logger.Info("[Mensajero (checkPrinterStatus)] Estado de la impresora PRINTING");
                                currentStatePrinter = "Printing";
                                break;
                            case 5:
                                logger.Info("[Mensajero (checkPrinterStatus)] Estado de la impresora WARMING UP");
                                currentStatePrinter = "Warming up";
                                break;
                            case 6:
                                logger.Info("[Mensajero (checkPrinterStatus)] Estado de la impresora STOPPED PRINTING");
                                currentStatePrinter = "Stopped printing";
                                break;
                            case 7:
                                logger.Info("[Mensajero (checkPrinterStatus)] Estado de la impresora DESHABILITADO");
                                currentStatePrinter = "deshabilitado";
                                break;
                        }
                    }
                }
            }
            return currentStatePrinter;
        }
    }
    public class state
    {
        /*Implementacion de log4net en la clase Configuracion Form*/
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        /*Implementacion de un objeto entidad en la clase configuracion form*/
        private Modelos.parestfEntities parestfContext;
        public state()
        {

        }
        /*
         * Metodo que devuelve verdadero su guardo un estado o falso si no guardo y ocurrio algun error
         * Method that returns true your state or false if I do not save and some error occurred
         */
        public bool addstate(String state)
        {
            parestfContext = new Modelos.parestfEntities();
            Modelos.estados stateNew = new Modelos.estados();
            try
            {
                stateNew.estado = state;
                parestfContext.estados.Add(stateNew);
                parestfContext.SaveChanges();
                logger.Info("Agregando Estado");
                logger.Debug("Agregando Estado");
                logger.Warn("Agregando Estado la BD mediante Usuario");
                parestfContext.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                logger.Debug("Excepcion en try-catch de metodo addstate " + ex.Message);
                logger.Error("Excepcion en try-catch de metodo addstate " + ex.Message);
                parestfContext.Dispose();
                return false;
            }
        }
        /*
         * Metodo que devuelve verdadero su existe el estado o falso si no existe en la base de datos
         * Method that return true of the name of the state exists or false if is does not exist in the Database
         */
        public bool existStateName(String state)
        {
            parestfContext = new Modelos.parestfEntities();
            if (parestfContext.estados.Any(s => s.estado == state))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
