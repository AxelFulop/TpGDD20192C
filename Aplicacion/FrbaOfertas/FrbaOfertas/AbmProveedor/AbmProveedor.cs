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
            ConexionBD.Conexion conection = new ConexionBD.Conexion().getInstance();
            string[] param = new string[]{"proveedor_razon_social","proveedor_email","proveedor_telefono","proveedor_direccion","proveedor_direccion_codigo_postal",
                                          "proveedor_cuit","proveedor_rubro"};

            proveedores = conection.selectReturnMultiplyRows("Proveedor", param);
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

            DataView dataView = new DataView(proveedores);
            dataView.RowFilter = string.Format("proveedor_email LIKE '%{0}%' AND " +
                                               "proveedor_razon_social LIKE '%{1}%'",
                                                mail, razonSocial);
            if (cuit != "")
                dataView.RowFilter += string.Format(" AND proveedor_cuit = '%{0}%'", cuit);
            grid.DataSource = dataView; 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MenuPrincipal().Show();
        }
    }
}
