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
    public partial class Nuevo : Form
    {
        public Nuevo()
        {
            InitializeComponent();
            cargarFuncionalidadesAAgregar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AbmRol().Show();
        }

        private void cargarFuncionalidadesAAgregar()
        {
            string query = "select funcionalidad_descripcion from " + Properties.Settings.Default.Schema + ".Funcionalidad";

            ConexionBD.Conexion conection = new ConexionBD.Conexion().getInstance();
            List<Object> funcionalidades = conection.executeAdvancedSelectQuery(query);

            funcionalidades.ForEach(f =>
            {
                func_disp.Items.Add(f.ToString());
            });
        }

        private void func_disp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (func_disp.SelectedItem != null)
            {
                string selected = func_disp.SelectedItem.ToString();
                func_disp.Items.Remove(selected);
                func_rol.Items.Add(selected);
            }
        }

        private void func_rol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (func_rol.SelectedItem != null)
            {
                string selected = func_rol.SelectedItem.ToString();
                func_rol.Items.Remove(selected);
                func_disp.Items.Add(selected);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.nombreRol.Text == "" || func_rol.Items.Count == 0)
            {
                MessageBox.Show("Complete todos los campos por favor");
                return;
            }
                
            bool resultadoRol = CrearRol(this.nombreRol.Text);
            if (resultadoRol)
            {
                MessageBox.Show("Rol '" + this.nombreRol.Text + "' creado correctamente");
                this.CancelBtn.PerformClick();
            }
            else
            {
                MessageBox.Show("Error al crear el rol '" + this.nombreRol.Text + "'");
            }
        }

        private bool CrearRol(string rolName)
        {
            //func_rol.Items; -> funcionalidades a agregar

            //Crear rol con las funcionalidades
            //Llamar a un stored procedure
            return true;
        }
    }
}
