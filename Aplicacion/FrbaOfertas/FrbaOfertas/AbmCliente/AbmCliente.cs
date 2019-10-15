using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.AbmCliente
{
    public partial class AbmCliente : Form
    {
        public AbmCliente()
        {
            InitializeComponent();
            cargarClientes();
        }

        private void cargarClientes(){
            //Obtenerlos de la DB
            agregarFila("Sanchez", "Roberto", "25323666", "robertito@gmail.com", "153546843", "Calle falsa 123",
                    "1413", "23/03/1993");
            agregarFila("Bravo", "Mario", "30398766", "mario@gmail.com", "155464543", "Mario Bravo 123",
                    "1423", "14/09/1983");
        }

        private void agregarFila(string apellido, string nombre, string dni, string mail,
                                string telefono, string direccion, string CP, string fechaNac)
        {
            grid.Rows.Add(apellido, nombre, dni, mail, telefono, direccion, CP, fechaNac, "Editar", "Eliminar");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            //Eliminar cliente de la DB
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nombre.Text = "";
            apellido.Text = "";
            dni.Text = "";
            mail.Text = "";
        }

        private Dictionary<string, string> ajustarDatosRow(DataGridViewCellCollection row)
        {
            Dictionary<string, string> datosRow = new Dictionary<string, string>();

            datosRow["nombre"] =  row["NombreColumn"].Value.ToString();
            datosRow["apellido"] = row["ApellidoColumn"].Value.ToString();
            datosRow["dni"] = row["DniColumn"].Value.ToString();
            datosRow["mail"] = row["MailColumn"].Value.ToString();
            datosRow["telefono"] = row["TelefonoColumn"].Value.ToString();
            datosRow["direccion"] = row["DireccionColumn"].Value.ToString();
            datosRow["codigoPostal"] = row["CPColumn"].Value.ToString();
            datosRow["fechaNacimiento"] = row["FechaNacColumn"].Value.ToString();

            return datosRow;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Nuevo().Show();
        }
    }
}
