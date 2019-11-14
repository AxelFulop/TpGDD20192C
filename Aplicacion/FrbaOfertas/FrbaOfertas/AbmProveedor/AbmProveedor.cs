using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.AbmProveedor
{
    public partial class AbmProveedor : Form
    {
        private DataTable proveedores;

        public AbmProveedor()
        {
            InitializeComponent();
            cargarProveedores();
        }

        private void cargarProveedores()
        {
            string query = "SELECT proveedor_razon_social, proveedor_email, proveedor_telefono, proveedor_direccion, proveedor_codigo_postal, " +
                                  "proveedor_cuit, proveedor_rubro" +
                           " FROM " + Properties.Settings.Default.Schema + ".Proveedor";

            ConexionBD.Conexion conection = new ConexionBD.Conexion().getInstance();
            proveedores = conection.selectReturnMultiplyRowsByQuery(query);
            grid.DataSource = proveedores; 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.RowIndex < grid.Rows.Count - 1)
            {
                if (e.ColumnIndex == 8) //Editar
                {
                    Dictionary<string, string> datos = ajustarDatosRow(grid.CurrentRow.Cells);
                    this.Hide();
                    new Editar(datos).Show();
                }
                else if (e.ColumnIndex == 9) //Eliminar
                {
                    Dictionary<string, string> datos = ajustarDatosRow(grid.CurrentRow.Cells);
                    eliminar(datos);
                    this.Refresh();
                }
            }
        }

        private void eliminar(Dictionary<string, string> row)
        {
            //Eliminar proveedor de la DB
        }

        private void button2_Click(object sender, EventArgs e)
        {
            razonSocial.Text = "";
            cuit.Text = "";
            mail.Text = "";

            string query = "SELECT proveedor_razon_social, proveedor_email, proveedor_telefono, proveedor_direccion, proveedor_codigo_postal, " +
                                  "proveedor_cuit, proveedor_rubro" +
                           " FROM " + Properties.Settings.Default.Schema + ".Proveedor";

            ConexionBD.Conexion conection = new ConexionBD.Conexion().getInstance();
            proveedores = conection.selectReturnMultiplyRowsByQuery(query);
            grid.DataSource = proveedores;
        }

        private Dictionary<string, string> ajustarDatosRow(DataGridViewCellCollection row)
        {
            Dictionary<string, string> datosRow = new Dictionary<string, string>();

            datosRow["razonSocial"] = row["RazonColumn"].Value.ToString();
            datosRow["mail"] = row["MailColumn"].Value.ToString();
            datosRow["telefono"] = row["TelefonoColumn"].Value.ToString();
            datosRow["direccion"] = row["DireccionColumn"].Value.ToString();
            datosRow["codigoPostal"] = row["CPColumn"].Value.ToString();
            datosRow["cuit"] = row["CuitColumn"].Value.ToString();
            datosRow["rubro"] = row["RubroColumn"].Value.ToString();
            datosRow["contacto"] = row["ContactoColumn"].Value.ToString();

            return datosRow;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Nuevo().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string razonSocial = this.razonSocial.Text;
            string cuit = this.cuit.Text;
            string mail = this.mail.Text;

            string query = "SELECT proveedor_razon_social, proveedor_email, proveedor_telefono, proveedor_direccion, proveedor_codigo_postal, " +
                                  "proveedor_cuit, proveedor_rubro" +
                           " FROM " + Properties.Settings.Default.Schema + ".Proveedor WHERE " +
                           "isnull(proveedor_email, '') LIKE '%" + mail + "%' AND proveedor_razon_social LIKE '%" + razonSocial + "%'";
            if (cuit != "")
                query += " AND proveedor_cuit='" + cuit + "'";

            ConexionBD.Conexion conection = new ConexionBD.Conexion().getInstance();
            proveedores = conection.selectReturnMultiplyRowsByQuery(query);
            grid.DataSource = proveedores;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MenuPrincipal().Show();
        }
    }
}
