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
        private Dictionary<string, string> datos;

        public Editar(Dictionary<string, string> row)
        {
            InitializeComponent();
            datos = row;
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

            Object estaHabilitado = new ConexionBD.Conexion().executeScalarFunction("proveedorEstaHabilitado",
                        razonSocial.Text, cuit.Text);
            if (estaHabilitado.ToString() == "1") //Si está inhabilitado
            {
                habilitarBtn.Visible = true;
            }
            else
            {
                inhabilitarBtn.Visible = true;
            }
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

        private void Editar_Load(object sender, EventArgs e)
        {

        }

        private void habilitarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                new ConexionBD.Conexion().executeProcedure(Properties.Settings.Default.Schema + ".habilitarProveedor",
                    new List<string>() { "@razonSocial", "@cuit" },
                    new string[] { datos["razonSocial"], datos["cuit"] });
                MessageBox.Show("Proveedor habilitado correctamente");
                this.Hide();
                new Editar(datos).Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al habilitar al proveedor");
            } 
        }

        private void inhabilitarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                new ConexionBD.Conexion().executeProcedure(Properties.Settings.Default.Schema + ".inhabilitarProveedor",
                    new List<string>() { "@razonSocial", "@cuit" },
                    new string[] { datos["razonSocial"], datos["cuit"] });
                MessageBox.Show("Proveedor inhabilitado correctamente");
                this.Hide();
                new Editar(datos).Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al inhabilitar al proveedor");
            } 
        }
    }
}
