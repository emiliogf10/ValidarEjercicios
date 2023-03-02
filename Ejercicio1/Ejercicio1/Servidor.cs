using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Servidor
    {
        public int port;
        public bool conexion;
        public void iniciar()
        {
            puerto();
            IPEndPoint ie = new IPEndPoint(IPAddress.Any, port);

            using (Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream,
            ProtocolType.Tcp))
            {
                try
                {
                    s.Bind(ie);
                    conexion = true;
                    s.Listen(10);
                    Console.WriteLine($"Server listening at port:{ie.Port}");
                }
                catch (SocketException e)
                {
                    Console.WriteLine("Error");
                    conexion = false;
                    ie.Port++;
                }


                while (conexion)
                {



                    Socket sClient = s.Accept();
                    IPEndPoint ieClient = (IPEndPoint)sClient.RemoteEndPoint;
                    Console.WriteLine("Client connected:{0} at port {1}", ieClient.Address,
                    ieClient.Port);
                    using (NetworkStream ns = new NetworkStream(sClient))
                    using (StreamReader sr = new StreamReader(ns))
                    using (StreamWriter sw = new StreamWriter(ns))
                    {
                        string welcome = "Bienvenido al servidor de Emilio!";
                        sw.WriteLine(welcome);
                        sw.Flush();
                        string msg = "";
                        string msg2 = "";
                        String line = "";

                        msg = sr.ReadLine();
                        try
                        {
                            

                            switch (msg)
                            {
                                case "time":
                                    DateTime currentTime = DateTime.Now;
                                    msg2 = "La hora actual es: " + currentTime.ToString("HH:mm:ss");
                                    sw.WriteLine(msg2);
                                    sw.Flush();






                                    break;
                                case "date":
                                    string Date = DateTime.Now.ToString("dd-MM-yyyy");
                                    msg2 = "La fecha actual es: " + Date;
                                    sw.WriteLine(msg2);
                                    sw.Flush();




                                    break;
                                case "all":
                                    string dateTime = DateTime.Now.ToString();
                                    msg2 = "La fecha y la hora actuales son: " + dateTime;
                                    sw.WriteLine(msg2);
                                    sw.Flush();



                                    break;
                                case String st when st.StartsWith("close "):

                                    string contraseña = "";

                                    using (StreamReader sre = new StreamReader(Environment.GetEnvironmentVariable("PROGRAMDATA") + "\\password.txt"))
                                    {
                                        try
                                        {
                                            if (msg.Length > 5)
                                            {
                                                contraseña = msg.Substring(5).Trim();
                                            }

                                            string clave = sre.ReadToEnd();
                                            if (clave.Equals(contraseña))
                                            {
                                                conexion = false;
                                                sw.WriteLine("El servidor se ha cerrado correctamente");

                                                sw.Flush();
                                                sClient.Close(); // Este no se abre con using, pues lo devuelve el accept.

                                            }
                                            else
                                            {
                                                sw.WriteLine("Contraseña incorrecta");
                                                sw.Flush();
                                            }
                                        }
                                        catch (IOException)
                                        {
                                            Console.WriteLine("Ha ocurrido un error");
                                        }
                                    }


                                    break;
                                default:
                                    sw.WriteLine("No se reconoce el comando");
                                    sw.Flush();
                                    break;

                            }

                        }
                        catch (IOException e)
                        {
                            msg = null;

                        }

                    }
                    Console.WriteLine("Client disconnected.\nConnection closed");

                    sClient.Close(); // Este no se abre con using, pues lo devuelve el accept.

                }
            }
        }

        public void puerto()
        {
            String path = Environment.GetEnvironmentVariable("PROGRAMDATA") + "puerto.txt";
            FileInfo archivo = new FileInfo(path);

            if (archivo.Exists)
            {
                try
                {
                    using (StreamReader sr = new StreamReader(path))
                    {
                        String puerto = sr.ReadToEnd();
                        if (int.TryParse(puerto, out int puerto2) == true)
                        {
                            if (puerto2 < IPEndPoint.MaxPort)
                            {
                                port = int.Parse(puerto);
                            }
                        }
                            
                    }
                }
                catch (IOException error)
                {
                    Console.WriteLine($"Error {error.Message}");
                }

            }
            else
            {
                port = 44000;
            }
        }
    }
}
