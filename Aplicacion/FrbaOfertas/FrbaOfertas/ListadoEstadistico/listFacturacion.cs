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
    public partial class listFacturacion : Form
    {
        private DataTable proveedores;

        public listFacturacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ListadoEstadistico.Form1().Show();
        }

        private void listFacturacion_Load(object sender, EventArgs e)
        {
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            year.Value = Properties.Settings.Default.fecha.Year;
            semestre.SelectedItem = "Primero";

            string query = "select top 5 p.proveedor_cuit as Cuit, p.proveedor_razon_social as Razon_social, sum(f.factura_monto_total) as Facturacion," +
	                "avg(f.factura_monto_total) as Promedio_Facturado_Por_Mes " + 
	                "from " + Properties.Settings.Default.Schema + ".Proveedor p " +
	                "inner join " + Properties.Settings.Default.Schema + ".Factura f on f.proveedor_id = p.proveedor_id " +
                    "where (f.factura_fecha between '" + new DateTime(int.Parse(year.Value.ToString()), 1, 1).ToShortDateString() + "' and '" +
                    new DateTime(int.Parse(year.Value.ToString()), 7, 1).ToShortDateString() + "') and year(f.factura_fecha) = " + year.Value.ToString() +
	                " group by p.proveedor_cuit, p.proveedor_razon_social " +
	                "order by sum(f.factura_monto_total) desc";

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
                fechaFin = new DateTime(int.Parse((year.Value+1).ToString()), 1, 1).ToShortDateString();
            }
            else
            {
                MessageBox.Show("Semestre inválido");
                return;
            }
                
            string query = "select top 5 p.proveedor_cuit as Cuit, p.proveedor_razon_social as Razon_social, sum(f.factura_monto_total) as Facturacion," +
                    "avg(f.factura_monto_total) as Promedio_Facturado_Por_Mes " +
                    "from " + Properties.Settings.Default.Schema + ".Proveedor p " +
                    "inner join " + Properties.Settings.Default.Schema + ".Factura f on f.proveedor_id = p.proveedor_id " +
                    "where (f.factura_fecha between '" + fechaInicio + "' and '" +
                    fechaFin + "') and year(f.factura_fecha) = " + year.Value.ToString() +
                    " group by p.proveedor_cuit, p.proveedor_razon_social " +
                    "order by sum(f.factura_monto_total) desc";

            ConexionBD.Conexion conection = new ConexionBD.Conexion().getInstance();
            proveedores = conection.selectReturnMultiplyRowsByQuery(query);
            grid.DataSource = proveedores;

            if (proveedores.Rows.Count == 0)
                vacioMsg.Visible = true;
        }
    }
}
