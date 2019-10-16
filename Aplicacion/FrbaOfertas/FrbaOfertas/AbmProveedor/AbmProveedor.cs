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
        private List<DataGridViewRow> clientes = new List<DataGridViewRow>();

        public AbmProveedor()
        {
            InitializeComponent();
            cargarProveedores();
            actualizarListaClientes();
        }

        private void actualizarListaClientes()
        {
            for(int i = 0; i < grid.Rows.Count; i++){
                clientes.Add(grid.Rows[i]);
            }
        }

        private void cargarProveedores()
        {
            agregarFila("PLL", "plack@gmail.com", "12368854", "Electrón 123",
                    "1423", "44234234579", "Electrónica", "Marcelo");
            agregarFila("CPA", "blabla@gmail.com", "12368854", "Calle falsa 123",
                    "1123", "44234234579", "Gastronomia", "Ignacio");
        }

        private void agregarFila(string razonSocial, string mail, string telefono, string direccion,
                                string CP, string cuil, string rubro, string contacto)
        {
            grid.Rows.Add(razonSocial, mail, telefono, direccion, CP, cuil, rubro, contacto, "Editar", "Eliminar");
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

            grid.Rows.Clear();
            List<DataGridViewRow> clienesSinLineaFinalVacia = new List<DataGridViewRow>();
            clienesSinLineaFinalVacia.AddRange(clientes);
            clienesSinLineaFinalVacia.RemoveAt(clientes.Count-1);
            grid.Rows.AddRange(clienesSinLineaFinalVacia.ToArray());
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

            List<DataGridViewRow> rowsFiltered = new List<DataGridViewRow>();

            for(int i = 0; i < this.clientes.Count - 1; i++){
                DataGridViewRow row = this.clientes[i];
                String razonCell = row.Cells["RazonColumn"].Value.ToString();
                String mailCell = row.Cells["MailColumn"].Value.ToString();
                String cuitCell = row.Cells["CuitColumn"].Value.ToString();

                bool condicionRazonSocial = string.IsNullOrEmpty(razonSocial) || razonCell.Equals(razonSocial);
                bool condicionCuit = string.IsNullOrEmpty(cuit) || cuitCell.Equals(cuit);
                bool condicionMail = string.IsNullOrEmpty(mail) || mailCell.Equals(mail);

                if (condicionCuit && condicionMail && condicionRazonSocial)
                {
                    rowsFiltered.Add(row);
                }
            }

            grid.Rows.Clear();
            grid.Rows.AddRange(rowsFiltered.ToArray());
        }
    }
}
