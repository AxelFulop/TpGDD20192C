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
            cargarRol("Administrador");
            cargarRol("Proveedor");
            cargarRol("Cliente");
        }

        private void cargarRol(string nombreRol)
        {
            string query = "select f.funcionalidad_descripcion from " + Properties.Settings.Default.Schema + ".Rol r " +
                "inner join " + Properties.Settings.Default.Schema + ".FuncionalidadXRol fxr on fxr.rol_id = r.rol_id " +
                "inner join " + Properties.Settings.Default.Schema + ".Funcionalidad f on f.funcionalidad_id = fxr.funcionalidad_id " +
                "where r.rol_nombre = '" + nombreRol + "'";

            ConexionBD.Conexion conection = new ConexionBD.Conexion().getInstance();
            List<Object> funcionalidades = conection.executeAdvancedSelectQuery(query);
            switch (nombreRol)
            {
                case "Administrador":
                    mostrarFuncionalidadesAdmin(funcionalidades);
                    break;
                case "Proveedor":
                    mostrarFuncionalidadesProveedores(funcionalidades);
                    break;
                case "Cliente":
                    mostrarFuncionalidadesCliente(funcionalidades);
                    break;
                default:
                    throw new Exception("Rol inexistente");
            }
        }

        private void mostrarFuncionalidadesAdmin(List<Object> funcionalidades)
        {
            if (funcionalidades.Count > 0)
                func_admin.Items.Clear();

            funcionalidades.ForEach(f =>
            {
                func_admin.Items.Add(f.ToString());
            });
        }

        private void mostrarFuncionalidadesProveedores(List<Object> funcionalidades)
        {
            if (funcionalidades.Count > 0)
                func_proveedor.Items.Clear();

            funcionalidades.ForEach(f =>
            {
                func_proveedor.Items.Add(f.ToString());
            });
        }

        private void mostrarFuncionalidadesCliente(List<Object> funcionalidades)
        {
            if (funcionalidades.Count > 0)
                func_cliente.Items.Clear();

            funcionalidades.ForEach(f =>
            {
                func_cliente.Items.Add(f.ToString());
            });
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
