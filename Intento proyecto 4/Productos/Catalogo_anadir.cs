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

namespace Intento_proyecto_4
{
    public partial class Catalogo : Form
    {
        Clases.Conexionado conexao = new Clases.Conexionado();
        Clases.FuncionesCatalogo funciones = new Clases.FuncionesCatalogo();

        public Catalogo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form1 = (Productos.Catalogo_Menu)Tag;
            form1.Enabled = true;
            form1.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            funciones.AnadirProducto( precio_de_producto.Text, desc_de_producto.Text, cant_de_producto.Text);
            var form1 = (Productos.Catalogo_Menu)Tag;
            form1.Enabled = true;
            form1.Show();
            form1.Actualizar_catalogo();
            Close();
        }

        private void Catalogo_Load(object sender, EventArgs e)
        {

        }
    }
}
