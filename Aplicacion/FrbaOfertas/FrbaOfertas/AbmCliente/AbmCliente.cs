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
        private DataTable clientes;

        public AbmCliente()
        {
            InitializeComponent();
            cargarClientes();
        }

        private void cargarClientes(){
            string query = "SELECT cliente_nombre, cliente_apellido, cliente_numero_dni, cliente_email, cliente_telefono, " +
                                  "cliente_direccion, cliente_codigo_postal, cliente_fecha_nacimiento" +
                           " FROM " + Properties.Settings.Default.Schema + ".Cliente";

            ConexionBD.Conexion conection = new ConexionBD.Conexion().getInstance();
            clientes = conection.selectReturnMultiplyRowsByQuery(query);
            grid.DataSource = clientes; 
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

            string query = "SELECT cliente_nombre, cliente_apellido,cliente_numero_dni,cliente_email,cliente_telefono," +
                                  "cliente_direccion,cliente_codigo_postal,cliente_fecha_nacimiento" +
                           " FROM " + Properties.Settings.Default.Schema + ".Cliente";

            ConexionBD.Conexion conection = new ConexionBD.Conexion().getInstance();
            clientes = conection.selectReturnMultiplyRowsByQuery(query);
            grid.DataSource = clientes;
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

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = this.nombre.Text;
            string apellido = this.apellido.Text;
            string mail = this.mail.Text;
            string dni = this.dni.Text;

            string query = "SELECT cliente_nombre, cliente_apellido,cliente_numero_dni,cliente_email,cliente_telefono," + 
                                  "cliente_direccion,cliente_codigo_postal,cliente_fecha_nacimiento" +
                           " FROM " + Properties.Settings.Default.Schema + ".Cliente WHERE " + 
                           "cliente_nombre LIKE '%" + nombre + "%' AND cliente_apellido LIKE '%" + apellido + "%' AND " + 
                           "cliente_email LIKE '%" + mail + "%'";
            if (dni != "")
                query += " AND cliente_numero_dni=" + dni;

            ConexionBD.Conexion conection = new ConexionBD.Conexion().getInstance();
            clientes = conection.selectReturnMultiplyRowsByQuery(query);
            grid.DataSource = clientes;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MenuPrincipal().Show();
        }
    }
}
