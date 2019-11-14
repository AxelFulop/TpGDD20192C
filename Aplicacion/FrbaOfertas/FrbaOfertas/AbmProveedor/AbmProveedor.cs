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

            DataGridViewButtonColumn colEditar = new DataGridViewButtonColumn();
            colEditar.UseColumnTextForButtonValue = true;
            colEditar.Text = "Editar";
            colEditar.Name = "";
            grid.Columns.Add(colEditar);

            DataGridViewButtonColumn colEliminar = new DataGridViewButtonColumn();
            colEliminar.UseColumnTextForButtonValue = true;
            colEliminar.Text = "Eliminar";
            colEliminar.Name = "";
            grid.Columns.Add(colEliminar);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.RowIndex < grid.Rows.Count - 1)
            {
                if (e.ColumnIndex == 0) //Editar
                {
                    DataRow row = (grid.CurrentRow.DataBoundItem as DataRowView).Row;
                    Dictionary<string, string> datos = ajustarDatosRow(row);
                    this.Hide();
                    new Editar(datos).Show();
                }
                else if (e.ColumnIndex == 1) //Eliminar
                {
                    DataRow row = (grid.CurrentRow.DataBoundItem as DataRowView).Row;
                    Dictionary<string, string> datos = ajustarDatosRow(row);
                    DialogResult result = MessageBox.Show("¿Desea eliminar el proveedor '" + datos["razonSocial"] + "'?",
                    "",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            eliminar(datos);
                            this.Refresh();
                            MessageBox.Show("Proveedor eliminado correctamente", "",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error al eliminar el proveedor", "",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
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

        private Dictionary<string, string> ajustarDatosRow(DataRow row)
        {
            Dictionary<string, string> datosRow = new Dictionary<string, string>();

            datosRow["razonSocial"] = row.ItemArray[0].ToString();
            datosRow["mail"] = row.ItemArray[1].ToString();
            datosRow["telefono"] = row.ItemArray[2].ToString();
            datosRow["direccion"] = row.ItemArray[3].ToString();
            datosRow["codigoPostal"] = row.ItemArray[4].ToString();
            datosRow["cuit"] = row.ItemArray[5].ToString();
            datosRow["rubro"] = row.ItemArray[6].ToString();
            datosRow["contacto"] = "";//row.ItemArray[7].ToString();

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
