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
    public partial class MenuPrincipal : Form
    {
        public static string usuario;
        private List<string> roles = new List<string>();
        private Boolean estaHabilitado;

        public MenuPrincipal()
        {
            InitializeComponent();
            cargarRoles();
            determinarMenu();
            identificarHabilitacion();
        }

        public MenuPrincipal(string nombreUsuario)
        {
            InitializeComponent();
            usuario = nombreUsuario;
            cargarRoles();
            determinarMenu();
            identificarHabilitacion();
        }

        private void cargarRoles()
        {
           string query = "select r.rol_nombre from " + Properties.Settings.Default.Schema + ".UsuarioXRol uxr" +
               " inner join " + Properties.Settings.Default.Schema + ".Usuario u on u.usuario_id = uxr.usuario_id" +
               " inner join " + Properties.Settings.Default.Schema + ".Rol r on r.rol_id = uxr.rol_id" +
               " where usuario_nombre='" + usuario + "'";


            ConexionBD.Conexion conection = new ConexionBD.Conexion().getInstance();
            List<Object> auxRoles = conection.executeAdvancedSelectQuery(query);

            auxRoles.ForEach(r => roles.Add(r.ToString()));
        }

        private void determinarMenu()
        {
            if (roles.Count == 0)
            {
                msg_sin_rol.Visible = true;
                return;
            }

            foreach (string rol in roles)
            {
                string query = "select f.funcionalidad_descripcion from " + Properties.Settings.Default.Schema + ".Rol r " +
                    "inner join " + Properties.Settings.Default.Schema + ".FuncionalidadXRol fxr on fxr.rol_id = r.rol_id " +
                    "inner join " + Properties.Settings.Default.Schema + ".Funcionalidad f on f.funcionalidad_id = fxr.funcionalidad_id " +
                    "where r.rol_nombre = '" + rol + "'";

                ConexionBD.Conexion conection = new ConexionBD.Conexion().getInstance();
                List<Object> funcionalidades = conection.executeAdvancedSelectQuery(query);

                foreach (Object func in funcionalidades)
                {
                    switch (func.ToString())
                    {
                        case "ABM cliente":
                            if(!this.listadoMenu.Items.Contains("Clientes"))
                                this.listadoMenu.Items.Add("Clientes");
                            break;
                        case "ABM oferta":
                            if (!this.listadoMenu.Items.Contains("Ofertas"))
                                this.listadoMenu.Items.Add("Ofertas");
                            break;
                        case "ABM proveedor":
                            if (!this.listadoMenu.Items.Contains("Proveedores"))
                                this.listadoMenu.Items.Add("Proveedores");
                            break;
                        case "ABM rol":
                            if (!this.listadoMenu.Items.Contains("Roles"))
                                this.listadoMenu.Items.Add("Roles");
                            break;
                        case "Cargar credito":
                            if (!this.listadoMenu.Items.Contains("Cargar crédito"))
                                this.listadoMenu.Items.Add("Cargar crédito");
                            break;
                        case "Comprar oferta":
                            if (!this.listadoMenu.Items.Contains("Comprar ofertas"))
                                this.listadoMenu.Items.Add("Comprar ofertas");
                            break;
                        case "Facturar a proveedor":
                            if (!this.listadoMenu.Items.Contains("Facturar"))
                                this.listadoMenu.Items.Add("Facturar");
                            break;
                        case "Listado estadistico":
                            if (!this.listadoMenu.Items.Contains("Listado estadístico"))
                                this.listadoMenu.Items.Add("Listado estadístico");
                            break;
                        case "Registrar tarjeta":
                            if (!this.listadoMenu.Items.Contains("Registrar tarjeta"))
                                this.listadoMenu.Items.Add("Registrar tarjeta");
                            break;
                        default: break;
                    }
                }
            }

            if (roles.Contains("Cliente"))
            {
                this.listadoMenu.Items.Add("Consultar saldo");
            }

            if (listadoMenu.Items.Count == 0)
                msg_rol_malo.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Perfil(usuario).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void listadoMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listadoMenu.SelectedItem != null && listadoMenu.SelectedItem.ToString() != "")
            {
                Boolean mustHide = true;
                switch (listadoMenu.SelectedItem.ToString())
                {
                    case "Clientes":
                        new AbmCliente.AbmCliente().Show();
                        break;
                    case "Ofertas":
                        if (estaHabilitado)
                            new CrearOferta.ConfeccionarOferta().Show();
                        else
                        {
                            MessageBox.Show("Un proveedor inhabilitado no puede confeccionar ofertas");
                            mustHide = false;
                        }
                        break;
                    case "Proveedores":
                        new AbmProveedor.AbmProveedor().Show();
                        break;
                    case "Roles":
                        new AbmRol.AbmRol().Show();
                        break;
                    case "Cargar crédito":
                        if (estaHabilitado)
                            new CragaCredito.CargaCreditoABM(usuario).Show();
                        else
                        {
                            MessageBox.Show("Un cliente inhabilitado no puede cargar crédito");
                            mustHide = false;
                        }
                        break;
                    case "Comprar ofertas":
                        if (estaHabilitado)
                            new ComprarOferta.Form1().Show();
                        else
                        {
                            MessageBox.Show("Un cliente inhabilitado no puede comprar ofertas");
                            mustHide = false;
                        }
                        break;
                    case "Facturar":
                        new Facturar.Form1().Show();
                        break;
                    case "Listado estadístico":
                        new ListadoEstadistico.Form1().Show();
                        break;
                    case "Registrar tarjeta":
                        new RegistrarTarjeta().Show();
                        break;
                    case "Consultar saldo":
                        consultaSaldoCliente();
                        return;
                    default: break;
                }
                if (mustHide)
                    this.Hide();
            }
        }

        private void consultaSaldoCliente()
        {
            Object saldo = new ConexionBD.Conexion().executeScalarFunction("saldoCliente", usuario);
            MessageBox.Show("Su saldo actual es de: $" + saldo.ToString());
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new Logeo(5,3).Show();
        }

        public void identificarHabilitacion()
        {
            Object habilitado = new ConexionBD.Conexion().executeScalarFunction("usuarioEstaHabilitado", usuario);
            this.estaHabilitado = habilitado.ToString() == "0"? true : false;
            if(!estaHabilitado)
                inhabilitadoMsg.Visible = true;
        }
    }
}
