using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.AbmRol
{
    public partial class AbmRol : Form
    {
        public AbmRol()
        {
            InitializeComponent();
            cargarRoles();
        }

        private void cargarRoles()
        {
            string query = "select rol_nombre from " + Properties.Settings.Default.Schema + ".Rol";

            ConexionBD.Conexion conection = new ConexionBD.Conexion().getInstance();
            List<Object> funcionalidades = conection.executeAdvancedSelectQuery(query);

            if (funcionalidades.Count > 0)
                roles.Items.Clear();

            funcionalidades.ForEach(f =>
            {
                roles.Items.Add(f.ToString());
            });
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (roles.SelectedItem != null && roles.SelectedItem.ToString() != "Sin roles...")
            {
                this.Hide();
                new Editar(roles.SelectedItem.ToString()).Show();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new Nuevo().Show();
        }
    }
}
