using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteEjercicio1
{
    public partial class Form2 : Form
    {

        public string ip;
        public int puerto;

        public Form2(string IP,int PUERTO)
        {
            InitializeComponent();
            lblIPantigua.Text += IP.ToString();
            lblPuertoAntiguo.Text += PUERTO.ToString();
            
        }

        
        
        

        private void button1_Click(object sender, EventArgs e)
        {
            
            DialogResult= DialogResult.OK;
            ip = txtIpNueva.Text;
            puerto = int.Parse(txtPuertoNuevo.Text);
            Close();
        }
    }
}
