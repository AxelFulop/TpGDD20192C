using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.ConsumoCupon
{
    public partial class boxConsumoCupon : Form
    {
        private consumoCupon pantallaConsumoCupon;
        private Dictionary<string, string> datos;

        public boxConsumoCupon(consumoCupon pantallaConsumoCupon, Dictionary<string, string> row)
        {
            InitializeComponent();
            this.pantallaConsumoCupon = pantallaConsumoCupon;
            this.datos = row;
        }

        private void boxConsumoCupon_Load(object sender, EventArgs e)
        {
            cupon_codigo.Text = datos["cupon_id"];
            cupon_precio.Text = datos["cupon_precio"];
            cupon_fechaVencimiento.Text = datos["cupon_fechaVencimiento"];
            cupon_fechaCompra.Text = datos["compra_fecha"];
            cliente_dni.Text = datos["cliente_dni"];
            cliente_nomApe.Text = datos["cliente_nom_ape"];
            oferta_codigo.Text = datos["oferta_codigo"];
            oferta_descripcion.Text = datos["oferta_descripcion"];
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comprarBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea registrar la entrega?",
            "Registrar entrega",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if(fechaEntrega.Value.CompareTo(cupon_fechaCompra.Value) < 0){
                    MessageBox.Show("La fecha de entrega no puede ser menor a la fecha de compra");
                    return;
                }

                if (fechaEntrega.Value.CompareTo(cupon_fechaVencimiento.Value) > 0)
                {
                    MessageBox.Show("La fecha de entrega no puede ser mayor que la fecha de vencimiento");
                    return;
                }

                try
                {
                    new ConexionBD.Conexion().getInstance().executeProcedure(
                        Properties.Settings.Default.Schema + ".registrarEntregaCupon",
                        new List<string>() {
                            "@codigo_cupon", "@fechaConsumo"
                        },
                        new Object[]{
                            cupon_codigo.Text, fechaEntrega.Value.ToShortDateString()
                        }
                    );

                    MessageBox.Show("Entrega registrada correctamente");
                    this.Hide();
                    pantallaConsumoCupon.Dispose();
                    new ConsumoCupon.consumoCupon().Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al procesar la entrega de la oferta.\n'" + ex.Message + "'");
                }
                
            }
        }
    }
}
