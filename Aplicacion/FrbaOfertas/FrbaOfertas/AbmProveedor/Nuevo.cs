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
            DateTime fechaVenc = Properties.Settings.Default.fecha;
            string schema = Properties.Settings.Default.Schema;

            Tuple<string, List<string>, Object[]>[] procs = new Tuple<string, List<string>, object[]>[2];
            procs[1] = altaProveedor();
            procs[0] = altaUsuario();

            try
            {
                ConexionBD.Conexion conection = new ConexionBD.Conexion().getInstance();
                conection.executeStoredTransaction(procs);

                MessageBox.Show("Proveedor creado correctamente");
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private Tuple<string, List<string>, Object[]> altaProveedor()
        {
            return new Tuple<string, List<string>, Object[]>(
                   Properties.Settings.Default.Schema + ".altaProveedor",
                   new List<String>()
                    {
                         "@razonSocialProveedor","@mailProveedor","@teléfonoProveedor","@direccionProveedor",
		                 "@pisoProveedor","@deptoProveedor","@localidadProveedor", "@codigoPostalProveedor",
                         "@ciudadProveedor", "@cuitProveedor",
		                 "@rubroProveedor" ,"@nombreDeContactoProveedor","@usuario"
                         
                    },
                   new Object[]{

                        razonSocial.Text, mail.Text, telefono.Text, direccion.Text,
                        piso.Text, depto.Text, localidad.Text, codigoPostal.Text, ciudad.Text,
                        cuit.Text, rubro.Text, contacto.Text, cuit.Text       
                    }
           );

        }

        private Tuple<string, List<string>, Object[]> altaUsuario()
        {
            return new Tuple<string, List<string>, Object[]>(
                    Properties.Settings.Default.Schema + ".altaUsuario",
                    new List<String>()
                    {
                        "@nombreUsuario", "@password"
                    },
                    new String[]{
                       cuit.Text, razonSocial.Text
                    }
                );
        }

        private void label8_Click(object sender, EventArgs e)
        {
        
        }

        private void Nuevo_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }
    }
}
