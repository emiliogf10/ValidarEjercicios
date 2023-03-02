using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        static string IP_SERVER = "192.168.20.100";
        static int PORT = 5001;
        string msg;
        string userMsg;
        IPAddress ipConv;
        int puertoN;
        bool todoOk = false;




        private void cambiarConexion_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(IP_SERVER, PORT);
            if (form.ShowDialog() == DialogResult.OK)
            {
                bool ip = IPAddress.TryParse(form.ip.ToString(),out ipConv);
                if (ip && form.ip.Length > 0)
                {
                    bool puertoVal = int.TryParse(form.puerto.ToString(), out puertoN);
                    if (puertoVal && (int.Parse(form.puerto.ToString()) > IPEndPoint.MinPort && int.Parse(form.puerto.ToString()) < IPEndPoint.MaxPort) && puertoVal.ToString().Length > 0)
                    {
                        todoOk = true;
                    }
                    else
                    {
                        todoOk = false;
                    }
                }

                if (todoOk)
                {
                    IP_SERVER = form.ip.ToString();
                    PORT = form.puerto;
                    txtRespuesta.Text = "Conexion cambiada correctamente";
                }
                else
                {
                    txtRespuesta.Text = "Debe introducir una IP y un puerto validos";
                }

                string path = Environment.GetEnvironmentVariable("USERPROFILE");
                try
                {


                    using (StreamWriter sw = new StreamWriter(path + "\\conexion.txt"))
                    {
                        sw.WriteLine(IP_SERVER);
                        sw.WriteLine(PORT);
                        sw.WriteLine(txtUsuario.Text);
                    }
                }
                catch (IOException error)
                {
                    Console.WriteLine($"Error {error.Message}");
                }



            }



        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            peticion("add");


        }

        private void btnList_Click(object sender, EventArgs e)
        {
            

            peticion("list");


        }

        public void peticion(String pet)
        {
            IPEndPoint ie = new IPEndPoint(IPAddress.Parse(IP_SERVER), PORT);

            Socket server = new Socket(AddressFamily.InterNetwork,
            SocketType.Stream, ProtocolType.Tcp);

            try
            {
                server.Connect(ie);
            }
            catch (SocketException)
            {
                Console.WriteLine("Error connection: {0}\nError code: {1}({2})");

                return;

            }

            using (NetworkStream ns = new NetworkStream(server))
            using (StreamReader sr = new StreamReader(ns))
            using (StreamWriter sw = new StreamWriter(ns))
            {
               if(txtUsuario.Text.Length > 0)
                {
                    //Enviamos el mensaje de usuario al servidor
                    // que que el servidor está esperando que le envíen algo
                    sw.WriteLine("user " + txtUsuario.Text);
                    sw.Flush();

                    msg = sr.ReadLine();
                    txtRespuesta.Text = msg;

                    sw.WriteLine(pet);
                    sw.Flush();

                    //Tenemos que capturar el segundo mensaje
                    while(sr.ReadLine() != null)
                    {
                        msg += sr.ReadLine() + "\r\n";
                        txtRespuesta.Text = msg;
                    }

                    
                }
                else
                {
                    MessageBox.Show("Debe introducir un nombre de usuario válido","Error en el nombre del usuario", MessageBoxButtons.OK);
                }
                    
                
            }
            Console.WriteLine("Ending connection");
            //Indicamos fin de transmisión.
            server.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = Environment.GetEnvironmentVariable("USERPROFILE");
            if (File.Exists(path + "\\Conection_Info.txt"))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(path + "\\Conection_Info.txt"))
                    {
                        bool ip = IPAddress.TryParse(sr.ReadLine(), out IPAddress ipConv);
                        bool port1 = int.TryParse(sr.ReadLine(), out int port);
                        if (ip)
                        {
                            IP_SERVER = ip.ToString();
                        }
                        else
                        {
                            IP_SERVER = "192.168.20.100";
                        }
                        if (port1 && port < IPEndPoint.MaxPort)
                        {
                            PORT = port;
                        }
                        else
                        {
                            PORT = 5001;
                        }
                        txtUsuario.Text = sr.ReadLine();
                    }
                }
                catch (IOException error)
                {
                    Console.WriteLine($"Error {error.Message}");
                }
            }
        }
    }
}
