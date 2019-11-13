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


namespace FrbaOfertas.Login
{
    public partial class LoginABM : Form
    {
        Util utils = new Util();

        public LoginABM()
        {
            InitializeComponent();
        }

        private void LoginABM_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (password1.Text != password2.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (rol.SelectedText == "Proveedor")
                {
                    altaProveedor();
                }
                else if (rol.SelectedText == "Cliente")
                {
                    altaCliente();
                }
                else
                {
                    MessageBox.Show("Rol incorrecto", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show("Usuario creado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                new MenuPrincipal(usuario.Text).Show();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Error al crear usuario", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void altaProveedor()
        {

        }

        private void altaCliente()
        {
            ConexionBD.Conexion conection = new ConexionBD.Conexion().getInstance();
            conection.executeProcedure(Properties.Settings.Default.Schema + ".altaCliente",
                new List<String>()
                {
                    "@nombreCliente", "@apellidoCliente", "@dniCliente", "@mailCliente", "@telefonoCliente", 
                    "@direccionCliente", "@codigoPostalCliente", "@ciudadCliente"
                },
                new String[]{
                    cli_nombre.Text, cli_apellido.Text, cli_dni.Text, cli_mail.Text, cli_telefono.Text, 
                    cli_direccion.Text, cli_cp.Text, cli_ciudad.Text
                }
            );

            MessageBox.Show("Rol '" + this.rol + "' habilitado correctamente");
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
    }

 }

