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
    public partial class Catalogo_editar : Form
    {
        Clases.Conexionado conexao = new Clases.Conexionado();
        Clases.FuncionesCatalogo funciones = new Clases.FuncionesCatalogo();


        public Catalogo_editar()
        {
            InitializeComponent();
            CargarComboBox();
        }

        private void Catalogo_editar_Load(object sender, EventArgs e)
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

        private void boton_cancelar_Click(object sender, EventArgs e)
        {
            var form1 = (Productos.Catalogo_Menu)Tag;
            form1.Enabled = true;
            form1.Show();
            Close();
        }

        private void boton_eliminar_Click(object sender, EventArgs e)
        {
            //Guardar producto editado
            string ID_producto = comboBox1.GetItemText(comboBox1.SelectedItem);
            if (ID_producto == String.Empty)
            {
                return;
            }

            funciones.EditarProducto(ID_producto, id_nueva.Text, precio_nuevo.Text, desc_nueva.Text, cant_nueva.Text);
            var form1 = (Productos.Catalogo_Menu)Tag;
            form1.Enabled = true;
            form1.Show();
            form1.Actualizar_catalogo();
            Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cant_nueva_TextChanged(object sender, EventArgs e)
        {

        }

        private void desc_nueva_TextChanged(object sender, EventArgs e)
        {

        }

        private void precio_nuevo_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_nueva_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_de_producto_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ID_p = comboBox1.GetItemText(comboBox1.SelectedItem);
            id_nueva.Text = ID_p;
            string llenarDescripcion = "SELECT Precio,Descripcion,Cantidad_en_existencia FROM productos WHERE ID_producto =" + ID_p + "";
            try
            {
                conexao.AbrirConexion();
                MySqlDataReader reader = null;
                MySqlCommand cmd = conexao.ObtenerConexao().CreateCommand();
                cmd.CommandText = llenarDescripcion;
                reader = cmd.ExecuteReader();
                while (reader != null && reader.Read())
                {
                    precio_nuevo.Text = ((Int32)(reader["Precio"])).ToString();
                    desc_nueva.Text = ((String)(reader["Descripcion"])).ToString();
                    cant_nueva.Text = ((Int32)(reader["Cantidad_en_existencia"])).ToString();
                }
                conexao.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
