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

        private void RegistrarTarjeta_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MenuPrincipal().Show();
        }

        private void cargarBtn_Click(object sender, EventArgs e)
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
                float tipo, cvv, num;
                if (!float.TryParse(textBoxNumero.Text, out num) ||
                    !float.TryParse(textBoxCVV.Text, out cvv))
                {
                    MessageBox.Show("Número tarjeta y CVV deben ser datos numéricos");
                    return;
                }

                List<String> parametrosTarjeta = new List<String>() { "@numeroTarjeta",
                "@tipoTarjeta", "@bancoTarjeta","@vencimientoFechaTarjeta","@cvvTarjeta","@userName"};
                try
                {
                    new Conexion().executeProcedure(schema + ".altaTarjeta", parametrosTarjeta,
                        textBoxNumero.Text, comboBoxTipo.Text, textBoxBanco.Text, dateTimePickerFechaVenc.Value,
                        textBoxCVV.Text, Logeo.username);

                    MessageBox.Show("Tarjeta registrada con exito");
                    this.Hide();
                    new MenuPrincipal().Show();
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxBanco.Text = "";
            textBoxCVV.Text = "";
            textBoxNumero.Text = "";
        }
    }
}
