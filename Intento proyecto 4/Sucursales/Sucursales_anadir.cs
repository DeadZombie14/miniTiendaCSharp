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
    public partial class Sucursales_anadir : Form
    {
        Clases.Conexionado conexao = new Clases.Conexionado();
        Clases.FuncionesSucursales funciones = new Clases.FuncionesSucursales();

        public Sucursales_anadir()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form1 = (Sucursales.Sucursales_menu)Tag;
            form1.Enabled = true;
            form1.Show();
            Close();
        }

        private void boton_listo_Click(object sender, EventArgs e)
        {
            //Anadir la sucursal
            if(id_sucursal.Text != string.Empty)
            {
                funciones.AnadirSucursal(id_sucursal.Text, direccion.Text, telefono.Text);
            }
            else
            {
                funciones.AnadirSucursal(direccion.Text, telefono.Text);
            }
            

            var form1 = (Sucursales.Sucursales_menu)Tag;
            form1.Enabled = true;
            form1.Show();
            form1.ActualizarSucursales();
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (id_sucursal.Enabled == false)
            { id_sucursal.Enabled = true; }
            else
            {
                id_sucursal.Enabled = false;
            }
        }
    }
}
