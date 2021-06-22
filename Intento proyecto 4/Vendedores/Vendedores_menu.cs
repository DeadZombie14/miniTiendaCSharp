using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Intento_proyecto_4.Vendedores
{
    public partial class Vendedores_menu : Form
    {

        Clases.Conexionado conectar = new Clases.Conexionado();
        Clases.FuncionesVendedores funciones = new Clases.FuncionesVendedores();

        public Vendedores_menu()
        {
            InitializeComponent();
            pictureBox2.Image = global::Intento_proyecto_4.Properties.Resources.worker;
        }

        public void buscar_y_actualizar(string vID, string vNombres, string vApellidos, string vDireccion, string vID_sucursal)
        {
            dataGridView1.DataSource = funciones.BuscarVendedor(vID, vNombres, vApellidos, vDireccion, vID_sucursal);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form1 = (Form1)Tag;
            form1.Enabled = true;
            form1.Show();
            Close();
        }

        private void boton_anadir_Click(object sender, EventArgs e)
        {
            //Anadir vendedores
            Vendedores_anadir ventana2 = new Vendedores_anadir();
            ventana2.Tag = this;
            ventana2.Show(this);
            //insertar bloqueo de forma aqui
            this.Enabled = false;
        }

        private void boton_actualizar_Click(object sender, EventArgs e)
        {
            Actualizar_tabla_vendedores();
        }

        private void boton_eliminar_Click(object sender, EventArgs e)
        {
            //Eliminar vendedores
            Vendedores_eliminar ventana2 = new Vendedores_eliminar();
            ventana2.Tag = this;
            ventana2.Show(this);
            //insertar bloqueo de forma aqui
            this.Enabled = false;
        }

        private void boton_buscar_Click(object sender, EventArgs e)
        {
            //Buscar vendedores
            Vendedores_buscar ventana2 = new Vendedores_buscar();
            ventana2.Tag = this;
            ventana2.Show(this);
            //insertar bloqueo de forma aqui
            this.Enabled = false;
        }

        private void boton_editar_Click(object sender, EventArgs e)
        {
            //Editar vendedor
            Vendedores_editar ventana2 = new Vendedores_editar();
            ventana2.Tag = this;
            ventana2.Show(this);
            //insertar bloqueo de forma aqui
            this.Enabled = false;
        }

        public DataTable CargarTabla()
        {
            MySqlDataAdapter mySqlDataAdapter;
            conectar.AbrirConexion();
            string query = "SELECT ID_vendedor,Nombres,Apellidos,Direccion,Sucursales_ID_sucursal Sucursal FROM vendedores";
            DataSet DS = new DataSet();
            mySqlDataAdapter = new MySqlDataAdapter(query, conectar.ObtenerConexao());
            mySqlDataAdapter.Fill(DS);
            conectar.CerrarConexion();
            return DS.Tables[0];
        }

        public void Actualizar_tabla_vendedores()
        {
            dataGridView1.DataSource = CargarTabla();
        }

        private void Vendedores_menu_Load(object sender, EventArgs e)
        {
            Actualizar_tabla_vendedores();
        }


    }
}
