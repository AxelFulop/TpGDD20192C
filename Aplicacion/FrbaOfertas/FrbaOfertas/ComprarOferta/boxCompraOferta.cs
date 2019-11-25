using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.ComprarOferta
{
    public partial class boxCompraOferta : Form
    {
        private ComprarOfertaABM pantallaOfertas;
        private Dictionary<string, string> datos;

        public boxCompraOferta(ComprarOfertaABM pantallaOfertas, Dictionary<string, string> row)
        {
            InitializeComponent();
            this.pantallaOfertas = pantallaOfertas;
            this.datos = row;
        }

        private void boxCompraOferta_Load(object sender, EventArgs e)
        {
            string query = "SELECT tarjeta_numero FROM GESTION_DE_GATOS.Tarjeta t " +
            "JOIN GESTION_DE_GATOS.Cliente c on t.cliente_id = c.cliente_id " +
            "JOIN GESTION_DE_GATOS.Usuario u on u.usuario_id = c.usuario_id " +
            "WHERE u.usuario_nombre = " + "'" + Logeo.username + "'";
            comboBoxTarjeta = new ConexionBD.Conexion().populateComboBox(comboBoxTarjeta, query);

            if (comboBoxTarjeta.Items.Count == 0)
            {
                comboBoxTarjeta.Text = "Sin tarjetas registradas";
                comprarBtn.Enabled = false;
            }

            o_codigo.Text = datos["codigo"];
            o_descripcion.Text = datos["descripcion"];
            o_precio.Text = datos["precio"];

            decimal limiteCompra = decimal.Parse(datos["limiteCompra"]);
            decimal stockDisponible = decimal.Parse(datos["stock"]);
            if(stockDisponible >= limiteCompra)
                cantidad.Maximum = limiteCompra;
            else
                cantidad.Maximum = stockDisponible;        
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea comprar la oferta de código '" + datos["codigo"] + "'?",
                "Comprar oferta",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //Registrar compra
                    MessageBox.Show("Compra realizada correctamente");
                }
                else return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la compra.\n" + ex.Message);
            }

            this.Hide();
            pantallaOfertas.Hide();
            new ComprarOfertaABM().Show();
        }

        private void tarj_numero_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTarjeta.Text = comboBoxTarjeta.Text;
            tarj_tipo.Text = (string)new ConexionBD.Conexion().executeScalarFunction("tipoTarjeta", comboBoxTarjeta.Text);
            tarj_banco.Text = (string)new ConexionBD.Conexion().executeScalarFunction("bancoTarjeta", comboBoxTarjeta.Text);
            tarj_cvv.Text = new ConexionBD.Conexion().executeScalarFunction("cvvTarjeta", comboBoxTarjeta.Text).ToString();
            tarj_saldo.Text = (string)new ConexionBD.Conexion().executeScalarFunction("saldoTarjeta", comboBoxTarjeta.Text).ToString();
            tarj_fechaVencimiento.Value = (DateTime)new ConexionBD.Conexion().executeScalarFunction("fechaVencimientoTarjeta", comboBoxTarjeta.Text);

            panelAgregarTarjeta.Visible = true;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
