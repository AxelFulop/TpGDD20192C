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
            dateTimePickerFechaPub.Format = DateTimePickerFormat.Custom;
            dateTimePickerFechVenc.Format = DateTimePickerFormat.Custom;
            dateTimePickerFechaPub.CustomFormat = "yyyy-MM-dd";
            dateTimePickerFechVenc.CustomFormat = "yyyy-MM-dd";
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
            Object ret =  new Conexion().executeScalarFunction("obtenerRazonSocialProveedor",Logeo.username);
            if (ret == DBNull.Value)
                return "";
            else
                return ret.ToString();
        }

        private string obtenerCuit()
        {
            Object ret = new Conexion().executeScalarFunction("obtenerCuitProveedor", Logeo.username);
            if (ret == DBNull.Value)
                return "";
            else
                return ret.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            

        }


        private void buttonGen_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MenuPrincipal().Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new MenuPrincipal().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dateTimePickerFechaPub.Value.CompareTo(Properties.Settings.Default.fecha) <= 0)
            {
                MessageBox.Show("La fecha de debe ser porterior o igual a fecha actual('" +
                    Properties.Settings.Default.fecha.ToShortDateString() + "')");
                return;
            }
            if (dateTimePickerFechaPub.Value.CompareTo(dateTimePickerFechVenc.Value) >= 0)
            {
                MessageBox.Show("La fecha de vencimiento debe ser posterior a la fecha de publicación");
                return;
            }

            if(textBoxCodOferta.Text == ""){
                MessageBox.Show("El código de la oferta no puede estar vacío");
                return;
            }

            if (razonSocial.Text == "" || cuit.Text == "")
            {
                MessageBox.Show("Los datos del proveedor no pueden estar vacios");
                return;
            }

            List<string> values = new List<string>(){
               "@descripcionOferta",
               "@codigoOferta",
               "@fechaPublicacionOferta",
               "@fechaVencimientoOferta",
               "@limiteCompraOferta",
               "@stockDisponibleOferta",
               "@precioOferta",
               "@precioListaOferta",
               "@proveedorRazonSocial",
               "@proveedorCuit"
            };
            Object[] parametros = new Object[]{
              richTextBoxDesc.Text,
              textBoxCodOferta.Text,
              dateTimePickerFechaPub.Value + new TimeSpan(0, 0, 0),
              dateTimePickerFechVenc.Value + new TimeSpan(23, 59, 59),
              numericUpDownLimCom.Value,
              numericUpDownCantDisp.Value,
              precioOferta.Text,
              precioLista.Text,
              razonSocial.Text,
              cuit.Text
           };

            try
            {
                string schema = Properties.Settings.Default.Schema;
                new Conexion().executeProcedure(schema + ".altaOferta", values, parametros);
                MessageBox.Show("oferta de codigo " + textBoxCodOferta.Text + " confeccionada");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonGen_Click_1(object sender, EventArgs e)
        {
            string str = new Util().RandomString(10,false);
            int num = new Util().RandomNumber(1, 9);
            string codOferta = str + num.ToString();
            textBoxCodOferta.Text = codOferta;
            buttonGen.Enabled = false;
        }
    }
}
