using FrbaOfertas.ConexionBD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaOfertas.Login;
using FrbaOfertas.AbmCliente;

namespace FrbaOfertas
{
    public partial class RegistrarTarjeta : Form
    {
        public string username;
        public static Logeo log = new Logeo(5, 3);
        
        public string Username{
            get { return username; }
            set { this.username = value; }
        }
        
        public RegistrarTarjeta()
        {
            InitializeComponent();
            
     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MenuPrincipal().Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           

        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            String schema = Properties.Settings.Default.Schema;
            dateTimePickerFechaVenc.Format = DateTimePickerFormat.Custom;
            dateTimePickerFechaVenc.CustomFormat = "mm-yyyy";
            if (textBoxBanco.Text == "" || textBoxCVV.Text == "" ||
               textBoxNumero.Text == "" || comboBoxTipo.Text == "")
            {
                MessageBox.Show("No pueden haber campos sin datos");
            }
            else
            {
                
                string userName1 = log.UserName;
            
                List<String> parametrosTarjeta = new List<String>() { "@numeroTarjeta",
                "@tipoTarjeta", "@bancoTarjeta","@vencimientoFechaTarjeta","@cvvTarjeta","@userName"};
                try
                {
                    new Conexion().executeProcedure(schema + ".altaTarjeta", parametrosTarjeta,
                        textBoxNumero.Text, comboBoxTipo.Text, textBoxBanco.Text, dateTimePickerFechaVenc.Value,
                        textBoxCVV.Text,this.Username);

                    MessageBox.Show("Tarjeta agregada con exito");
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void RegistrarTarjeta_Load(object sender, EventArgs e)
        {

        }
    }
}
