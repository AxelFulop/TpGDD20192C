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

namespace FrbaOfertas.CragaCredito
{
    public partial class CargaCreditoABM : Form
    {



      

        public CargaCreditoABM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MenuPrincipal().Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panelAgregarTarjeta_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePickerFechaCarga.Value = Properties.Settings.Default.fecha;
            dateTimePickerFechaCarga.Enabled = false;
            string query = "SELECT tarjeta_numero FROM GESTION_DE_GATOS.Tarjeta t JOIN GESTION_DE_GATOS.Cliente c on t.cliente_id = c.cliente_id JOIN GESTION_DE_GATOS.Usuario u on u.usuario_id = c.usuario_id WHERE u.usuario_nombre = " + "'" + Logeo.username + "'";
            comboBoxTarjeta = new Conexion().populateComboBox(comboBoxTarjeta, query);
            
     
        }

        private void comboBoxTarjeta_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAgregarTarjeta_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RegistrarTarjeta().Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonAceptar_Click(object sender, EventArgs e)
       {
           List<String> parametros = new List<string>(){
               "@fechaCarga","@montoCarga","@numeroTarjeta"
           };
           string [] values = new string []
           {
           dateTimePickerFechaCarga.Value.ToShortDateString(),textBoxMonto.Text,comboBoxTarjeta.Text
           };
           new Conexion().executeProcedure(Properties.Settings.Default.Schema + ".altaCarga",parametros,values);
        }
    

        private void comboBoxTarjeta_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string tipo = (string)new Conexion().executeScalarFunction("tipoTarjeta", comboBoxTarjeta.Text);
            textBoxTipo.Text = tipo;
            textBoxTipo.Enabled = false;
            string nombre = (string)new Conexion().executeScalarFunction("duenioTarjeta", comboBoxTarjeta.Text, Logeo.username);
            textBoxCliente.Text = nombre;
            textBoxCliente.Enabled = false;
        }
    }
}
