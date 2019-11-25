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
        private decimal maxCantidad;

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
                SinTarjetasLink.Visible = true;
            }

            o_codigo.Text = datos["codigo"];
            o_descripcion.Text = datos["descripcion"];
            o_precio.Text = datos["precio"];

            decimal limiteCompra = decimal.Parse(datos["limiteCompra"]);
            decimal stockDisponible = decimal.Parse(datos["stock"]);
            if(stockDisponible >= limiteCompra)
                maxCantidad = limiteCompra;
            else
                maxCantidad = stockDisponible;        
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal totalAPagar = decimal.Parse(o_precio.Text) * cantidad.Value;
            DialogResult result = MessageBox.Show("¿Desea comprar la oferta de código '" + datos["codigo"] + "'?\nTotal: $" + totalAPagar,
            "Comprar oferta",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                registrarCompra();
        }

        private void registrarCompra()
        {
            if (cantidad.Value < 1)
            {
                MessageBox.Show("Cantidad no puede ser menor a 1");
                return;
            }

            if (cantidad.Value > maxCantidad)
            {
                MessageBox.Show("La cantidad excede el limite de compra (" + maxCantidad + ")");
                return;
            }

            if ((comboBoxTarjeta.SelectedItem != null && !comboBoxTarjeta.Items.Contains(comboBoxTarjeta.SelectedItem)) || comboBoxTarjeta.SelectedItem == null)
            {
                MessageBox.Show("Tarjeta inválida");
                return;
            }

            decimal saldo = decimal.Parse(tarj_saldo.Text);
            decimal totalAPagar = decimal.Parse(o_precio.Text) * cantidad.Value;
            if (saldo < totalAPagar)
            {
                MessageBox.Show("Saldo insuficiente.\n Total a pagar: $ " + totalAPagar + "\n Saldo tarjeta: $ " + saldo);
                return;
            }

            try
            {
                Tuple<string, List<string>, Object[]>[] procs = new Tuple<string, List<string>, object[]>[3];
                procs[0] = altaCompra();
                procs[1] = reduccionSaldoTarjeta(totalAPagar);
                procs[2] = reducirOfertaProv();

                ConexionBD.Conexion conection = new ConexionBD.Conexion().getInstance();
                conection.executeStoredTransaction(procs);

                MessageBox.Show("Compra realizada correctamente");
                this.Hide();
                pantallaOfertas.Hide();
                new ComprarOfertaABM().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la compra.\n" + ex.Message);
            }
        }

        private Tuple<string, List<string>, object[]> altaCompra()
        {
            string idCliente = new ConexionBD.Conexion().
                executeScalarFunction("obtenerIdCliente", Logeo.username).ToString();

            return new Tuple<string, List<string>, Object[]>(
                   Properties.Settings.Default.Schema + ".altaCompra",
                   new List<String>()
                    {
                         "@nombreUsuario","@id_cliente","@codigo_oferta","@fecha"
                    },
                   new Object[]{
                        Logeo.username, int.Parse(idCliente), datos["codigo"],
                        Properties.Settings.Default.fecha.ToShortDateString()
                    }
           );
        }

        private Tuple<string, List<string>, object[]> reduccionSaldoTarjeta(decimal saldo)
        {
            return new Tuple<string, List<string>, Object[]>(
                   Properties.Settings.Default.Schema + ".reducirSaldoTarjeta",
                   new List<String>()
                    {
                         "@numero_tarjeta","@saldo_a_reducir"
                    },
                   new Object[]{
                        decimal.Parse(comboBoxTarjeta.SelectedItem.ToString()), 
                        String.Format("{0:0.0000}", saldo).Replace(",", ".")
                    }
           );
        }

        private Tuple<string, List<string>, object[]> reducirOfertaProv()
        {
            return new Tuple<string, List<string>, Object[]>(
                   Properties.Settings.Default.Schema + ".reducirCantidadOferta",
                   new List<String>()
                    {
                         "@codigo_oferta","@cant_a_reducir"
                    },
                   new Object[]{
                        datos["codigo"], cantidad.Value
                    }
           );
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

        private void SinTarjetasLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new RegistrarTarjeta().Show();
        }
    }
}
