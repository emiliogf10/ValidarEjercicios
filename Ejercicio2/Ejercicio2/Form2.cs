using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form2 : Form
    {
        public string ip;
        public int puerto;

        public Form2(String IP,int puerto)
        {
            InitializeComponent();
            lblIPantigua.Text = IP.ToString();
            lblPantiguo.Text = puerto.ToString();



        }

        
        private void btnCambiar_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.OK;
            ip = txtIPNueva.Text;
            puerto = int.Parse(txtPuertoNuevo.Text);
            Close();
        }
    }
}
