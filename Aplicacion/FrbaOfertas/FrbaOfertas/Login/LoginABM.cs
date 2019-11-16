using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaOfertas.ConexionBD;
using FrbaOfertas.Utils;
using System.Text.RegularExpressions;


namespace FrbaOfertas.Login
{
    public partial class LoginABM : Form
    {
        Util utils = new Util();

        public LoginABM()
        {
            InitializeComponent();
            cli_fechaNacimiento.Format = DateTimePickerFormat.Custom;
            cli_fechaNacimiento.CustomFormat = "yyyy-MM-dd";
        }

        private void LoginABM_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (password1.Text == "" || password2.Text == "")
            {
                MessageBox.Show("Complete las contraseñas", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password1.Text != password2.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dir_calle.Text.Contains("-") || dir_depto.Text.Contains("-") || dir_localidad.Text.Contains("-") ||
                dir_numero.Text.Contains("-") || dir_piso.Text.Contains("-"))
            {
                MessageBox.Show("Valores incorrectos de la dirección", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Tuple<string, List<string>, Object[]>[] procs = new Tuple<string,List<string>,object[]>[2];
            procs[0] = altaUsuarioProc();

            if (rol.SelectedItem == null)
            {
                MessageBox.Show("Complete rol", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (rol.SelectedItem.ToString() == "Proveedor")
            {
                procs[1] = altaProveedorProc();
            }
            else if (rol.SelectedItem.ToString() == "Cliente")
            {
                procs[1] = altaClienteProc();
                Logeo log = new Logeo(5, 3);
                string userName = log.UserName;

            }
            else
            {
                MessageBox.Show("Rol incorrecto", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ConexionBD.Conexion conection = new ConexionBD.Conexion().getInstance();
                conection.executeStoredTransaction(procs);

                MessageBox.Show("Usuario creado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                new MenuPrincipal(usuario.Text).Show();
            }
            catch (System.Data.SqlClient.SqlException exec)
            {
                MessageBox.Show(exec.ToString());
            }            
        }

        private Tuple<string, List<string>, Object[]> altaUsuarioProc()
        {
            return new Tuple<string, List<string>, Object[]>(
                    Properties.Settings.Default.Schema + ".altaUsuario",
                    new List<String>()
                    {
                        "@nombreUsuario", "@password"
                    },
                    new String[]{
                        usuario.Text, password1.Text,
                    }
                );
        }

        private Tuple<string, List<string>, Object[]> altaProveedorProc()
        {            
            return new Tuple<string, List<string>, Object[]>(
                    Properties.Settings.Default.Schema + ".altaProveedor",
                    new List<String>()
                    {
                        "@razonSocialProveedor", "@mailProveedor", "@teléfonoProveedor", "@direccionProveedor","@pisoProveedor", 
                        "@deptoProveedor", "@localidadProveedor", "@codigoPostalProveedor", "@ciudadProveedor", "@cuitProveedor", "@rubroProveedor", 
                        "@nombreDeContactoProveedor", "@usuario"
                    },
                    new String[]{
                        prov_razonSocial.Text, prov_mail.Text, prov_telefono.Text,
                        dir_calle.Text + " " + dir_numero.Text, dir_piso.Text, dir_depto.Text, dir_localidad.Text, 
                        prov_cp.Text, prov_ciudad.Text, prov_cuit.Text, prov_rubro.Text, prov_contacto.Text, usuario.Text
                    }
                );
        }

        private Tuple<string, List<string>, Object[]> altaClienteProc()
        {
            return new Tuple<string, List<string>, Object[]>(
                    Properties.Settings.Default.Schema + ".altaCliente",
                    new List<String>()
                    {
                         "@fecha_nac","@nombreCliente","@apellidoCliente","@dniCliente",
		                 "@mailCliente","@telefonoCliente","@direccionCliente", "@pisoCliente",
                         "@deptoCliente", "@localidadCliente",
		                 "@codigoPostalCliente" ,"@ciudadCliente","@usuario"
                         
                    },
                    new Object[]{

                         cli_fechaNacimiento.Value.ToString(),cli_nombre.Text,cli_apellido.TextAlign,cli_dni.Text,
                         cli_mail.Text,cli_telefono.Text,dir_calle.Text + " " + dir_numero.Text,dir_piso.Text,
                         dir_depto.Text, dir_localidad.Text, 
                         cli_cp.Text, cli_ciudad.Text, usuario.Text
                         
                       
                    }
            );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            new Logeo(5, 3).Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rol_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.rol.Text)
            {
                case "Cliente":
                    this.panelProveedor.Hide();
                    this.panelCliente.Show(); 
                    break;
                case "Proveedor":
                    this.panelCliente.Hide();
                    this.panelProveedor.Show(); 
                    break;
            }
        }

        private void razonSocial_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void telefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void cli_mail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void prov_ciudad_TextChanged(object sender, EventArgs e)
        {

        }

        private void prov_contacto_TextChanged(object sender, EventArgs e)
        {

        }

        private void prov_rubro_TextChanged(object sender, EventArgs e)
        {

        }

        private void prov_cuit_TextChanged(object sender, EventArgs e)
        {

        }

        private void prov_cp_TextChanged(object sender, EventArgs e)
        {

        }

        private void prov_direccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void prov_mail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void cli_telefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void dir_numero_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cli_cp_TextChanged(object sender, EventArgs e)
        {

        }

        private void usuario_TextChanged(object sender, EventArgs e)
        {

        }               
    }

 }

