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
        public AbmProveedor()
        {
            InitializeComponent();
            agregarFila("PLL", "antonny@gmail.com", "12368854", "Calle falsa 123",
                    "1423", "44234234579", "Gastronomia", "Pepe");
        }

        private void agregarFila(string razonSocial, string mail, string telefono, string direccion,
                                string CP, string cuil, string rubro, string contacto)
        {
            grid.Rows.Add(razonSocial, mail, telefono, direccion, CP, cuil, rubro, contacto, "Editar");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            razonSocial.Text = "";
            cuit.Text = "";
            mail.Text = "";
        }
    }
}
