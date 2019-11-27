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
        public static List<Tuple<string, string>> provBorradosLogicamente = new List<Tuple<string, string>>();
                              //RazonSocial - CUIT

        public AbmProveedor()
        {
            InitializeComponent();
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            cargarProveedores();
        }

        public AbmProveedor(Tuple<string, string> provAExcluir)
        {
            InitializeComponent();
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            provBorradosLogicamente.Add(provAExcluir);
            cargarProveedores();
        }

        private void cargarProveedores()
        {
            string listaRazonSocial = obtenerListaBorradosQueryRazonSocial();
            string listaCuit = obtenerListaBorradosQueryCuit();

            string query = "SELECT proveedor_id, proveedor_razon_social, proveedor_email, proveedor_telefono, proveedor_direccion," +
                                   "proveedor_direccion_piso,proveedor_direccion_depto,proveedor_direccion_localidad," +
                                  "proveedor_codigo_postal,proveedor_cuit, proveedor_rubro, proveedor_contacto" +
                           " FROM " + Properties.Settings.Default.Schema + ".Proveedor";
            if(listaRazonSocial != "()" || listaCuit != "()")
            {
                query += " WHERE ";
                if (listaRazonSocial != "()")
                {
                    query += "proveedor_razon_social NOT IN " + listaRazonSocial;
                    if (listaCuit != "()")
                    {
                        query += " AND proveedor_cuit NOT IN " + listaCuit;
                    }
                }
                else
                {
                    if (listaCuit != "()")
                    {
                        query += "proveedor_cuit NOT IN " + listaCuit;
                    }
                } 
            }
            
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
                e.RowIndex >= 0 && e.RowIndex < grid.Rows.Count)
            {
                try
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
                                MessageBox.Show("Proveedor eliminado correctamente", "",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                                Object user_prov = new ConexionBD.Conexion().executeScalarFunction("obtenerUsuarioProveedor", datos["id"]);

                                Logeo.usuariosEliminadosLogicamente.Add(user_prov.ToString());
                                this.Hide();
                                new AbmProveedor(Tuple.Create<string, string>(datos["razonSocial"], datos["cuit"])).Show();
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
                catch (Exception) { }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            razonSocial.Text = "";
            cuit.Text = "";
            mail.Text = "";

            string listaRazonSocial = obtenerListaBorradosQueryRazonSocial();
            string listaCuit = obtenerListaBorradosQueryCuit();

            string query = "SELECT proveedor_id, proveedor_razon_social, proveedor_email, proveedor_telefono, proveedor_direccion," +
                                   "proveedor_direccion_piso,proveedor_direccion_depto,proveedor_direccion_localidad," +
                                  "proveedor_codigo_postal,proveedor_cuit, proveedor_rubro, proveedor_contacto" +
                           " FROM " + Properties.Settings.Default.Schema + ".Proveedor";
            if (listaRazonSocial != "()" || listaCuit != "()")
            {
                query += " WHERE ";
                if (listaRazonSocial != "()")
                {
                    query += "proveedor_razon_social NOT IN " + listaRazonSocial;
                    if (listaCuit != "()")
                    {
                        query += " AND proveedor_cuit NOT IN " + listaCuit;
                    }
                }
                else
                {
                    if (listaCuit != "()")
                    {
                        query += "proveedor_cuit NOT IN " + listaCuit;
                    }
                }
            }

            ConexionBD.Conexion conection = new ConexionBD.Conexion().getInstance();
            proveedores = conection.selectReturnMultiplyRowsByQuery(query);
            grid.DataSource = proveedores;
        }

        private Dictionary<string, string> ajustarDatosRow(DataRow row)
        {
            Dictionary<string, string> datosRow = new Dictionary<string, string>();

            datosRow["id"] = row.ItemArray[0].ToString();
            datosRow["razonSocial"] = row.ItemArray[1].ToString();
            datosRow["mail"] = row.ItemArray[2].ToString();
            datosRow["telefono"] = row.ItemArray[3].ToString();
            datosRow["direccion"] = row.ItemArray[4].ToString();
            datosRow["direccion_piso"] = row.ItemArray[5].ToString();
            datosRow["direccion_depto"] = row.ItemArray[6].ToString();
            datosRow["direccion_localidad"] = row.ItemArray[7].ToString();
            datosRow["codigoPostal"] = row.ItemArray[8].ToString();
            datosRow["cuit"] = row.ItemArray[9].ToString();
            datosRow["rubro"] = row.ItemArray[10].ToString();
            datosRow["contacto"] = row.ItemArray[11].ToString();

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

            string listaRazonSocial = obtenerListaBorradosQueryRazonSocial();
            string listaCuit = obtenerListaBorradosQueryCuit();

            string query = "SELECT proveedor_id, proveedor_razon_social, proveedor_email, proveedor_telefono, proveedor_direccion,proveedor_direccion_piso,proveedor_direccion_depto,proveedor_direccion_localidad, proveedor_codigo_postal, " +
                                  "proveedor_cuit, proveedor_rubro, proveedor_contacto" +
                           " FROM " + Properties.Settings.Default.Schema + ".Proveedor WHERE " +
                           "isnull(proveedor_email, '') LIKE '%" + mail + "%' AND proveedor_razon_social LIKE '%" + razonSocial + "%'";
            if (cuit != "")
                query += " AND proveedor_cuit='" + cuit + "'";

            if (listaRazonSocial != "()" || listaCuit != "()")
            {
                if (listaRazonSocial != "()")
                {
                    query += " AND proveedor_razon_social NOT IN " + listaRazonSocial;
                    if (listaCuit != "()")
                    {
                        query += " AND proveedor_cuit NOT IN " + listaCuit;
                    }
                }
                else
                {
                    if (listaCuit != "()")
                    {
                        query += " AND proveedor_cuit NOT IN " + listaCuit;
                    }
                }
            } 

            ConexionBD.Conexion conection = new ConexionBD.Conexion().getInstance();
            proveedores = conection.selectReturnMultiplyRowsByQuery(query);
            grid.DataSource = proveedores;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MenuPrincipal().Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void AbmProveedor_Load(object sender, EventArgs e)
        {
            Object estaHabilitado = new ConexionBD.Conexion().executeScalarFunction("rolEstaHabilitado", "Proveedor");
            if (estaHabilitado.ToString() == "1") //Si no está habilitado
            {
                NuevoProvBtn.Enabled = false;
                msgInhabilitado.Visible = true;
            }
        }

        private string obtenerListaBorradosQueryRazonSocial()
        {
            string lista = "(";
            provBorradosLogicamente.ForEach(p =>
            {
                lista += "'" + p.Item1 + "',";
            });
            lista = lista.TrimEnd(',');
            lista += ")";
            return lista;
        }

        private string obtenerListaBorradosQueryCuit()
        {
            string lista = "(";
            provBorradosLogicamente.ForEach(p =>
            {
                lista += "'" + p.Item2 + "',";
            });
            lista = lista.TrimEnd(',');
            lista += ")";
            return lista;
        }
    }
}
