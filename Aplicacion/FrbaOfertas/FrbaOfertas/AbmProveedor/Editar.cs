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
    public partial class Editar : Form
    {
        public Editar(Dictionary<string, string> row)
        {
            InitializeComponent();
            string[] dir = row["direccion"].Split(' ');

            this.dir_calle.Text = "";
            for (int i = 0; i < dir.Length - 1; i++)
            {
                this.dir_calle.Text += dir[i] + " ";
            }
            this.dir_calle.Text = this.dir_calle.Text.TrimEnd(' ');
            this.dir_numero.Text = dir.Last();

            this.dir_piso.Text = row["direccion_piso"];
            this.dir_depto.Text = row["direccion_depto"];
            this.dir_localidad.Text = row["direccion_localidad"];

            this.razonSocial.Text = row["razonSocial"];
            this.mail.Text = row["mail"];
            this.telefono.Text = row["telefono"];
            this.codigoPostal.Text = row["codigoPostal"];
            this.cuit.Text = row["cuit"];
            this.rubro.Text = row["rubro"];
            this.contacto.Text = row["contacto"];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            new AbmProveedor().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Verificar cambios y guardarlos en la DB
        }
    }
}
