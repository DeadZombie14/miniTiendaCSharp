using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intento_proyecto_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = global::Intento_proyecto_4.Properties.Resources.productoscoviran_marcapropia;
            pictureBox2.Image = global::Intento_proyecto_4.Properties.Resources.worker;
            pictureBox3.Image = global::Intento_proyecto_4.Properties.Resources.imagen_tienda_3;
            pictureBox4.Image = global::Intento_proyecto_4.Properties.Resources.cart;

            //pictureBox1.Image = Image.FromFile("productoscoviran_marcapropia.png");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Productos.Catalogo_Menu ventana2 = new Productos.Catalogo_Menu();
            ventana2.Tag = this;
            ventana2.Show(this);
            //insertar bloqueo de forma aqui
            this.Enabled = false; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vendedores.Vendedores_menu ventana2 = new Vendedores.Vendedores_menu();
            ventana2.Tag = this;
            ventana2.Show(this);
            //insertar bloqueo de forma aqui
            this.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sucursales.Sucursales_menu ventana2 = new Sucursales.Sucursales_menu();
            ventana2.Tag = this;
            ventana2.Show(this);
            //insertar bloqueo de forma aqui
            this.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Tienda.Tienda_menu ventana2 = new Tienda.Tienda_menu();
            ventana2.Tag = this;
            ventana2.Show(this);
            //insertar bloqueo de forma aqui
            this.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
