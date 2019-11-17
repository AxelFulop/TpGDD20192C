using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas
{
    public partial class Perfil : Form
    {
        private static string usuario;

        public Perfil(string user)
        {
            InitializeComponent();
            usuario = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MenuPrincipal().Show();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MenuPrincipal().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Perfil_Load(object sender, EventArgs e)
        {
            username.Text = usuario;
            rol.Text = new ConexionBD.Conexion().executeScalarFunction("obtenerRolUsuario", usuario).ToString();
            if (rol.Text == "Cliente")
                actualizarDatosCliente();
            if (rol.Text == "Proveedor")
                actualizarDatosProveedor();
            if (rol.Text == "Administrador")
                actualizarDatosAdministrador();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void actualizarDatosCliente()
        {
            panelCliente.Visible = true;
            string Dir_Aux = new ConexionBD.Conexion().selectReturnOnlyObject(
                "select cliente_direccion from " + Properties.Settings.Default.Schema + ".Cliente c inner join " +
                Properties.Settings.Default.Schema + ".Usuario u on c.usuario_id = u.usuario_id where u.usuario_nombre = '" + usuario + "'"
                ).ToString();
            Tuple<string, string> calleNumTuple = obtenerDireccion(Dir_Aux);
            dir_calle.Text = calleNumTuple.Item1;
            dir_numero.Text = calleNumTuple.Item2;
            dir_depto.Text = new ConexionBD.Conexion().selectReturnOnlyObject(
                "select cliente_direccion_depto from " + Properties.Settings.Default.Schema + ".Cliente c inner join " +
                Properties.Settings.Default.Schema + ".Usuario u on c.usuario_id = u.usuario_id where u.usuario_nombre = '" + usuario + "'"
                ).ToString();
            dir_localidad.Text = new ConexionBD.Conexion().selectReturnOnlyObject(
                "select cliente_direccion_localidad from " + Properties.Settings.Default.Schema + ".Cliente c inner join " +
                Properties.Settings.Default.Schema + ".Usuario u on c.usuario_id = u.usuario_id where u.usuario_nombre = '" + usuario + "'"
                ).ToString();
            dir_piso.Text = new ConexionBD.Conexion().selectReturnOnlyObject(
                "select cliente_direccion_piso from " + Properties.Settings.Default.Schema + ".Cliente c inner join " +
                Properties.Settings.Default.Schema + ".Usuario u on c.usuario_id = u.usuario_id where u.usuario_nombre = '" + usuario + "'"
                ).ToString();
            cli_nombre.Text = new ConexionBD.Conexion().selectReturnOnlyObject(
                "select cliente_nombre from " + Properties.Settings.Default.Schema + ".Cliente c inner join " +
                Properties.Settings.Default.Schema + ".Usuario u on c.usuario_id = u.usuario_id where u.usuario_nombre = '" + usuario + "'"
                ).ToString();
            cli_apellido.Text = new ConexionBD.Conexion().selectReturnOnlyObject(
                "select cliente_apellido from " + Properties.Settings.Default.Schema + ".Cliente c inner join " +
                Properties.Settings.Default.Schema + ".Usuario u on c.usuario_id = u.usuario_id where u.usuario_nombre = '" + usuario + "'"
                ).ToString();
            cli_mail.Text = new ConexionBD.Conexion().selectReturnOnlyObject(
                "select cliente_email from " + Properties.Settings.Default.Schema + ".Cliente c inner join " +
                Properties.Settings.Default.Schema + ".Usuario u on c.usuario_id = u.usuario_id where u.usuario_nombre = '" + usuario + "'"
                ).ToString();
            cli_dni.Text = new ConexionBD.Conexion().selectReturnOnlyObject(
                "select cliente_numero_dni from " + Properties.Settings.Default.Schema + ".Cliente c inner join " +
                Properties.Settings.Default.Schema + ".Usuario u on c.usuario_id = u.usuario_id where u.usuario_nombre = '" + usuario + "'"
                ).ToString();
            cli_telefono.Text = new ConexionBD.Conexion().selectReturnOnlyObject(
                "select cliente_telefono from " + Properties.Settings.Default.Schema + ".Cliente c inner join " +
                Properties.Settings.Default.Schema + ".Usuario u on c.usuario_id = u.usuario_id where u.usuario_nombre = '" + usuario + "'"
                ).ToString();
            cli_cp.Text = new ConexionBD.Conexion().selectReturnOnlyObject(
                "select cliente_codigo_postal from " + Properties.Settings.Default.Schema + ".Cliente c inner join " +
                Properties.Settings.Default.Schema + ".Usuario u on c.usuario_id = u.usuario_id where u.usuario_nombre = '" + usuario + "'"
                ).ToString();
            cli_fechaNacimiento.Value = (DateTime)new ConexionBD.Conexion().selectReturnOnlyObject(
                "select cliente_fecha_nacimiento from " + Properties.Settings.Default.Schema + ".Cliente c inner join " +
                Properties.Settings.Default.Schema + ".Usuario u on c.usuario_id = u.usuario_id where u.usuario_nombre = '" + usuario + "'"
                );
            cli_ciudad.Text = new ConexionBD.Conexion().selectReturnOnlyObject(
                "select cliente_ciudad from " + Properties.Settings.Default.Schema + ".Cliente c inner join " +
                Properties.Settings.Default.Schema + ".Usuario u on c.usuario_id = u.usuario_id where u.usuario_nombre = '" + usuario + "'"
                ).ToString();
        }

        private void actualizarDatosProveedor()
        {
            panelProveedor.Visible = true;
            string Dir_Aux = new ConexionBD.Conexion().selectReturnOnlyObject(
                "select proveedor_direccion from " + Properties.Settings.Default.Schema + ".Proveedor c inner join " +
                Properties.Settings.Default.Schema + ".Usuario u on c.usuario_id = u.usuario_id where u.usuario_nombre = '" + usuario + "'"
                ).ToString();
            Tuple<string, string> calleNumTuple = obtenerDireccion(Dir_Aux);
            dir_calle.Text = calleNumTuple.Item1;
            dir_numero.Text = calleNumTuple.Item2;
            dir_depto.Text = new ConexionBD.Conexion().selectReturnOnlyObject(
                "select proveedor_direccion_depto from " + Properties.Settings.Default.Schema + ".Proveedor c inner join " +
                Properties.Settings.Default.Schema + ".Usuario u on c.usuario_id = u.usuario_id where u.usuario_nombre = '" + usuario + "'"
                ).ToString();
            dir_localidad.Text = new ConexionBD.Conexion().selectReturnOnlyObject(
                "select proveedor_direccion_localidad from " + Properties.Settings.Default.Schema + ".Proveedor c inner join " +
                Properties.Settings.Default.Schema + ".Usuario u on c.usuario_id = u.usuario_id where u.usuario_nombre = '" + usuario + "'"
                ).ToString();
            dir_piso.Text = new ConexionBD.Conexion().selectReturnOnlyObject(
                "select proveedor_direccion_piso from " + Properties.Settings.Default.Schema + ".Proveedor c inner join " +
                Properties.Settings.Default.Schema + ".Usuario u on c.usuario_id = u.usuario_id where u.usuario_nombre = '" + usuario + "'"
                ).ToString();
            prov_razonSocial.Text = new ConexionBD.Conexion().selectReturnOnlyObject(
                "select proveedor_razon_social from " + Properties.Settings.Default.Schema + ".Proveedor c inner join " +
                Properties.Settings.Default.Schema + ".Usuario u on c.usuario_id = u.usuario_id where u.usuario_nombre = '" + usuario + "'"
                ).ToString();
            prov_mail.Text = new ConexionBD.Conexion().selectReturnOnlyObject(
                "select proveedor_email from " + Properties.Settings.Default.Schema + ".Proveedor c inner join " +
                Properties.Settings.Default.Schema + ".Usuario u on c.usuario_id = u.usuario_id where u.usuario_nombre = '" + usuario + "'"
                ).ToString();
            prov_telefono.Text = new ConexionBD.Conexion().selectReturnOnlyObject(
                "select proveedor_telefono from " + Properties.Settings.Default.Schema + ".Proveedor c inner join " +
                Properties.Settings.Default.Schema + ".Usuario u on c.usuario_id = u.usuario_id where u.usuario_nombre = '" + usuario + "'"
                ).ToString();
            prov_cp.Text = new ConexionBD.Conexion().selectReturnOnlyObject(
                "select proveedor_codigo_postal from " + Properties.Settings.Default.Schema + ".Proveedor c inner join " +
                Properties.Settings.Default.Schema + ".Usuario u on c.usuario_id = u.usuario_id where u.usuario_nombre = '" + usuario + "'"
                ).ToString();
            prov_cuit.Text = new ConexionBD.Conexion().selectReturnOnlyObject(
                "select proveedor_cuit from " + Properties.Settings.Default.Schema + ".Proveedor c inner join " +
                Properties.Settings.Default.Schema + ".Usuario u on c.usuario_id = u.usuario_id where u.usuario_nombre = '" + usuario + "'"
                ).ToString();
            prov_rubro.Text = new ConexionBD.Conexion().selectReturnOnlyObject(
                "select proveedor_rubro from " + Properties.Settings.Default.Schema + ".Proveedor c inner join " +
                Properties.Settings.Default.Schema + ".Usuario u on c.usuario_id = u.usuario_id where u.usuario_nombre = '" + usuario + "'"
                ).ToString();
            prov_contacto.Text = new ConexionBD.Conexion().selectReturnOnlyObject(
                "select proveedor_contacto from " + Properties.Settings.Default.Schema + ".Proveedor c inner join " +
                Properties.Settings.Default.Schema + ".Usuario u on c.usuario_id = u.usuario_id where u.usuario_nombre = '" + usuario + "'"
                ).ToString();
            prov_ciudad.Text = new ConexionBD.Conexion().selectReturnOnlyObject(
                "select proveedor_ciudad from " + Properties.Settings.Default.Schema + ".Proveedor c inner join " +
                Properties.Settings.Default.Schema + ".Usuario u on c.usuario_id = u.usuario_id where u.usuario_nombre = '" + usuario + "'"
                ).ToString();
        }

        private void actualizarDatosAdministrador()
        {
            panelDireccion.Visible = false;
        }

        private Tuple<string, string> obtenerDireccion(string calleMasNumero)
        {
            string[] dir = calleMasNumero.Split(' ');
            string calle = "";
            string numero = "";

            for (int i = 0; i < dir.Length - 1; i++)
            {
                calle += dir[i] + " ";
            }
            calle = calle.TrimEnd(' ');
            numero = dir.Last();

            return Tuple.Create<string, string>(calle, numero);
        }
    }
}
