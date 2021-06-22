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

namespace Intento_proyecto_4.Sucursales
{
    public partial class Sucursales_menu : Form
    {
        Clases.Conexionado conectar = new Clases.Conexionado();
        Clases.FuncionesSucursales funciones = new Clases.FuncionesSucursales();

        public Sucursales_menu()
        {
            InitializeComponent();
            pictureBox1.Image = global::Intento_proyecto_4.Properties.Resources.imagen_tienda_3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form1 = (Form1)Tag;
            form1.Enabled = true;
            form1.Show();
            Close();
        }

        private void Sucursales_menu_Load(object sender, EventArgs e)
        {
            ActualizarSucursales();
        }

        public void ActualizarSucursales()
        {
            dataGridView1.DataSource = CargarTabla();
        }

        public DataTable CargarTabla()
        {
            MySqlDataAdapter mySqlDataAdapter;
            conectar.AbrirConexion();
            string query = "SELECT * FROM sucursales";
            DataSet DS = new DataSet();
            mySqlDataAdapter = new MySqlDataAdapter(query, conectar.ObtenerConexao());
            mySqlDataAdapter.Fill(DS);
            conectar.CerrarConexion();
            return DS.Tables[0];
        }

        private void ActualizarTabla_Click(object sender, EventArgs e)
        {
            ActualizarSucursales();
        }

        private void EliminarSucursal_Click(object sender, EventArgs e)
        {
            Sucursales_eliminar ventana2 = new Sucursales_eliminar();
            ventana2.Tag = this;
            ventana2.Show(this);
            //insertar bloqueo de forma aqui
            this.Enabled = false;
        }

        public void buscar_y_actualizar(string ID_sucursal, string direccion, string telefono)
        {
            dataGridView1.DataSource = funciones.BuscarSucursal(ID_sucursal, direccion, telefono);
        }

        private void BuscarSucursal_Click(object sender, EventArgs e)
        {
            Sucursales_buscar ventana2 = new Sucursales_buscar();
            ventana2.Tag = this;
            ventana2.Show(this);
            //insertar bloqueo de forma aqui
            this.Enabled = false;
        }

        private void EditarSucursal_Click(object sender, EventArgs e)
        {
            Sucursales_editar ventana2 = new Sucursales_editar();
            ventana2.Tag = this;
            ventana2.Show(this);
            //insertar bloqueo de forma aqui
            this.Enabled = false;
        }

        private void AnadirSucursal_Click(object sender, EventArgs e)
        {
            Sucursales_anadir ventana2 = new Sucursales_anadir();
            ventana2.Tag = this;
            ventana2.Show(this);
            //insertar bloqueo de forma aqui
            this.Enabled = false;
        }
    }
}
