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
            this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            textBoxProvTelefono.Text = "0";
            textBoxProvCodPost.Text = "0";
            textBoxDni.Text = "0";
            textBoxTelefono.Text = "0";
            textBoxCodPostal.Text = "0";
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

            if (prov_cuit.Text == "" && rol.SelectedItem.ToString() == "Proveedor")
            {
                MessageBox.Show("CUIT no puede estar vacío");
                return;
            }

            if (prov_razonSocial.Text == "" && rol.SelectedItem.ToString() == "Proveedor")
            {
                MessageBox.Show("Razón social no puede estar vacío");
                return;
            }

            int cantProcs = 3;
            if (rol.SelectedItem.ToString() == "Proveedor")
                cantProcs = 2;
            Tuple<string, List<string>, Object[]>[] procs = new Tuple<string,List<string>,object[]>[cantProcs];
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
                Logeo.username = usuario.Text;
            }
            else
            {
                MessageBox.Show("Rol incorrecto", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cantProcs == 3)
                procs[2] = tarjetaNueva();
            try
            {
                ConexionBD.Conexion conection = new ConexionBD.Conexion().getInstance();
                conection.executeStoredTransaction(procs);

                MessageBox.Show("Usuario creado correctamente");
                Logeo.username = usuario.Text;
                this.Hide();
                new MenuPrincipal(usuario.Text).Show();
            }
            catch (Exception exec)
            {
                MessageBox.Show(exec.Message.ToString());
            }            
        }

        private Tuple<string, List<string>, Object[]> tarjetaNueva()
        {
            return new Tuple<string, List<string>, Object[]>(
                 Properties.Settings.Default.Schema + ".tarjetaRegaloParaUsuario",
           new List<String>() {
               "@userName", "@fechaVencimiento"
           },
           new Object[]{
               usuario.Text, new DateTime(2100, 12, 31).ToShortDateString()
           }
           );
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
                        "@razonSocialProveedor", "@mailProveedor", "@telefonoProveedor", "@direccionProveedor","@pisoProveedor", 
                        "@deptoProveedor", "@localidadProveedor", "@codigoPostalProveedor", "@ciudadProveedor", "@cuitProveedor", "@rubroProveedor", 
                        "@nombreDeContactoProveedor", "@usuario"
                    },
                    new String[]{
                        prov_razonSocial.Text, prov_mail.Text, textBoxTelefono.Text == ""? DBNull.Value.ToString() : textBoxTelefono.Text,
                        dir_calle.Text + " " + (dir_numero.Value.ToString() == ""? DBNull.Value.ToString() : dir_numero.Value.ToString()), dir_piso.Value.ToString() == ""? DBNull.Value.ToString() : dir_piso.Value.ToString(), dir_depto.Text, dir_localidad.Text, 
                        textBoxProvCodPost.Text == ""? DBNull.Value.ToString() : textBoxProvCodPost.Text, prov_ciudad.Text, prov_cuit.Text, prov_rubro.Text, prov_contacto.Text, usuario.Text
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
                         cli_fechaNacimiento.Value.ToString(),cli_nombre.Text,cli_apellido.Text,textBoxDni.Text == ""? DBNull.Value.ToString() : textBoxDni.Text,
                         cli_mail.Text,textBoxTelefono.Text == ""? DBNull.Value.ToString() : textBoxTelefono.Text, dir_calle.Text + " " + (dir_numero.Text == ""? DBNull.Value.ToString() : dir_numero.Text), 
                         dir_piso.Text == ""? DBNull.Value.ToString() : dir_piso.Text, dir_depto.Text, dir_localidad.Text, 
                         textBoxCodPostal.Text == ""? DBNull.Value.ToString() : textBoxCodPostal.Text, cli_ciudad.Text, usuario.Text
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
                    this.panelProveedor.Visible = false;
                    this.panelCliente.Visible = true;
                    break;
                case "Proveedor":
                    this.panelCliente.Visible = false;
                    this.panelProveedor.Visible = true; 
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

       

        private void cli_mail_Leave(object sender, EventArgs e)
        {
            new Util().emailValidator(cli_mail);
        }


        private void label12_Click(object sender, EventArgs e)
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

        private void dir_piso_ValueChanged(object sender, EventArgs e)
        {

        }



        private void textBoxDni_KeyPress(object sender, EventArgs e)
        {
            new Util().textBoxValidate(textBoxDni, "DNI");
        }

        private void textBoxCodPostal_KeyPress(object sender, EventArgs e)
        {
            new Util().textBoxValidate(textBoxCodPostal, "codigo postal");
        }

        private void textBoxTelefono_KeyPress(object sender, EventArgs e)
        {
            new Util().textBoxValidate(textBoxTelefono, "telefono");
        }  

        private void cli_dni_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDni_TextChanged(object sender, EventArgs e)
        {
            new Util().textBoxValidate(textBoxDni, "DNI");
        }

  
        private void textBoxTelefono_TextChanged(object sender, EventArgs e)
        {
            new Util().textBoxValidate(textBoxTelefono, "telefono");
        }

        private void textBoxCodPostal_TextChanged(object sender, EventArgs e)
        {
            new Util().textBoxValidate(textBoxCodPostal, "codigo postal");
        }

        private void cli_mail_LostFocus_1(object sender, EventArgs e)
        {
            new Util().emailValidator(cli_mail);
        }



        private void prov_mail_LostFocus_1(object sender, EventArgs e)
        {
            new Util().emailValidator(prov_mail);
        }

        private void textBoxProvTelefono_TextChanged(object sender, EventArgs e)
        {
            new Util().textBoxValidate(textBoxProvTelefono, "telefono");
        }

        private void textBoxProvCodPost_TextChanged(object sender, EventArgs e)
        {
            new Util().textBoxValidate(textBoxProvCodPost, "codigo postal");
        }               
    }

 }

