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
            seleccionarBotonHabilitacion();
            cargarRol(rol);
            cargarFuncionalidadesAAgregar();
        }

        private void seleccionarBotonHabilitacion()
        {
            ConexionBD.Conexion conection = new ConexionBD.Conexion().getInstance();
            Object habilitado = conection.executeScalarFunction("rolEstaHabilitado", this.rol);

            if (Convert.ToInt32(habilitado) == 1)
            {
                this.btn_inhabilitar.Visible = true;
            }
            else
            {
                this.btn_habilitar.Visible = true;
            }
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
                    "Eliminar funcionalidad", 
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    eliminarFuncionalidad(func_rol.SelectedItem.ToString());
                    this.Hide();
                    new Editar(this.rol).Show();
                }
            }
        }

        private void eliminarFuncionalidad(string funcionalidad)
        {
            try
            {
                ConexionBD.Conexion conection = new ConexionBD.Conexion().getInstance();
                conection.executeProcedure(Properties.Settings.Default.Schema + ".eliminarFuncionalidadARol",
                    new List<String>()
                {
                    "@nombreRol", "@descripcionFuncionalidad"
                },
                    new String[2]{
                    this.rol, funcionalidad
                });

                MessageBox.Show("Funcionalidad " + funcionalidad + " eliminada correctamente para '" + this.rol + "'");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar la funcionalidad " + funcionalidad);
            }
        }

        private void func_a_agregar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(func_a_agregar.SelectedItem != null && func_a_agregar.SelectedItem.ToString() != "..."){
                bool resultadoRol = agregarFuncionalidad(func_a_agregar.SelectedItem.ToString());
                if (resultadoRol)
                {
                    MessageBox.Show("Funcionalidad '" + func_a_agregar.SelectedItem.ToString() + "' agregada correctamente para el rol '" + this.rol + "'");
                }
                else
                {
                    MessageBox.Show("Error al agregar la funcionalidad '" + func_a_agregar.SelectedItem.ToString() + "' al rol '" + this.rol + "'");
                }

                this.Hide();
                new Editar(this.rol).Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea eliminar el rol '" + this.rol + "'?",
                    "Eliminar rol",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Rol '" + this.rol + "' eliminado correctamente");
                this.Hide();
                new AbmRol(new List<string>() { this.rol }).Show();
            }
        }

        private bool agregarFuncionalidad(string func)
        {
            try
            {
                ConexionBD.Conexion conection = new ConexionBD.Conexion().getInstance();
                conection.executeProcedure(Properties.Settings.Default.Schema + ".agregarFuncionalidadARol",
                    new List<String>()
                {
                    "@nombreRol", "@descripcionFuncionalidad"
                },
                    new String[2]{
                    this.rol, func
                });

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                ConexionBD.Conexion conection = new ConexionBD.Conexion().getInstance();
                conection.executeProcedure(Properties.Settings.Default.Schema + ".inhabilitarRol",
                    new List<String>()
                    {
                        "@nombreRol"
                    },
                    new String[]{
                        this.rol
                    }
                );

                MessageBox.Show("Rol '" + this.rol + "' inhabilitado correctamente");
                this.Hide();
                new Editar(this.rol).Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al inhabilitar el rol '" + this.rol + "'");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                ConexionBD.Conexion conection = new ConexionBD.Conexion().getInstance();
                conection.executeProcedure(Properties.Settings.Default.Schema + ".habilitarRol",
                    new List<String>()
                    {
                        "@nombreRol"
                    },
                    new String[]{
                        this.rol
                    }
                );

                MessageBox.Show("Rol '" + this.rol + "' habilitado correctamente");
                this.Hide();
                new Editar(this.rol).Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al habilitar el rol '" + this.rol + "'");
            }
        }
    }
}
