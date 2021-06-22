using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intento_proyecto_4.Productos
{
    public partial class Catalogo_buscar : Form
    {
        public Catalogo_buscar()
        {
            InitializeComponent();
        }

        private void boton_cancelar_Click(object sender, EventArgs e)
        {
            var form1 = (Productos.Catalogo_Menu)Tag;
            form1.Enabled = true;
            form1.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Buscar producto
            string IDp = ID_producto.Text;
            string Preciop = Precio_producto.Text;
            string descp = desc_producto.Text;
            string cantp = cant_producto.Text;
            //Cerrar ventana
            var form1 = (Productos.Catalogo_Menu)Tag;
            form1.Enabled = true;
            form1.Show();
            form1.buscar_y_actualizar(IDp, Preciop, descp, cantp);
            Close();
        }

        private void desc_producto_TextChanged(object sender, EventArgs e)
        {

        }

        private void cant_producto_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Precio_producto_TextChanged(object sender, EventArgs e)
        {

        }

        private void ID_producto_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
