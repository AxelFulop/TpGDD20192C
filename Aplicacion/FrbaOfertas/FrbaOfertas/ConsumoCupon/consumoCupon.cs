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
    public partial class consumoCupon : Form
    {
        private DataTable cupones;

        public consumoCupon()
        {
            InitializeComponent();
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            filtroDescripcion.Text = "";

            string idProv = new ConexionBD.Conexion().
                executeScalarFunction("obtenerIdProveedor", Logeo.username).ToString();

            string query = "SELECT c.cupon_id,c.cupon_precio,c.cupon_fecha_vencimiento,cp.compra_fecha,cli.cliente_id" +
                ",lower(concat(cli.cliente_nombre, ' ', cli.cliente_apellido)) as nom_y_apellido_cliente" +
                ",o.oferta_codigo,o.oferta_descripcion FROM GESTION_DE_GATOS.Cupon c " +
                "inner join GESTION_DE_GATOS.Oferta o on o.oferta_id = c.oferta_id " +
                "inner join GESTION_DE_GATOS.Compra cp on c.compra_id = cp.compra_id " +
                "inner join GESTION_DE_GATOS.Cliente cli on cli.cliente_id = cp.cliente_id " +
                "where c.cupon_canjeado = '0' AND o.proveedor_id = " + idProv;


            ConexionBD.Conexion conection = new ConexionBD.Conexion().getInstance();
            cupones = conection.selectReturnMultiplyRowsByQuery(query);
            grid.DataSource = cupones;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MenuPrincipal().Show();
        }

        private void consumoCupon_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            string idProv = new ConexionBD.Conexion().
                executeScalarFunction("obtenerIdProveedor", Logeo.username).ToString();

            string query = "SELECT c.cupon_id,c.cupon_precio,c.cupon_fecha_vencimiento,cp.compra_fecha,cli.cliente_id" +
                ",lower(concat(cli.cliente_nombre, ' ', cli.cliente_apellido)) as nom_y_apellido_cliente" +
	            ",o.oferta_codigo,o.oferta_descripcion FROM GESTION_DE_GATOS.Cupon c " +
                "inner join GESTION_DE_GATOS.Oferta o on o.oferta_id = c.oferta_id " +
                "inner join GESTION_DE_GATOS.Compra cp on c.compra_id = cp.compra_id " +
                "inner join GESTION_DE_GATOS.Cliente cli on cli.cliente_id = cp.cliente_id " +
                "where c.cupon_canjeado = '0' AND o.proveedor_id = " + idProv;


            ConexionBD.Conexion conection = new ConexionBD.Conexion().getInstance();
            cupones = conection.selectReturnMultiplyRowsByQuery(query);
            grid.DataSource = cupones;

            DataGridViewButtonColumn colEditar = new DataGridViewButtonColumn();
            colEditar.UseColumnTextForButtonValue = true;
            colEditar.Text = "Notificar consumición";
            colEditar.Name = "";
            grid.Columns.Add(colEditar);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string idProv = new ConexionBD.Conexion().
                executeScalarFunction("obtenerIdProveedor", Logeo.username).ToString();

            string query = "SELECT c.cupon_id,c.cupon_precio,c.cupon_fecha_vencimiento,cp.compra_fecha,cli.cliente_id" +
                ",lower(concat(cli.cliente_nombre, ' ', cli.cliente_apellido)) as nom_y_apellido_cliente" +
                ",o.oferta_codigo,o.oferta_descripcion FROM GESTION_DE_GATOS.Cupon c " +
                "inner join GESTION_DE_GATOS.Oferta o on o.oferta_id = c.oferta_id " +
                "inner join GESTION_DE_GATOS.Compra cp on c.compra_id = cp.compra_id " +
                "inner join GESTION_DE_GATOS.Cliente cli on cli.cliente_id = cp.cliente_id " +
                "where c.cupon_canjeado = '0' AND o.proveedor_id = " + idProv;

            if (filtroDescripcion.Text != "")
                query += " AND lower(concat(cli.cliente_nombre, ' ', cli.cliente_apellido)) LIKE '%" + filtroDescripcion.Text + "%'";

            ConexionBD.Conexion conection = new ConexionBD.Conexion().getInstance();
            cupones = conection.selectReturnMultiplyRowsByQuery(query);
            grid.DataSource = cupones;
        }
    }
}
