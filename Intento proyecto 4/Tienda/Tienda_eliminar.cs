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
    public partial class Tienda_eliminar : Form
    {

        Clases.Conexionado conectar = new Clases.Conexionado();
        Clases.FuncionesTienda funciones = new Clases.FuncionesTienda();
        string id_compra { get; set; }

        public Tienda_eliminar(string id_de_compra)
        {
            InitializeComponent();
            id_compra = id_de_compra;
            CargarComboBox();
        }

        private void Tienda_eliminar_Load(object sender, EventArgs e)
        {

        }

        public void CargarComboBox()
        {
            try
            {
                MySqlDataReader reader = null;
                MySqlCommand cmd = conectar.ObtenerConexao().CreateCommand();

                string query = "SELECT productos_ID_producto FROM detallescompra WHERE compras_ID_compra = " + id_compra + "";

                conectar.AbrirConexion();

                cmd.CommandText = query;
                reader = cmd.ExecuteReader();
                while (reader != null && reader.Read())
                {
                    comboBox1.Items.Add(((Int32)(reader["productos_ID_producto"])).ToString());
                }
                conectar.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void boton_eliminar_Click(object sender, EventArgs e)
        {
            string ID_producto = comboBox1.GetItemText(comboBox1.SelectedItem);

            if(ID_producto == String.Empty)
            {
                return;
            }

            funciones.QuitarProductoDelCarrito(ID_producto);
            var form1 = (Tienda.Tienda_menu)Tag;
            form1.Enabled = true;
            form1.Show();
            form1.Actualizar_carrito_de_compras();
            form1.ActualizarTotal();
            Close();
        }

        private void boton_cancelar_Click(object sender, EventArgs e)
        {
            var form1 = (Tienda.Tienda_menu)Tag;
            form1.Enabled = true;
            form1.Show();
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
