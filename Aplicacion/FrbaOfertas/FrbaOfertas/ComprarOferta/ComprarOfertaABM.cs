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
    public partial class ComprarOfertaABM : Form
    {
        private DataTable ofertas;

        public ComprarOfertaABM()
        {
            InitializeComponent();
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            cargarOfertas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MenuPrincipal().Show();
        }

        private void cargarOfertas()
        {
            string query = "SELECT oferta_codigo,oferta_descripcion,oferta_fecha_publicacion,oferta_fecha_vencimiento,oferta_limite_compra,oferta_stock_disponible,oferta_precio "
                + "FROM GESTION_DE_GATOS.Oferta WHERE '" + Properties.Settings.Default.fecha.ToShortDateString() +
            "' BETWEEN oferta_fecha_publicacion and oferta_fecha_vencimiento";
            ConexionBD.Conexion conection = new ConexionBD.Conexion().getInstance();
            ofertas  = conection.selectReturnMultiplyRowsByQuery(query);
            grid.DataSource = ofertas;

            DataGridViewButtonColumn colEditar = new DataGridViewButtonColumn();
            colEditar.UseColumnTextForButtonValue = true;
            colEditar.Text = "Comprar";
            colEditar.Name = "";
            grid.Columns.Add(colEditar);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.RowIndex < grid.Rows.Count)
            {
                if (e.ColumnIndex == 0)
                {
                    DataRow row = (grid.CurrentRow.DataBoundItem as DataRowView).Row;
                    DialogResult result = MessageBox.Show("¿Desea comprar la oferta de código '" + row.ItemArray[0].ToString() + "'?",
                    "Comprar oferta",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        realizarCompra(row);
                    }
                }
            }
        }

        private bool realizarCompra(DataRow row)
        {
            try
            {
                MessageBox.Show("Compra realizada correctamente");
                this.Hide();
                new ComprarOfertaABM().Show();
            }
            catch(Exception e)
            {
                MessageBox.Show("Error al realizar la compra.\n" + e.Message);
            }
            return true;
        }
    }
}
