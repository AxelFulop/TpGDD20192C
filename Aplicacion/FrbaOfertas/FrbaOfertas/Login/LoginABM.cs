using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaOfertas.ConexionBD;
using FrbaOfertas.Utils;


namespace FrbaOfertas.Login
{
    public partial class LoginABM : Form
    {
        int contIntentosFallidos;
        int tiempoBloqueo;
        Util utils = new Util();

        public LoginABM(int tiempoBloqueo, int contIntentosFallidos)
        {
            InitializeComponent();
            this.contIntentosFallidos = contIntentosFallidos;
            this.tiempoBloqueo = tiempoBloqueo;
        
        }

        private void LoginABM_Load(object sender, EventArgs e)
        {

        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
           utils.getInstance().ClearTextBoxes(this.Controls);
        }


        private void buttonIngesar_Click(object sender, EventArgs e)
        {

            
        }

             private void buttonSalir_Click(object sender, EventArgs e)
             {
                 this.Close();
             }

             private void label1_Click(object sender, EventArgs e)
             {

             }

             private void label4_Click(object sender, EventArgs e)
             {

             }

            
            
        
    }

 }

