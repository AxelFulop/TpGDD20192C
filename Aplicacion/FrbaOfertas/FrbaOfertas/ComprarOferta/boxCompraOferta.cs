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
        private DataRow datos;

        public boxCompraOferta(ComprarOfertaABM pantallaOfertas, DataRow row)
        {
            InitializeComponent();
            this.pantallaOfertas = pantallaOfertas;
            this.datos = row;
        }

        private void boxCompraOferta_Load(object sender, EventArgs e)
        {

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea comprar la oferta de código '" + datos.ItemArray[0].ToString() + "'?",
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
    }
}
