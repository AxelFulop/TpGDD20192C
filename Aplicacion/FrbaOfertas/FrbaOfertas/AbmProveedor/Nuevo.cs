using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.AbmProveedor
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
            new AbmProveedor().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Verificar campos y guardar proveedor en la DB
        }
    }
}
