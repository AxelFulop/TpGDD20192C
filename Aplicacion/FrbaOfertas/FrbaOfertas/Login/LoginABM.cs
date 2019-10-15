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
            //Chequear si las dos contraseñas son iguales y si los datos están completos...
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
    }

 }

