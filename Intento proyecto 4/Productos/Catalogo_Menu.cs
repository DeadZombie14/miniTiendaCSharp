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

namespace Intento_proyecto_4.Productos
{
    public partial class Catalogo_Menu : Form
    {
        Clases.Conexionado conectar = new Clases.Conexionado();
        Clases.FuncionesCatalogo funciones = new Clases.FuncionesCatalogo();

        public Catalogo_Menu()
        {
            InitializeComponent();
            pictureBox1.Image = global::Intento_proyecto_4.Properties.Resources.productoscoviran_marcapropia;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Catalogo ventana2 = new Catalogo();
            ventana2.Tag = this;
            ventana2.Show(this);
            //insertar bloqueo de forma aqui
            this.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form1 = (Form1)Tag;
            form1.Enabled = true;
            form1.Show();
            Close();
        }

        private void Catalogo_Menu_Load(object sender, EventArgs e)
        {
            Actualizar_catalogo();
        }

        public void Actualizar_catalogo()
        {
            dataGridView1.DataSource = CargarTabla();
        }

        public DataTable CargarTabla()
        {
            MySqlDataAdapter mySqlDataAdapter;
            conectar.AbrirConexion();
            string query = "SELECT * FROM productos";
            DataSet DS = new DataSet();
            mySqlDataAdapter = new MySqlDataAdapter(query, conectar.ObtenerConexao());
            mySqlDataAdapter.Fill(DS);
            conectar.CerrarConexion();
            return DS.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Actualizar_catalogo();
        }

        public void buscar_y_actualizar(string ID_producto, string Precio_producto, string desc_producto, string cant_producto)
        {
            dataGridView1.DataSource = funciones.BuscarProducto(ID_producto, Precio_producto, desc_producto, cant_producto);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            /**Buscar productos**/

            Catalogo_buscar ventana2 = new Catalogo_buscar();
            ventana2.Tag = this;
            ventana2.Show(this);
            //insertar bloqueo de forma aqui
            this.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /**Eliminar productos**/

            Catalogo_eliminar ventana2 = new Catalogo_eliminar();
            ventana2.Tag = this;
            ventana2.Show(this);
            //insertar bloqueo de forma aqui
            this.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Editar productos
            Catalogo_editar ventana2 = new Catalogo_editar();
            ventana2.Tag = this;
            ventana2.Show(this);
            //insertar bloqueo de forma aqui
            this.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
