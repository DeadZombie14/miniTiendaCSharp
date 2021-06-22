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
    public partial class Sucursales_editar : Form
    {
        Clases.Conexionado conexao = new Clases.Conexionado();
        Clases.FuncionesSucursales funciones = new Clases.FuncionesSucursales();

        public Sucursales_editar()
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

        private void boton_guardar_Click(object sender, EventArgs e)
        {
            //Guardar la sucursal editada
            string ID_s = comboBox1.GetItemText(comboBox1.SelectedItem);
            if (ID_s == String.Empty)
            {
                return;
            }

            funciones.EditarSucursal(ID_s, id_nueva.Text, direccion_nueva.Text, telefono_nuevo.Text);

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

        private void Sucursales_editar_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ID_s = comboBox1.GetItemText(comboBox1.SelectedItem);
            id_nueva.Text = ID_s;
            string llenarDescripcion = "SELECT Direccion,Telefono FROM sucursales WHERE ID_sucursal =" + ID_s + "";
            try
            {
                conexao.AbrirConexion();
                MySqlDataReader reader = null;
                MySqlCommand cmd = conexao.ObtenerConexao().CreateCommand();
                cmd.CommandText = llenarDescripcion;
                reader = cmd.ExecuteReader();
                while (reader != null && reader.Read())
                {
                    direccion_nueva.Text = ((String)(reader["Direccion"])).ToString();
                    telefono_nuevo.Text = ((Decimal)(reader["Telefono"])).ToString();
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
