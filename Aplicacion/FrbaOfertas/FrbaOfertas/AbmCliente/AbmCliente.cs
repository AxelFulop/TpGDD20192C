using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.AbmCliente
{
    public partial class AbmCliente : Form
    {
        public AbmCliente()
        {
            InitializeComponent();
            agregarFila("Sanchez", "Roberto", "25323666", "antonny@gmail.com", "155467543", "Calle falsa 123",
                    "1423", "23/03/1993");
        }

        private void agregarFila(string apellido, string nombre, string dni, string mail,
                                string telefono, string direccion, string CP, string fechaNac)
        {
            grid.Rows.Add(apellido, nombre, dni, mail, telefono, direccion, CP, fechaNac, "Editar");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            nombre.Text = "";
            apellido.Text = "";
            dni.Text = "";
            mail.Text = "";
        }
    }
}
