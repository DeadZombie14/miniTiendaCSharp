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
    public partial class Tienda_seleccionar_compra : Form
    {
        Clases.Conexionado conectar = new Clases.Conexionado();
        Clases.FuncionesTienda funciones = new Clases.FuncionesTienda();
        string ID_de_compra { get; set; }

        public Tienda_seleccionar_compra()
        {
            InitializeComponent();
            CargarComboBox();
        }

        private void Tienda_seleccionar_compra_Load(object sender, EventArgs e)
        {

        }

        public DataTable CargarTabla()
        {
            MySqlDataAdapter mySqlDataAdapter;
            conectar.AbrirConexion();
            string query = "SELECT Productos_ID_producto, Descripcion, Precio, Pedidos FROM detallescompra LEFT JOIN productos ON (detallescompra.productos_ID_producto = productos.ID_producto) WHERE detallescompra.compras_ID_compra = " + ID_de_compra + "";
            DataSet DS = new DataSet();
            mySqlDataAdapter = new MySqlDataAdapter(query, conectar.ObtenerConexao());
            mySqlDataAdapter.Fill(DS);
            conectar.CerrarConexion();
            return DS.Tables[0];
        }

        public void CargarComboBox()
        {
            comboBox1.Items.Clear();
            dataGridView1.DataSource = null;
            try
            {
                MySqlDataReader reader = null;
                MySqlCommand cmd = conectar.ObtenerConexao().CreateCommand();

                string query = "SELECT ID_compra FROM compras";

                conectar.AbrirConexion();

                cmd.CommandText = query;
                reader = cmd.ExecuteReader();
                while (reader != null && reader.Read())
                {
                    
                    comboBox1.Items.Add(((Int32)(reader["ID_compra"])).ToString());
                }
                conectar.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ID_de_compra = comboBox1.GetItemText(comboBox1.SelectedItem);
            dataGridView1.DataSource = CargarTabla();
        }

        private void boton_cancelar_Click(object sender, EventArgs e)
        {
            var form1 = (Tienda.Tienda_menu)Tag;
            form1.Enabled = true;
            form1.Show();
            Close();
        }

        private void boton_aceptar_Click(object sender, EventArgs e)
        {
            ID_de_compra = comboBox1.GetItemText(comboBox1.SelectedItem);
            var form1 = (Tienda.Tienda_menu)Tag;
            form1.Enabled = true;
            form1.CargarCompraExistente(ID_de_compra);
            form1.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Ventana confirmar eliminar compra
            if(comboBox1.GetItemText(comboBox1.SelectedItem) != string.Empty)
            {
                Confirmar_Eliminar_Compra ventana3 = new Confirmar_Eliminar_Compra(ID_de_compra);
                ventana3.Tag = this;
                ventana3.Show(this);
                this.Enabled = false;
            }
            
        }

        public void limpiarComboBox()
        {
            comboBox1.Items.Clear();
            comboBox1.ResetText();
        }
    }
}
