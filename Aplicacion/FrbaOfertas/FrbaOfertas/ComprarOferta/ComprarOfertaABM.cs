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
                try
                {
                    if (e.ColumnIndex == 0)
                    {
                        DataRow row = (grid.CurrentRow.DataBoundItem as DataRowView).Row;
                        Dictionary<string, string> datos = ajustarDatosRow(row);
                        if (int.Parse(datos["stock"]) <= 0)
                        {
                            MessageBox.Show("Esta oferta no tiene stock disponible");
                            return;
                        }
                        new boxCompraOferta(this, datos).Show();
                    }
                }
                catch (Exception) { }
            }
        }

        private Dictionary<string, string> ajustarDatosRow(DataRow row)
        {
            Dictionary<string, string> datosRow = new Dictionary<string, string>();

            datosRow["codigo"] = row.ItemArray[0].ToString();
            datosRow["descripcion"] = row.ItemArray[1].ToString();
            datosRow["fechaPublicacion"] = row.ItemArray[2].ToString();
            datosRow["fechaVencimiento"] = row.ItemArray[3].ToString();
            datosRow["limiteCompra"] = row.ItemArray[4].ToString();
            datosRow["stock"] = row.ItemArray[5].ToString();
            datosRow["precio"] = row.ItemArray[6].ToString();

            return datosRow;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "SELECT oferta_codigo,oferta_descripcion,oferta_fecha_publicacion,oferta_fecha_vencimiento,oferta_limite_compra,oferta_stock_disponible,oferta_precio "
                + "FROM GESTION_DE_GATOS.Oferta WHERE ('" + Properties.Settings.Default.fecha.ToShortDateString() +
            "' BETWEEN oferta_fecha_publicacion and oferta_fecha_vencimiento)";
            if (filtroDescripcion.Text != "")
                query += " AND oferta_descripcion LIKE '%" + filtroDescripcion.Text + "%'";

            ConexionBD.Conexion conection = new ConexionBD.Conexion().getInstance();
            ofertas = conection.selectReturnMultiplyRowsByQuery(query);
            grid.DataSource = ofertas;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            filtroDescripcion.Text = "";

            string query = "SELECT oferta_codigo,oferta_descripcion,oferta_fecha_publicacion,oferta_fecha_vencimiento,oferta_limite_compra,oferta_stock_disponible,oferta_precio "
                + "FROM GESTION_DE_GATOS.Oferta WHERE '" + Properties.Settings.Default.fecha.ToShortDateString() +
            "' BETWEEN oferta_fecha_publicacion and oferta_fecha_vencimiento";
            ConexionBD.Conexion conection = new ConexionBD.Conexion().getInstance();
            ofertas = conection.selectReturnMultiplyRowsByQuery(query);
            grid.DataSource = ofertas;
        }
    }
}
