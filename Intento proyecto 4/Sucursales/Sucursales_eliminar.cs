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
    public partial class Sucursales_eliminar : Form
    {
        Clases.Conexionado conexao = new Clases.Conexionado();
        Clases.FuncionesSucursales funciones = new Clases.FuncionesSucursales();

        public Sucursales_eliminar()
        {
            InitializeComponent();
            CargarComboBox();
        }

        public void CargarComboBox()
        {
            try
            {
                MySqlDataReader reader = null;
                MySqlCommand cmd = conexao.ObtenerConexao().CreateCommand();

                string query = "SELECT ID_sucursal FROM sucursales";

                conexao.AbrirConexion();

                cmd.CommandText = query;
                reader = cmd.ExecuteReader();
                while (reader != null && reader.Read())
                {
                    comboBox1.Items.Add(((Int32)(reader["ID_sucursal"])).ToString());
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
            //Eliminar la sucursal
            string ID_s = comboBox1.GetItemText(comboBox1.SelectedItem);
            if (ID_s == String.Empty)
            {
                return;
            }

            funciones.eliminarSucursal(ID_s);

            var form1 = (Sucursales.Sucursales_menu)Tag;
            form1.Enabled = true;
            form1.Show();
            form1.ActualizarSucursales();
            Close();
        }

        private void boton_cancelar_Click(object sender, EventArgs e)
        {
            var form1 = (Sucursales.Sucursales_menu)Tag;
            form1.Enabled = true;
            form1.Show();
            Close();
        }

        private void Sucursales_eliminar_Load(object sender, EventArgs e)
        {

        }
    }
}
