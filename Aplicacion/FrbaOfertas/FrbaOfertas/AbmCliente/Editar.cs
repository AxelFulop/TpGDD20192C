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
            string[] dir = row["direccion"].Split(new string[]{"-"}, 5, StringSplitOptions.None);

            this.dir_calle.Text = dir[0];
            this.dir_numero.Text = dir[1];
            this.dir_piso.Text = dir[2];
            this.dir_depto.Text = dir[3];
            this.dir_localidad.Text = dir[4];

            this.nombre.Text = row["nombre"];
            this.apellido.Text = row["apellido"];
            this.mail.Text = row["mail"];
            this.dni.Text = row["dni"];
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

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void dir_depto_TextChanged(object sender, EventArgs e)
        {

        }

        private void dir_localidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }
    }
}
