using FrbaOfertas.ConexionBD;
using FrbaOfertas.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.CrearOferta
{
    public partial class ConfeccionarOferta : Form
    {
        public ConfeccionarOferta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MenuPrincipal().Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            textBoxProovedor.Text = this.obtenerUsername();
            textBoxProovedor.Enabled = false;
           
        }

        private string obtenerUsername()
        {
            return (string) new Conexion().executeScalarFunction("obtenerRazonSocialProveedor",Logeo.username);
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            List<string> values = new List<string>(){
               "@descripcionOferta",
               "@codigoOferta",
               "@fechaPublicacionOferta",
               "@fechaVencimientoOferta",
               "@limiteCompraOferta",
               "@stockDisponibleOferta",
               "@precioOferta",
               "@precioListaOferta",
               "@proveedorRazonSocial"
            };
            Object[] parametros = new Object[]{
              richTextBoxDesc.Text,
              textBoxCodOferta.Text,
              dateTimePickerFechaPub.Value,
              dateTimePickerFechVenc.Value,
              numericUpDownLimCom.Value,
              numericUpDownCantDisp.Value,
              textBoxPrecOfer.Text,
              textBoxPrecioLista.Text,
              textBoxProovedor.Text
              
           };

            try
            {
                string schema = Properties.Settings.Default.Schema;
                new Conexion().executeProcedure(schema + ".altaOferta", values, parametros);
                MessageBox.Show("oferta de codigo " + textBoxCodOferta.Text + " confeccionada");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }


        private void buttonGen_Click(object sender, EventArgs e)
        {
            string str = new Util().RandomString(5, true);
            int num = new Util().RandomNumber(100, 999);
            string codOferta = num.ToString() + str;
            textBoxCodOferta.Text = codOferta;
        }
    }
}
