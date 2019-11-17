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
        private static string usuario;

        public CargaCreditoABM()
        {
            InitializeComponent();
        }

        public CargaCreditoABM(string user)
        {
            InitializeComponent();
            usuario = user;
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
            textBoxCliente.Text = usuario;
            string query = "SELECT tarjeta_numero FROM GESTION_DE_GATOS.Tarjeta t " +
            "JOIN GESTION_DE_GATOS.Cliente c on t.cliente_id = c.cliente_id " +
            "JOIN GESTION_DE_GATOS.Usuario u on u.usuario_id = c.usuario_id " +
            "WHERE u.usuario_nombre = " + "'" + usuario + "' and t.tarjeta_es_regalo = '0'";
            comboBoxTarjeta = new Conexion().populateComboBox(comboBoxTarjeta, query);

            if (comboBoxTarjeta.Items.Count == 0)
            {
                comboBoxTarjeta.Text = "Sin tarjetas registradas";
                SinTarjetasLink.Visible = true;
                cargarBtn.Enabled = false;
            }
        }

        private void comboBoxTarjeta_SelectedIndexChanged(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            float rAux;
            if(!float.TryParse(textBoxMonto.Text, out rAux)){
                MessageBox.Show("Monto debe ser un número");
                return;
            }
            if (rAux <= 0)
            {
                MessageBox.Show("Monto debe ser un número positivo");
                return;
            }

            List<String> parametros = new List<string>(){
               "@fechaCarga","@montoCarga","@numeroTarjeta"
            };
            string[] values = new string[]
            {
                dateTimePickerFechaCarga.Value.ToShortDateString(),textBoxMonto.Text,comboBoxTarjeta.Text
            };
            try
            {
                new Conexion().executeProcedure(Properties.Settings.Default.Schema + ".altaCarga", parametros, values);
                MessageBox.Show("Carga realizada correctamente");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al realizar la carga");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new MenuPrincipal().Show();
        }

        private void dateTimePickerFechaCarga_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new RegistrarTarjeta().Show();
        }

        private void comboBoxTarjeta_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            //Traer datos tarjeta
            tarj_numero.Text = comboBoxTarjeta.Text;
            tarj_tipo.Text = (string)new Conexion().executeScalarFunction("tipoTarjeta", comboBoxTarjeta.Text);
            tarj_banco.Text = (string)new Conexion().executeScalarFunction("bancoTarjeta", comboBoxTarjeta.Text);
            tarj_cvv.Text = new Conexion().executeScalarFunction("cvvTarjeta", comboBoxTarjeta.Text).ToString();
            tarj_saldo.Text = (string)new Conexion().executeScalarFunction("saldoTarjeta", comboBoxTarjeta.Text).ToString();
            tarj_fechaVencimiento.Value = (DateTime)new Conexion().executeScalarFunction("fechaVencimientoTarjeta", comboBoxTarjeta.Text);

            panelAgregarTarjeta.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
