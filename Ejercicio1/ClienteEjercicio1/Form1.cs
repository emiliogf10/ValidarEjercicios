using System.Net;
using System.Net.Sockets;

namespace ClienteEjercicio1
{
    public partial class Form1 : Form
    {
        static String IP_SERVER;
        static int port;
        string msg;
        string userMsg;
        string contra;
        int puertoN;
        IPAddress ipConv;
        bool todoOk = false;

        public Form1()
        {
            InitializeComponent();
            port = 44000;
            IP_SERVER = "127.0.0.1";
            
        }




        private void bTime_Click(object sender, EventArgs e)
        {

            peticion("time");
        }

        private void bDate_Click(object sender, EventArgs e)
        {
            peticion("date");
        }

        private void bAll_Click(object sender, EventArgs e)
        {
            peticion("all");
        }


        private void bClose_Click(object sender, EventArgs e)
        {
            contra = txtContraseña.Text;
            if (contra.Length == 0)
            {
                MessageBox.Show("Introduzca una contraseña para poder cerrar el servidor", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                peticion("close" + " " + contra);
            }

        }

        private void bConexion_Click(object sender, EventArgs e)
        {

            Form2 form = new Form2(IP_SERVER, port);

            if (form.ShowDialog() == DialogResult.OK)
            {
                bool ip = IPAddress.TryParse(form.ip, out ipConv);
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
                else
                {
                    todoOk= false;
                   
                }

                if (todoOk)
                {
                    IP_SERVER = ipConv.ToString();
                    port = puertoN;
                    lblRspuesta.Text = "Conexion cambiada correctamente";
                }
                else
                {
                    lblRspuesta.Text = "Debe introducir una IP y un puerto validos";
                }
                

            }

            

        }


        public void peticion(String pet)
        {
            IPEndPoint ie = new IPEndPoint(IPAddress.Parse(IP_SERVER), port);

            Socket server = new Socket(AddressFamily.InterNetwork,
            SocketType.Stream, ProtocolType.Tcp);
            try
            {
                // El cliente inicia la conexión haciendo petición con Connect
                server.Connect(ie);
            }
            catch (SocketException o)
            {
                Console.WriteLine("Error connection: {0}\nError code: {1}({2})",
                o.Message, (SocketError)o.ErrorCode, o.ErrorCode);
                return;
            }
            using (NetworkStream ns = new NetworkStream(server))
            using (StreamReader sr = new StreamReader(ns))
            using (StreamWriter sw = new StreamWriter(ns))
            {

                Console.WriteLine(msg);


                try
                {
                    msg = sr.ReadLine();

                    // Lo siguiente es pedir un mensaje al usuario
                    userMsg = pet;
                    //Enviamos el mensaje de usuario al servidor
                    // que que el servidor está esperando que le envíen algo
                    sw.WriteLine(userMsg);
                    sw.Flush();
                    //Recibimos el mensaje del servidor
                    msg = sr.ReadLine();
                    lblRspuesta.Text = msg;
                }

                catch (IOException)
                {
                    MessageBox.Show("Hubo un error", "Error", MessageBoxButtons.OK);
                }

            }
            Console.WriteLine("Ending connection");
            //Indicamos fin de transmisión.
            server.Close();
        }

        
    }
}