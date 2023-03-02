using Ejercicio1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServicioEj1
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }
        Servidor server = new Servidor();



        public void writeEvent(string mensaje)
        {
            string nombre = "Servicio de fecha y hora";
            string logDestino = "Application";
            if (!EventLog.SourceExists(nombre))
            {
                EventLog.CreateEventSource(nombre, logDestino);
            }
            EventLog.WriteEntry(nombre, mensaje);

            
        }


        protected override void OnStart(string[] args)
        {
            try
            {
                Thread thread = new Thread(server.iniciar);
                thread.Start();

            }
            catch (ArgumentNullException)
            {

            }
            catch (ThreadStateException)
            {

            }
            


        }

        protected override void OnStop()
        {
            server.cerrarServidor();
            writeEvent("El servidor se detuvo");
           
            
        }
    }
}
