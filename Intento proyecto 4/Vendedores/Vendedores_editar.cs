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
    public partial class Vendedores_editar : Form
    {
        Clases.Conexionado conectar = new Clases.Conexionado();
        Clases.FuncionesVendedores funciones = new Clases.FuncionesVendedores();

        public Vendedores_editar()
        {
            InitializeComponent();
            CargarComboBox();
            CargarComboBox2();
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
                }
                conectar.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        public void CargarComboBox2()
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
                    comboBox2.Items.Add(((Int32)(reader["ID_vendedor"])).ToString());
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

        private void boton_guardar_Click(object sender, EventArgs e)
        {
            string id_sucursal_n = comboBox1.GetItemText(comboBox1.SelectedItem);
            string id_vendendor = comboBox2.GetItemText(comboBox1.SelectedItem);

            if (id_vendendor == String.Empty)
            {
                return;
            }
            //Guardar cambios
            funciones.EditarVendedor(id_vendendor, id_nueva.Text, nombres_nuevos.Text, apellidos_nuevos.Text, direccion_nueva.Text, id_sucursal_n);

            var form1 = (Vendedores.Vendedores_menu)Tag;
            form1.Enabled = true;
            form1.Actualizar_tabla_vendedores();
            form1.Show();
            Close();
        }

        private void Vendedores_editar_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ID_v = comboBox2.GetItemText(comboBox2.SelectedItem);
            id_nueva.Text = ID_v;
            string llenarDescripcion = "SELECT Nombres,Apellidos,Direccion, Sucursales_ID_sucursal FROM vendedores WHERE ID_vendedor =" + ID_v + "";
            try
            {
                conectar.AbrirConexion();
                MySqlDataReader reader = null;
                MySqlCommand cmd = conectar.ObtenerConexao().CreateCommand();
                cmd.CommandText = llenarDescripcion;
                reader = cmd.ExecuteReader();
                while (reader != null && reader.Read())
                {
                    nombres_nuevos.Text = ((String)(reader["Nombres"])).ToString();
                    apellidos_nuevos.Text = ((String)(reader["Apellidos"])).ToString();
                    direccion_nueva.Text = ((String)(reader["Direccion"])).ToString();
                    comboBox1.SelectedItem = ((Int32)(reader["Sucursales_ID_sucursal"])).ToString();
                }
                conectar.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
