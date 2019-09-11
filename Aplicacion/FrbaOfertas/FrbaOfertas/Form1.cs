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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ingresar_btn_Click(object sender, EventArgs e)
        {
            string username = user.Text;
            string pass = password.Text;

            //Chequear si existe
            bool isValidated = username == "antonio" && pass == "1234";

            if (isValidated)
            {
                this.Hide();
                new AbmCliente.Form1().Show();
            }
            else
            {
                error_message.Visible = true;
            }
        }
    }
}
