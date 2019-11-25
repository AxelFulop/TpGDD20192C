using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.ListadoEstadistico
{
    public partial class listDescuento : Form
    {
        private DataTable proveedores;

        public listDescuento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ListadoEstadistico.Form1().Show();
        }

        private void listDescuento_Load(object sender, EventArgs e)
        {
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            year.Value = Properties.Settings.Default.fecha.Year;
            semestre.SelectedItem = "Primero";

            string query = "SELECT top 5 p.proveedor_cuit, p.proveedor_razon_social," +
                "avg(100-o.oferta_precio*100/o.oferta_precio_lista) as Porcentaje_Descuento_Promedio," +
                "count(o.oferta_codigo) as Cantidad_ofertas " +
                "FROM " + Properties.Settings.Default.Schema + ".Proveedor p " +
                "inner join " + Properties.Settings.Default.Schema + ".Oferta o on p.proveedor_id = o.proveedor_id " +
                "where (o.oferta_fecha_publicacion between '" + new DateTime(int.Parse(year.Value.ToString()), 1, 1).ToShortDateString() + "' and '" +
                 new DateTime(int.Parse(year.Value.ToString()), 7, 1).ToShortDateString() + "') " +
                "group by p.proveedor_cuit, p.proveedor_razon_social " +
                "order by Porcentaje_Descuento_Promedio desc";

            ConexionBD.Conexion conection = new ConexionBD.Conexion().getInstance();
            proveedores = conection.selectReturnMultiplyRowsByQuery(query);
            grid.DataSource = proveedores;

            if (proveedores.Rows.Count == 0)
                vacioMsg.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vacioMsg.Visible = false;
            string fechaInicio, fechaFin;
            if (semestre.SelectedItem == "Primero")
            {
                fechaInicio = new DateTime(int.Parse(year.Value.ToString()), 1, 1).ToShortDateString();
                fechaFin = new DateTime(int.Parse(year.Value.ToString()), 7, 1).ToShortDateString();
            }
            else if (semestre.SelectedItem == "Segundo")
            {
                fechaInicio = new DateTime(int.Parse(year.Value.ToString()), 7, 1).ToShortDateString();
                fechaFin = new DateTime(int.Parse((year.Value + 1).ToString()), 1, 1).ToShortDateString();
            }
            else
            {
                MessageBox.Show("Semestre inválido");
                return;
            }

            string query = "SELECT top 5 p.proveedor_cuit, p.proveedor_razon_social," +
                "avg(100-o.oferta_precio*100/o.oferta_precio_lista) as Porcentaje_Descuento_Promedio," +
                "count(o.oferta_codigo) as Cantidad_ofertas " +
                "FROM " + Properties.Settings.Default.Schema + ".Proveedor p " +
                "inner join " + Properties.Settings.Default.Schema + ".Oferta o on p.proveedor_id = o.proveedor_id " +
                "where (o.oferta_fecha_publicacion between '" + fechaInicio + "' and '" +
                 fechaFin + "') " +
                "group by p.proveedor_cuit, p.proveedor_razon_social " +
                "order by Porcentaje_Descuento_Promedio desc";

            ConexionBD.Conexion conection = new ConexionBD.Conexion().getInstance();
            proveedores = conection.selectReturnMultiplyRowsByQuery(query);
            grid.DataSource = proveedores;

            if (proveedores.Rows.Count == 0)
                vacioMsg.Visible = true;
        }
    }
}
