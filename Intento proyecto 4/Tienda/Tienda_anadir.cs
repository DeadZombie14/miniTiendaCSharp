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
    public partial class Tienda_anadir : Form
    {
        Clases.Conexionado conectar = new Clases.Conexionado();
        Clases.FuncionesTienda funciones = new Clases.FuncionesTienda();
        string id_compra_actual { get; set; }

        public Tienda_anadir(string id_compra)
        {
            InitializeComponent();
            id_compra_actual = id_compra;
            CargarComboBox();
        }

        public void CargarComboBox()
        {
            try
            {
                MySqlDataReader reader = null;
                MySqlCommand cmd = conectar.ObtenerConexao().CreateCommand();

                string query = "SELECT ID_producto FROM productos";

                conectar.AbrirConexion();

                cmd.CommandText = query;
                reader = cmd.ExecuteReader();
                while (reader != null && reader.Read())
                {
                    comboBox1.Items.Add((Int32)(reader["ID_producto"])).ToString();
                    //lTotal.Text = ((String)(reader["descripcion"])).ToString();
                }
                conectar.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void boton_cancelar_Click(object sender, EventArgs e)
        {
            var form1 = (Tienda.Tienda_menu)Tag;
            form1.Enabled = true;
            form1.Show();
            Close();
        }

        private void boton_agregar_Click(object sender, EventArgs e)
        {
            if(cant_a_ordenar.Text == string.Empty)
            {
                MessageBox.Show("Porfavor, ingrese la cantidad que desea solicitar del producto");
                return;
            }
            string ID_producto = comboBox1.GetItemText(comboBox1.SelectedItem);
            int cantidad_ordenada = Convert.ToInt32(cant_a_ordenar.Text);
            int cantidad_disponible = Convert.ToInt32(cant_producto.Text);
            

            if (cantidad_ordenada <= cantidad_disponible)
            {
                funciones.AnadirProductoAlCarrito(id_compra_actual, ID_producto, cant_a_ordenar.Text);
                var form1 = (Tienda.Tienda_menu)Tag;
                form1.Enabled = true;
                form1.Show();
                form1.Actualizar_carrito_de_compras();
                form1.ActualizarTotal();
                Close();
            }
            else
            {
                MessageBox.Show("ERROR: No se dispone de tal cantidad del producto, inténtelo de nuevo", "ERROR",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ID_producto = comboBox1.GetItemText(comboBox1.SelectedItem);
            string llenarDescripcion = "SELECT Descripcion, Precio, Cantidad_en_existencia FROM productos WHERE ID_producto =" + ID_producto + "";
            try
            {
                conectar.AbrirConexion();
                MySqlDataReader reader = null;
                MySqlCommand cmd = conectar.ObtenerConexao().CreateCommand();
                cmd.CommandText = llenarDescripcion;
                reader = cmd.ExecuteReader();
                while (reader != null && reader.Read())
                {
                    desc_producto.Text = ((String)(reader["Descripcion"])).ToString();
                    precio_producto.Text = ((Int32)(reader["Precio"])).ToString();
                    cant_producto.Text = ((Int32)(reader["Cantidad_en_existencia"])).ToString();
                }
                conectar.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Tienda_anadir_Load(object sender, EventArgs e)
        {

        }
    }
}
