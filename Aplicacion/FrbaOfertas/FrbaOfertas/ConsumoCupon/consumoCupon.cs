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

            string query = "SELECT c.cupon_id,c.cupon_precio,c.cupon_fecha_vencimiento,cp.compra_fecha,cli.cliente_numero_dni" +
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

            razonSocial.Text = this.obtenerRazonSocial();
            cuit.Text = obtenerCuit();
            if (razonSocial.Text != "" && cuit.Text != "")
            { //Si es un proveedor
                razonSocial.Enabled = false;
                cuit.Enabled = false;
                verCuponesBtn.Visible = false;

                string idProv = new ConexionBD.Conexion().
                executeScalarFunction("obtenerIdProveedorPorCuitYRs", cuit.Text, razonSocial.Text).ToString();

                string query = "SELECT c.cupon_id,c.cupon_precio,c.cupon_fecha_vencimiento,cp.compra_fecha,cli.cliente_numero_dni" +
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
        }

        private string obtenerRazonSocial()
        {
            Object ret = new ConexionBD.Conexion().executeScalarFunction("obtenerRazonSocialProveedor", Logeo.username);
            if (ret == DBNull.Value)
                return "";
            else
                return ret.ToString();
        }

        private string obtenerCuit()
        {
            Object ret = new ConexionBD.Conexion().executeScalarFunction("obtenerCuitProveedor", Logeo.username);
            if (ret == DBNull.Value)
                return "";
            else
                return ret.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string idProv = new ConexionBD.Conexion().
                executeScalarFunction("obtenerIdProveedor", Logeo.username).ToString();

            string query = "SELECT c.cupon_id,c.cupon_precio,c.cupon_fecha_vencimiento,cp.compra_fecha,cli.cliente_numero_dni" +
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

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.RowIndex < grid.Rows.Count)
            {
                try
                {
                    if (e.ColumnIndex == 8 || e.ColumnIndex == 0)
                    {
                        DataRow row = (grid.CurrentRow.DataBoundItem as DataRowView).Row;
                        Dictionary<string, string> datos = ajustarDatosRow(row);
                        if (DateTime.Parse(datos["cupon_fechaVencimiento"]).CompareTo(Properties.Settings.Default.fecha) < 0)
                        {
                            MessageBox.Show("El cupón ya ha vencido");
                            return;
                        }
                        new boxConsumoCupon(this, datos).Show();
                    }
                }
                catch (Exception) { }
            }
        }

        private Dictionary<string, string> ajustarDatosRow(DataRow row)
        {
            Dictionary<string, string> datosRow = new Dictionary<string, string>();

            datosRow["cupon_id"] = row.ItemArray[0].ToString();
            datosRow["cupon_precio"] = row.ItemArray[1].ToString();
            datosRow["cupon_fechaVencimiento"] = row.ItemArray[2].ToString();
            datosRow["compra_fecha"] = row.ItemArray[3].ToString();
            datosRow["cliente_dni"] = row.ItemArray[4].ToString();
            datosRow["cliente_nom_ape"] = row.ItemArray[5].ToString();
            datosRow["oferta_codigo"] = row.ItemArray[6].ToString();
            datosRow["oferta_descripcion"] = row.ItemArray[7].ToString();

            return datosRow;
        }

        private void verCuponesBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string idProv = new ConexionBD.Conexion().
                executeScalarFunction("obtenerIdProveedorPorCuitYRs", cuit.Text, razonSocial.Text).ToString();

                if (idProv == DBNull.Value.ToString())
                {
                    MessageBox.Show("Proveedor inexistente");
                    return;
                }

                string query = "SELECT c.cupon_id,c.cupon_precio,c.cupon_fecha_vencimiento,cp.compra_fecha,cli.cliente_numero_dni" +
                    ",lower(concat(cli.cliente_nombre, ' ', cli.cliente_apellido)) as nom_y_apellido_cliente" +
                    ",o.oferta_codigo,o.oferta_descripcion FROM GESTION_DE_GATOS.Cupon c " +
                    "inner join GESTION_DE_GATOS.Oferta o on o.oferta_id = c.oferta_id " +
                    "inner join GESTION_DE_GATOS.Compra cp on c.compra_id = cp.compra_id " +
                    "inner join GESTION_DE_GATOS.Cliente cli on cli.cliente_id = cp.cliente_id " +
                    "where c.cupon_canjeado = '0' AND o.proveedor_id = " + idProv;

                ConexionBD.Conexion conection = new ConexionBD.Conexion().getInstance();
                cupones = conection.selectReturnMultiplyRowsByQuery(query);
                grid.DataSource = cupones;

                if (grid.ColumnCount == 8)
                {
                    DataGridViewButtonColumn colEditar = new DataGridViewButtonColumn();
                    colEditar.UseColumnTextForButtonValue = true;
                    colEditar.Text = "Notificar consumición";
                    colEditar.Name = "";
                    grid.Columns.Add(colEditar);
                }
                
                if (cupones.Rows.Count == 0)
                {
                    MessageBox.Show("No hay cupones que mostrar");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar cupones");
            }
            
        }
    }
}
