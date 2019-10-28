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
            cargarFuncionalidadesAAgregar();
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

        private void cargarFuncionalidadesAAgregar()
        {
            string query = "select funcionalidad_descripcion from " + Properties.Settings.Default.Schema + ".Funcionalidad";

            ConexionBD.Conexion conection = new ConexionBD.Conexion().getInstance();
            List<Object> funcionalidades = conection.executeAdvancedSelectQuery(query);

            funcionalidades.ForEach(f =>
            {
                if (!func_rol.Items.Contains(f.ToString()))
                    func_a_agregar.Items.Add(f.ToString());
            });

            if (func_a_agregar.Items.Count == 0)
                func_a_agregar.Items.Add("...");
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
                DialogResult result = MessageBox.Show("¿Desea eliminar la funcionalidad '" + 
                    func_rol.SelectedItem.ToString() + "' para el rol '" + this.rol + "'?", 
                    "Borrar funcionalidad", 
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    eliminarFuncionalidad(func_rol.SelectedItem.ToString());
                }
            }
        }

        private void eliminarFuncionalidad(string funcionalidad)
        {
            //Eliminar la funcionalidad para el rol
            //Llamar a un stored procedure
        }

        private void func_a_agregar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(func_a_agregar.SelectedItem != null && func_a_agregar.SelectedItem.ToString() != "..."){
                //Agregar la funcionalidad para el rol
                //Llamar a un stored procedure
            }
        }
    }
}
