using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.Facturar
{
    public partial class Form1 : Form
    {
        private DataTable cupones;
        private const string tailMsgCantidad = " compras realizadas";

        public Form1()
        {
            InitializeComponent();
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            fechaInicio.Value = Properties.Settings.Default.fecha;
            FechaFin.Value = Properties.Settings.Default.fecha.AddMonths(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MenuPrincipal().Show();
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

            string query = "SELECT c.compra_fecha, cli.cliente_numero_dni," +
	                "lower(concat(cli.cliente_nombre, ' ', cli.cliente_apellido)) as nom_y_apellido_cliente," +
	                "o.oferta_codigo, o.oferta_descripcion, o.oferta_precio " +
                    "FROM " + Properties.Settings.Default.Schema + ".Compra c " +
                    "inner join " + Properties.Settings.Default.Schema + ".Cliente cli on cli.cliente_id = c.cliente_id " +
                    "inner join " + Properties.Settings.Default.Schema + ".Oferta o on o.oferta_id = c.oferta_id " +
                    "where o.proveedor_id = " + idProv + " AND compra_facturada = '0' " +
                    "AND c.compra_fecha BETWEEN '" + fechaInicio.Value.ToShortDateString() + "' AND '" +
                    FechaFin.Value.ToShortDateString() + "'";


            ConexionBD.Conexion conection = new ConexionBD.Conexion().getInstance();
            cupones = conection.selectReturnMultiplyRowsByQuery(query);
            grid.DataSource = cupones;

            if (cupones.Rows.Count <= 0)
            {
                MessageBox.Show("No hay ofertas compradas para ese proveedor en ese intervalo");
                facturarBtn.Enabled = false;
                return;
            }
            else
            {
                cantComprasMsg.Text = cupones.Rows.Count + tailMsgCantidad;
                facturarBtn.Enabled = true;
            }
        }

        private void facturarBtn_Click(object sender, EventArgs e)
        {
            string idProv = new ConexionBD.Conexion().
                executeScalarFunction("obtenerIdProveedorPorCuitYRs", cuit.Text, razonSocial.Text).ToString();

            string query = "SELECT sum(o.oferta_precio) FROM " + Properties.Settings.Default.Schema + ".Compra c " +
                "inner join " + Properties.Settings.Default.Schema + ".Oferta o on o.oferta_id = c.oferta_id " +
                "where c.compra_facturada = '0' AND o.proveedor_id = " + idProv +
                " AND c.compra_fecha BETWEEN '" + fechaInicio.Value.ToShortDateString() +
                "' AND '" + FechaFin.Value.ToShortDateString() + "'";

            ConexionBD.Conexion conection = new ConexionBD.Conexion().getInstance();
            Object sumaFacturacion = conection.selectReturnOnlyObject(query);

            DialogResult result = MessageBox.Show("¿Desea facturar al proveedor?\nTotal a facturar: $ " + sumaFacturacion.ToString(),
            "Facturación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    new ConexionBD.Conexion().getInstance().executeProcedure(Properties.Settings.Default.Schema + ".facturarProveedor",
                        new List<string>()
                        {
                            "@id_proveedor", "@fecha_inicio", "@fecha_fin",  "@monto"
                        },
                        new Object[]{
                            int.Parse(idProv), fechaInicio.Value, FechaFin.Value,
                            sumaFacturacion
                        }
                    );
                    
                    MessageBox.Show("Facturación completa");
                    this.Hide();
                    new MenuPrincipal().Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al realizar la facturación. \n" + ex.Message);
                }
            }
        }
    }
}
