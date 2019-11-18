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
        public static List<Tuple<string, string, string>> clientesBorradosLogicamente = new List<Tuple<string, string, string>>();
                                  //Dni - Nombre - Apellido

        public AbmCliente()
        {
            InitializeComponent();
            cargarClientes();
        }

        public AbmCliente(Tuple<string, string, string> clienteAExcluir)
        {
            InitializeComponent();
            clientesBorradosLogicamente.Add(clienteAExcluir);
            cargarClientes();
        }

        private void cargarClientes(){
            string listaDni = obtenerListaBorradosQueryDni();
            string listaNombre = obtenerListaBorradosQueryNombre();
            string listaApellido = obtenerListaBorradosQueryApellido();

            string query = "SELECT cliente_id, cliente_nombre, cliente_apellido, cliente_numero_dni, cliente_email, cliente_telefono, " +
                                  "cliente_direccion,cliente_direccion_piso,cliente_direccion_depto,cliente_direccion_localidad, cliente_codigo_postal, cliente_fecha_nacimiento" +
                           " FROM " + Properties.Settings.Default.Schema + ".Cliente";
            if (listaDni != "()" || listaNombre != "()" || listaApellido != "()")
            {
                query += " WHERE ";
                if (listaDni != "()")
                {
                    query += "cliente_numero_dni NOT IN " + listaDni;
                    if (listaNombre != "()")
                    {
                        query += " AND cliente_nombre NOT IN " + listaNombre;
                    }
                    if (listaApellido != "()")
                    {
                        query += " AND cliente_apellido NOT IN " + listaApellido;
                    }
                }
                else if (listaNombre != "()")
                {
                    query += "cliente_nombre NOT IN " + listaNombre;
                    if (listaApellido != "()")
                    {
                        query += " AND cliente_apellido NOT IN " + listaApellido;
                    }
                }
                else
                {
                    query += "cliente_apellido NOT IN " + listaApellido;
                }
            }

            ConexionBD.Conexion conection = new ConexionBD.Conexion().getInstance();
            clientes = conection.selectReturnMultiplyRowsByQuery(query);
            grid.DataSource = clientes;

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

        private void Form1_Load(object sender, EventArgs e)
        {
            Object estaHabilitado = new ConexionBD.Conexion().executeScalarFunction("rolEstaHabilitado", "Cliente");
            if (estaHabilitado.ToString() == "1") //Si no está habilitado
            {
                button3.Enabled = false;
                msgInhabilitado.Visible = true;
            }
            this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.RowIndex < grid.Rows.Count)
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
                    DialogResult result = MessageBox.Show("¿Desea eliminar el cliente '" + datos["nombre"] + " "
                                    + datos["apellido"] + "'?",
                    "",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            MessageBox.Show("Cliente eliminado correctamente", "",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            Object user_cliente = new ConexionBD.Conexion().executeScalarFunction("obtenerUsuarioCliente", datos["id"]);

                            Logeo.usuariosEliminadosLogicamente.Add(user_cliente.ToString());
                            this.Hide();
                            new AbmCliente(Tuple.Create<string, string, string>(
                                datos["dni"], datos["nombre"], datos["apellido"]
                                )).Show();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error al eliminar el cliente", "",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nombre.Text = "";
            apellido.Text = "";
            dni.Text = "";
            mail.Text = "";

            string listaDni = obtenerListaBorradosQueryDni();
            string listaNombre = obtenerListaBorradosQueryNombre();
            string listaApellido = obtenerListaBorradosQueryApellido();

            string query = "SELECT cliente_id, cliente_nombre, cliente_apellido, cliente_numero_dni, cliente_email, cliente_telefono, " +
                                  "cliente_direccion,cliente_direccion_piso,cliente_direccion_depto,cliente_direccion_localidad, cliente_codigo_postal, cliente_fecha_nacimiento" +
                           " FROM " + Properties.Settings.Default.Schema + ".Cliente";
            if (listaDni != "()" || listaNombre != "()" || listaApellido != "()")
            {
                query += " WHERE ";
                if (listaDni != "()")
                {
                    query += "cliente_numero_dni NOT IN " + listaDni;
                    if (listaNombre != "()")
                    {
                        query += " AND cliente_nombre NOT IN " + listaNombre;
                    }
                    if (listaApellido != "()")
                    {
                        query += " AND cliente_apellido NOT IN " + listaApellido;
                    }
                }
                else if (listaNombre != "()")
                {
                    query += "cliente_nombre NOT IN " + listaNombre;
                    if (listaApellido != "()")
                    {
                        query += " AND cliente_apellido NOT IN " + listaApellido;
                    }
                }
                else
                {
                    query += "cliente_apellido NOT IN " + listaApellido;
                }
            }

            ConexionBD.Conexion conection = new ConexionBD.Conexion().getInstance();
            clientes = conection.selectReturnMultiplyRowsByQuery(query);
            grid.DataSource = clientes;
        }

        private Dictionary<string, string> ajustarDatosRow(DataRow row)
        {
            Dictionary<string, string> datosRow = new Dictionary<string, string>();

            datosRow["id"] = row.ItemArray[0].ToString();
            datosRow["nombre"] = row.ItemArray[1].ToString();
            datosRow["apellido"] = row.ItemArray[2].ToString();
            datosRow["dni"] = row.ItemArray[3].ToString();
            datosRow["mail"] = row.ItemArray[4].ToString();
            datosRow["telefono"] = row.ItemArray[5].ToString();
            datosRow["direccion"] = row.ItemArray[6].ToString();
            datosRow["direccion_piso"] = row.ItemArray[7].ToString();
            datosRow["direccion_depto"] = row.ItemArray[8].ToString();
            datosRow["direccion_localidad"] = row.ItemArray[9].ToString();
            datosRow["codigoPostal"] = row.ItemArray[10].ToString();
            datosRow["fechaNacimiento"] = row.ItemArray[11].ToString();

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

            string listaDni = obtenerListaBorradosQueryDni();
            string listaNombre = obtenerListaBorradosQueryNombre();
            string listaApellido = obtenerListaBorradosQueryApellido();

            string query = "SELECT cliente_id, cliente_nombre, cliente_apellido,cliente_numero_dni,cliente_email,cliente_telefono," +
                                  "cliente_direccion,cliente_direccion_piso,cliente_direccion_depto,cliente_direccion_localidad,cliente_codigo_postal,cliente_fecha_nacimiento" +
                           " FROM " + Properties.Settings.Default.Schema + ".Cliente WHERE " + 
                           "cliente_nombre LIKE '%" + nombre + "%' AND cliente_apellido LIKE '%" + apellido + "%' AND " + 
                           "cliente_email LIKE '%" + mail + "%'";
            if (dni != "")
                query += " AND cliente_numero_dni=" + dni;

            if (listaDni != "()" || listaNombre != "()" || listaApellido != "()")
            {
                if (listaDni != "()")
                {
                    query += " AND cliente_numero_dni NOT IN " + listaDni;
                    if (listaNombre != "()")
                    {
                        query += " AND cliente_nombre NOT IN " + listaNombre;
                    }
                    if (listaApellido != "()")
                    {
                        query += " AND cliente_apellido NOT IN " + listaApellido;
                    }
                }
                else if (listaNombre != "()")
                {
                    query += " AND cliente_nombre NOT IN " + listaNombre;
                    if (listaApellido != "()")
                    {
                        query += " AND cliente_apellido NOT IN " + listaApellido;
                    }
                }
                else
                {
                    query += " AND cliente_apellido NOT IN " + listaApellido;
                }
            }

            ConexionBD.Conexion conection = new ConexionBD.Conexion().getInstance();
            clientes = conection.selectReturnMultiplyRowsByQuery(query);
            grid.DataSource = clientes;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MenuPrincipal().Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private string obtenerListaBorradosQueryDni()
        {
            string lista = "(";
            clientesBorradosLogicamente.ForEach(p =>
            {
                lista += "'" + p.Item1 + "',";
            });
            lista = lista.TrimEnd(',');
            lista += ")";
            return lista;
        }

        private string obtenerListaBorradosQueryNombre()
        {
            string lista = "(";
            clientesBorradosLogicamente.ForEach(p =>
            {
                lista += "'" + p.Item2 + "',";
            });
            lista = lista.TrimEnd(',');
            lista += ")";
            return lista;
        }

        private string obtenerListaBorradosQueryApellido()
        {
            string lista = "(";
            clientesBorradosLogicamente.ForEach(p =>
            {
                lista += "'" + p.Item3 + "',";
            });
            lista = lista.TrimEnd(',');
            lista += ")";
            return lista;
        }
    }
}
