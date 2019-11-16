using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.AbmCliente
{
    public partial class Nuevo : Form
    {
        public Nuevo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AbmCliente().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username= nombre.Text + '_' + apellido.Text;
            RegistrarTarjeta tarjetaAbm = new RegistrarTarjeta(username);
            
        }
    }
}
