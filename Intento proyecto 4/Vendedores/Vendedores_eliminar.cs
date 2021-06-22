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
    public partial class Vendedores_eliminar : Form
    {
        Clases.Conexionado conectar = new Clases.Conexionado();
        Clases.FuncionesVendedores funciones = new Clases.FuncionesVendedores();

        public Vendedores_eliminar()
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

                string query = "SELECT ID_vendedor FROM Vendedores";

                conectar.AbrirConexion();

                cmd.CommandText = query;
                reader = cmd.ExecuteReader();
                while (reader != null && reader.Read())
                {
                    comboBox1.Items.Add(((Int32)(reader["ID_vendedor"])).ToString());
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
            var form1 = (Vendedores.Vendedores_menu)Tag;
            form1.Enabled = true;
            form1.Show();
            Close();
        }

        private void boton_eliminar_Click(object sender, EventArgs e)
        {
            //Eliminar vendedor
            string ID_v = comboBox1.GetItemText(comboBox1.SelectedItem);
            if (ID_v == String.Empty)
            {
                return;
            }

            funciones.eliminarVendedor(ID_v);

            var form1 = (Vendedores.Vendedores_menu)Tag;
            form1.Enabled = true;
            form1.Show();
            form1.Actualizar_tabla_vendedores();
            Close();
        }

        private void Vendedores_eliminar_Load(object sender, EventArgs e)
        {

        }
    }
}
