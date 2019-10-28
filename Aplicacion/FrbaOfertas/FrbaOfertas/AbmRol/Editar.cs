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
    public partial class Editar : Form
    {
        private string rol;

        public Editar(string rol)
        {
            InitializeComponent();
            this.rol = rol;
            cargarRol(rol);
        }

        private void cargarRol(string rol)
        {
            this.nombreRol.Text = rol;

            string query = "select f.funcionalidad_descripcion from " + Properties.Settings.Default.Schema + ".Rol r " +
                "inner join " + Properties.Settings.Default.Schema + ".FuncionalidadXRol fxr on fxr.rol_id = r.rol_id " +
                "inner join " + Properties.Settings.Default.Schema + ".Funcionalidad f on f.funcionalidad_id = fxr.funcionalidad_id " +
                "where r.rol_nombre = '" + rol + "'";

            ConexionBD.Conexion conection = new ConexionBD.Conexion().getInstance();
            List<Object> funcionalidades = conection.executeAdvancedSelectQuery(query);
            
            mostrarFuncionalidades(funcionalidades);
        } 

        private void mostrarFuncionalidades(List<Object> funcionalidades)
        {
            if (funcionalidades.Count > 0)
                func_rol.Items.Clear();

            funcionalidades.ForEach(f =>
            {
                func_rol.Items.Add(f.ToString());
            });
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Editar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AbmRol().Show();
        }

        private void func_rol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (func_rol.SelectedItem != null && func_rol.SelectedItem.ToString() != "Sin funcionalidades...")
            {
                DialogResult result = MessageBox.Show(func_rol.SelectedItem.ToString(), "Borrar funcionalidad", 
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    //Borrarla
                }
            }
        }

        private void eliminarFuncionalidad(string funcionalidad)
        {

        }
    }
}
