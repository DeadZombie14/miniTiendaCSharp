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

namespace Intento_proyecto_4.Tienda
{
    public partial class Tienda_menu : Form
    {
        Clases.Conexionado conectar = new Clases.Conexionado();
        Clases.FuncionesTienda funciones = new Clases.FuncionesTienda();
        string ID_de_compra { get; set; }


        public Tienda_menu()
        {
            InitializeComponent();
            CargarComboBox();
            pictureBox4.Image = global::Intento_proyecto_4.Properties.Resources.cart;
        }

        public void reactivarBotones()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            textBox2.Enabled = true;
        }

        public void inhabilitarBotones()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            textBox2.Enabled = false;
        }

        public void CargarCompraExistente(string ID_compra_existente)
        {
            if (ID_compra_existente == String.Empty)
            {
                inhabilitarBotones();
                return;
            }
            reactivarBotones();

            ID_de_compra = ID_compra_existente;

            Actualizar_carrito_de_compras();
            textBox2.Text = "";

            //En caso de que la ID de compra no exista, se desabilitaran los botones de nuevo.
        }

        public void CargarComboBox()
        {
            try
            {
                MySqlDataReader reader = null;
                MySqlCommand cmd = conectar.ObtenerConexao().CreateCommand();

                string query = "SELECT ID_sucursal FROM sucursales";

                conectar.AbrirConexion();

                cmd.CommandText = query;
                reader = cmd.ExecuteReader();
                while (reader != null && reader.Read())
                {
                    comboBox1.Items.Add(((Int32)(reader["ID_sucursal"])).ToString());
                }
                conectar.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form1 = (Form1)Tag;
            form1.Enabled = true;
            form1.Show();
            Close();
        }


        public void ActualizarTotal()
        {
            //Actualizar el textbox de "Total".
            if (CargarTabla().Rows.Count == 0)
            {
                return;
            }
            try
            {
                string query = "SELECT SUM(Precio) FROM detallescompra LEFT JOIN productos ON (detallescompra.productos_ID_producto = productos.ID_producto) WHERE detallescompra.compras_ID_compra = " + ID_de_compra + "";
                conectar.AbrirConexion();
                MySqlDataReader reader = null;
                MySqlCommand cmd = conectar.ObtenerConexao().CreateCommand();
                cmd.CommandText = query;
                reader = cmd.ExecuteReader();
                while (reader != null && reader.Read())
                {
                    totaltextbox.Text = ((Decimal)(reader["SUM(Precio)"])).ToString();
                }
                conectar.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Actualizar_carrito_de_compras()
        {
            dataGridView1.DataSource = CargarTabla();
            ActualizarTotal();     
        }

        public DataTable CargarTabla()
        {
            MySqlDataAdapter mySqlDataAdapter;
            conectar.AbrirConexion();
            string query = "SELECT Productos_ID_producto, Descripcion, Precio, Pedidos FROM detallescompra LEFT JOIN productos ON (detallescompra.productos_ID_producto = productos.ID_producto) WHERE detallescompra.compras_ID_compra = "+ ID_de_compra +"";
            DataSet DS = new DataSet();
            mySqlDataAdapter = new MySqlDataAdapter(query, conectar.ObtenerConexao());
            mySqlDataAdapter.Fill(DS);
            conectar.CerrarConexion();
            return DS.Tables[0];
        }

        private void Tienda_menu_Load(object sender, EventArgs e)
        {
            //Actualizar_carrito_de_compras();
        }


        /** Boton para anadir productos**/
        private void button1_Click(object sender, EventArgs e)
        {
            //Anadir productos
            Tienda_anadir ventana2 = new Tienda_anadir(ID_de_compra);
            ventana2.Tag = this;
            ventana2.Show(this);
            //insertar bloqueo de forma aqui
            this.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            reactivarBotones();

            string id_sucursal = comboBox1.GetItemText(comboBox1.SelectedItem);
            String query = "INSERT INTO compras (Sucursales_ID_sucursal) values (" + id_sucursal + ")";

            //Insertar la nueva compra
            try
            {
                MySqlCommand cmd = conectar.ObtenerConexao().CreateCommand();
                cmd.CommandText = query;
                conectar.AbrirConexion();
                cmd.ExecuteNonQuery();
                conectar.CerrarConexion();
            }
            catch (Exception ex)
            {
                //  MessageBox.Show("' Error, comprueba los datos ingresados y verifica que no estén repetidos. '");
                MessageBox.Show(ex.Message);
            }
            //Guardar la ID de la compra actual
            try
            {
                //string obtenerIDCompra = "select AUTO_INCREMENT from information_schema.TABLES where TABLE_SCHEMA='puntodeventas' and TABLE_NAME='compras'";
                string obtenerIDCompra = "SELECT MAX(id_compra) FROM compras";
                conectar.AbrirConexion();
                MySqlDataReader reader = null;
                MySqlCommand cmd = conectar.ObtenerConexao().CreateCommand();
                cmd.CommandText = obtenerIDCompra;
                reader = cmd.ExecuteReader();
                while (reader != null && reader.Read())
                {
                    ID_de_compra = ((Int32)(reader["MAX(id_compra)"])).ToString();
                }
                conectar.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Actualizar_carrito_de_compras();
            textBox2.Text = "";
        }


        public string obtenerIDCompraActual()
        {
            return ID_de_compra;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button5.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Anadir productos
            Tienda_eliminar ventana2 = new Tienda_eliminar(ID_de_compra);
            ventana2.Tag = this;
            ventana2.Show(this);
            //insertar bloqueo de forma aqui
            this.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Tienda_seleccionar_compra ventana2 = new Tienda_seleccionar_compra();
            ventana2.Tag = this;
            ventana2.Show(this);
            //insertar bloqueo de forma aqui
            this.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (totaltextbox.Text == string.Empty) { return; }
            try
            {
                if (textBox2.Text == string.Empty)
                {
                    cambio.Text = "";
                    return;
                }
                int total = Convert.ToInt32(totaltextbox.Text);
                int dinero_recibido = Convert.ToInt32(textBox2.Text);
                cambio.Text = (total - dinero_recibido).ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Este campo solo acepta valores numericos.");
                textBox2.Text = "";
            }
        }
    }
}
