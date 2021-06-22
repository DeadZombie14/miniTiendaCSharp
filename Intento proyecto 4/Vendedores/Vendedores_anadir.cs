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
    public partial class Vendedores_anadir : Form
    {
        Clases.Conexionado conectar = new Clases.Conexionado();
        Clases.FuncionesVendedores funciones = new Clases.FuncionesVendedores();

        public Vendedores_anadir()
        {
            InitializeComponent();
            CargarComboBox();
        }

        public void CargarComboBox()
        {
            try
            {
                MySqlDataReader reader = null;
                MySqlCommand cmd = conectar.ObtenerConexao().CreateCommand();

                string query = "SELECT ID_sucursal id FROM sucursales";

                conectar.AbrirConexion();

                cmd.CommandText = query;
                reader = cmd.ExecuteReader();
                while (reader != null && reader.Read())
                {
                    comboBox1.Items.Add(((Int32)(reader["id"])).ToString());
                    //lTotal.Text = ((String)(reader["descripcion"])).ToString();
                }
                conectar.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void Vendedores_anadir_Load(object sender, EventArgs e)
        {

        }

        private void boton_cancelar_Click(object sender, EventArgs e)
        {
            var form1 = (Vendedores.Vendedores_menu)Tag;
            form1.Enabled = true;
            form1.Show();
            Close();
        }

        private void boton_listo_Click(object sender, EventArgs e)
        {
            string ID_sucursal = comboBox1.GetItemText(comboBox1.SelectedItem);


            if (id_vendedor.Text == string.Empty)
            {
                funciones.AnadirVendedor(nombres_vendedor.Text, apellidos_vendedor.Text, direccion_vendedor.Text, ID_sucursal);
            }
            else
            {
                funciones.AnadirVendedor(id_vendedor.Text, nombres_vendedor.Text, apellidos_vendedor.Text, direccion_vendedor.Text, ID_sucursal);
            }
            
            var form1 = (Vendedores.Vendedores_menu)Tag;
            form1.Enabled = true;
            form1.Show();
            form1.Actualizar_tabla_vendedores();
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (id_vendedor.Enabled == false)
            {
                id_vendedor.Enabled = true;
            }
            else
            {
                id_vendedor.Enabled = false;
            }
        }

        private void id_manual_vendedor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
