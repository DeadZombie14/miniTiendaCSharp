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
    public partial class Catalogo_eliminar : Form
    {
        Clases.Conexionado conexao = new Clases.Conexionado();
        Clases.FuncionesCatalogo funciones = new Clases.FuncionesCatalogo();
        public Catalogo_eliminar()
        {
            InitializeComponent();
            CargarComboBox();
        }

        private void Catalogo_eliminar_Load(object sender, EventArgs e)
        {

        }

        public void CargarComboBox()
        {
            try
            {
                MySqlDataReader reader = null;
                MySqlCommand cmd = conexao.ObtenerConexao().CreateCommand();

                string query = "SELECT ID_producto FROM productos";

                conexao.AbrirConexion();

                cmd.CommandText = query;
                reader = cmd.ExecuteReader();
                while (reader != null && reader.Read())
                {
                    comboBox1.Items.Add(((Int32)(reader["ID_producto"])).ToString());
                }
                conexao.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void boton_eliminar_Click(object sender, EventArgs e)
        {
            string ID_producto = comboBox1.GetItemText(comboBox1.SelectedItem);
            if (ID_producto == String.Empty)
            {
                return;
            }

            funciones.eliminarProducto(ID_producto);
            var form1 = (Productos.Catalogo_Menu)Tag;
            form1.Enabled = true;
            form1.Show();
            form1.Actualizar_catalogo();
            Close();
            
        }

        private void boton_cancelar_Click(object sender, EventArgs e)
        {
            var form1 = (Productos.Catalogo_Menu)Tag;
            form1.Enabled = true;
            form1.Show();
            Close();
        }
    }
}
