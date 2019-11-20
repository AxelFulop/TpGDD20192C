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
            cargarOfertas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MenuPrincipal().Show();
        }

        private void cargarOfertas()
        {
            string query = "SELECT oferta_descripcion,oferta_codigo,oferta_fecha_publicacion,oferta_fecha_vencimiento,oferta_limite_compra,oferta_stock_disponible,oferta_precio,oferta_precio_lista "
                + "FROM GESTION_DE_GATOS.Oferta";// WHERE oferta_fecha_vencimiento > " + '"' +Properties.Settings.Default.fecha.ToShortDateString() + '"';
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
    }
}
