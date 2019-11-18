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
        private static List<string> rolesBorradosLogicamente = new List<string>();

        public AbmRol()
        {
            InitializeComponent();
            cargarRoles();
        }

        public AbmRol(List<string> roles)
        {
            InitializeComponent();
            rolesBorradosLogicamente.AddRange(roles);
            cargarRoles();
        }

        private void cargarRoles()
        {
            string query = "select rol_nombre from " + Properties.Settings.Default.Schema + ".Rol ";

            for (int i = 0; i < rolesBorradosLogicamente.Count; i++)
            {
                if(i == 0)
                    query += "where rol_nombre <> '" + rolesBorradosLogicamente.ElementAt(i) + "'";
                else
                    query += " and rol_nombre <> '" + rolesBorradosLogicamente.ElementAt(i) + "'";
            }

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MenuPrincipal().Show();
        }

        private void AbmRol_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }
    }
}
