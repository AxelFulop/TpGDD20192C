using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas
{
    public partial class VerFacturas : Form
    {
        private DataTable facturas;
        private const string headMsgFacturacion = "Total facturado: $";

        public VerFacturas()
        {
            InitializeComponent();
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void VerFacturas_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            fechaInicio.Value = Properties.Settings.Default.fecha;
            FechaFin.Value = Properties.Settings.Default.fecha.AddMonths(1);

            razonSocial.Text = this.obtenerRazonSocial();
            cuit.Text = obtenerCuit();
            if (razonSocial.Text != "" && cuit.Text != "")
            { //Si no lo confecciona un admin
                razonSocial.Enabled = false;
                cuit.Enabled = false;
            }
        }

        private string obtenerRazonSocial()
        {
            Object ret = new ConexionBD.Conexion().executeScalarFunction("obtenerRazonSocialProveedor", Logeo.username);
            if (ret == DBNull.Value)
                return "";
            else
                return ret.ToString();
        }

        private string obtenerCuit()
        {
            Object ret = new ConexionBD.Conexion().executeScalarFunction("obtenerCuitProveedor", Logeo.username);
            if (ret == DBNull.Value)
                return "";
            else
                return ret.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cuit.Text == "" || razonSocial.Text == "")
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            if (fechaInicio.Value.CompareTo(FechaFin.Value) > 0)
            {
                MessageBox.Show("La fecha final no puede ser menor a la inicial");
                return;
            }

            string idProv = new ConexionBD.Conexion().
                executeScalarFunction("obtenerIdProveedorPorCuitYRs", cuit.Text, razonSocial.Text).ToString();
            if (idProv == "")
            {
                MessageBox.Show("Proveedor inexistente");
                return;
            }

            string query = "SELECT factura_numero, factura_fecha, factura_monto_total " +
                        "FROM " + Properties.Settings.Default.Schema + ".Factura "+ 
                        "where proveedor_id = " + idProv + " and " +
                        "factura_fecha between '" + fechaInicio.Value.ToShortDateString() 
                        + "' and '" + FechaFin.Value.ToShortDateString() + "'";

            ConexionBD.Conexion conection = new ConexionBD.Conexion().getInstance();
            facturas = conection.selectReturnMultiplyRowsByQuery(query);
            grid.DataSource = facturas;

            if (facturas.Rows.Count <= 0)
            {
                MessageBox.Show("No hay facturas para ese proveedor en ese intervalo");
                return;
            }
            else
            {
                Object total = new ConexionBD.Conexion().getInstance().executeScalarFunction("totalFacturacionProveedor",
                    idProv.ToString(), fechaInicio.Value.ToShortDateString(), FechaFin.Value.ToShortDateString());
                msgFacturacion.Text = headMsgFacturacion + total.ToString();
            }
        }
    }
}
