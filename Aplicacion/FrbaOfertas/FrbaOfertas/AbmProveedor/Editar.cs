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
            if (passwordNueva1.Text != passwordNueva2.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return;
            }
            float rAux;
            if (!float.TryParse(telefono.Text, out rAux) || !float.TryParse(codigoPostal.Text, out rAux) 
                || !float.TryParse(dir_numero.Text, out rAux) || !float.TryParse(dir_piso.Text, out rAux))
            {
                MessageBox.Show("Campos numéricos deben tener sólo números");
                return;
            }

            try
            {
                new ConexionBD.Conexion().executeQuery(String.Format(
                "update {0}.Proveedor set proveedor_razon_social='{1}', proveedor_email='{2}', proveedor_telefono={3}, " +
                "proveedor_codigo_postal={4}, proveedor_cuit='{5}', proveedor_rubro='{6}', proveedor_contacto='{7}', " +
                "proveedor_direccion='{8}', proveedor_direccion_piso={9}, proveedor_direccion_depto='{10}', " +
                "proveedor_direccion_localidad='{11}' where proveedor_id={12}",
                Properties.Settings.Default.Schema,razonSocial.Text, mail.Text, telefono.Text, codigoPostal.Text,
                cuit.Text, rubro.Text, contacto.Text, dir_calle.Text + " " + dir_numero.Text,
                dir_piso.Text, dir_depto.Text, dir_localidad.Text, datos["id"]));

                if (passwordNueva1.Text != "" && passwordNueva2.Text != "")
                {
                    new ConexionBD.Conexion().executeProcedure(Properties.Settings.Default.Schema + ".cambiarContraseniaProveedor",
                        new List<string>() { "@id_proveedor", "@password" },
                        new string[] { datos["id"], passwordNueva1.Text });
                }
                MessageBox.Show("Proveedor actualizado correctamente");
                this.Hide();
                new AbmProveedor().Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al actualizar los datos del proveedor");
            }
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
