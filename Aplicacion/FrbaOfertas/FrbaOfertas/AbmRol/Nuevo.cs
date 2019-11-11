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
            new AbmRol(new List<string>()).Show();
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
                
            bool resultadoRol = CrearRol();
            bool resultadoFuncs = agregarFuncionalidades();
            if (resultadoRol && resultadoFuncs)
            {
                MessageBox.Show("Rol '" + this.nombreRol.Text + "' creado correctamente");
                this.CancelBtn.PerformClick();
            }
            else
            {
                MessageBox.Show("Error al crear el rol '" + this.nombreRol.Text + "'");
            }
        }

        private bool CrearRol()
        {
            try
            {
                ConexionBD.Conexion conection = new ConexionBD.Conexion().getInstance();
                conection.executeProcedure(Properties.Settings.Default.Schema + ".altaRol",
                    new List<String>()
                    {
                        "@nombreRol"
                    },
                    new String[1]
                    {
                        this.nombreRol.Text
                    }
                );

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool agregarFuncionalidades()
        {
            try
            {
                foreach (string func in func_rol.Items)
                {
                    ConexionBD.Conexion conection = new ConexionBD.Conexion().getInstance();
                    conection.executeProcedure(Properties.Settings.Default.Schema + ".agregarFuncionalidadARol",
                        new List<String>()
                        {
                            "@nombreRol", "@descripcionFuncionalidad"
                        },
                        new String[2]{
                            this.nombreRol.Text, func
                        });
                }
                
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
