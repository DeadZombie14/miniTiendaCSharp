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
    public partial class Vendedores_buscar : Form
    {
        Clases.Conexionado conectar = new Clases.Conexionado();
        Clases.FuncionesVendedores funciones = new Clases.FuncionesVendedores();


        public Vendedores_buscar()
        {
            InitializeComponent();
        }

        private void Vendedores_buscar_Load(object sender, EventArgs e)
        {
            
        }

        private void boton_cancelar_Click(object sender, EventArgs e)
        {
            var form1 = (Vendedores.Vendedores_menu)Tag;
            form1.Enabled = true;
            form1.Show();
            Close();
        }

        private void boton_buscar_Click(object sender, EventArgs e)
        {
            //Buscar el vendedor con los datos especificados
            var form1 = (Vendedores.Vendedores_menu)Tag;
            form1.Enabled = true;
            form1.Show();
            form1.buscar_y_actualizar(ID_vendedor.Text, Nombres_vendedor.Text, Apellidos_vendedor.Text, Direccion_vendedor.Text, ID_sucursal_vendedor.Text);
            Close();
        }
    }
}
