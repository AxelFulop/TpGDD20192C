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

            bool result = ejecutarTransaccion();
            
            if (result)
            {
                MessageBox.Show("Rol '" + this.nombreRol.Text + "' creado correctamente");
                this.Hide();
                new AbmRol().Show();
            }
            else
            {
                MessageBox.Show("Error al crear el rol '" + this.nombreRol.Text + "'");
            }
        }

        private bool ejecutarTransaccion()
        {
            ConexionBD.Conexion conection = new ConexionBD.Conexion().getInstance();

            Tuple<string, List<string>, Object[]> procAltaRol = obtenerProcAltaRol();
            Tuple<string, List<string>, Object[]>[] procFuncs = obtenerProcAgregarFuncionalidades();
            procFuncs[0] = procAltaRol;

            try
            {
                conection.executeStoredTransaction(procFuncs);
            }
            catch (System.Data.SqlClient.SqlException)
            {
                return false;
            }

            return true;
        }

        private Tuple<string, List<string>, Object[]> obtenerProcAltaRol()
        {
            return new Tuple<string, List<string>, Object[]>(
                        Properties.Settings.Default.Schema + ".altaRol",
                         new List<String>()
                        {
                            "@nombreRol"
                        },
                        new String[1]
                        {
                            this.nombreRol.Text
                        }
                    );
        }

        private Tuple<string, List<string>, Object[]>[] obtenerProcAgregarFuncionalidades()
        {
            Tuple<string, List<string>, Object[]>[] procs = new Tuple<string, List<string>, Object[]>[func_rol.Items.Count + 1];

            int cont = 1;
            foreach (string func in func_rol.Items)
            {
                procs[cont] = new Tuple<string, List<string>, Object[]>(
                                Properties.Settings.Default.Schema + ".agregarFuncionalidadARol",
                                new List<String>()
                                {
                                    "@nombreRol", "@descripcionFuncionalidad"
                                },
                                new String[2]{
                                    this.nombreRol.Text, func
                                }
                            );
                cont++;
            }

            return procs;
        }   
    }
}
