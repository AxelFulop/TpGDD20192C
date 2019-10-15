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
    public partial class Editar : Form
    {
        public Editar(Dictionary<string, string> row)
        {
            InitializeComponent();
            this.nombre.Text = row["nombre"];
            this.apellido.Text = row["apellido"];
            this.mail.Text = row["mail"];
            this.dni.Text = row["dni"];
            this.direccion.Text = row["direccion"];
            this.telefono.Text = row["telefono"];
            this.codigoPostal.Text = row["codigoPostal"];
            this.fechaNacimiento.Text = row["fechaNacimiento"];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            new AbmCliente().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Verificar cambios y guardarlos en la DB
        }
    }
}
