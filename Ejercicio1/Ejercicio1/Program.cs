using System.Net;
using System.Net.Sockets;

namespace Ejercicio1
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Servidor server = new Servidor();
            
            server.iniciar();
        }
    }
}