using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intento_proyecto_4.Sucursales
{
    public partial class Sucursales_buscar : Form
    {
        Clases.Conexionado conexao = new Clases.Conexionado();
        Clases.FuncionesSucursales funciones = new Clases.FuncionesSucursales();

        public Sucursales_buscar()
        {
            InitializeComponent();
        }

        private void Sucursales_buscar_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void boton_buscar_Click(object sender, EventArgs e)
        {
            //Buscar la sucursal
            string sID = ID_sucursal.Text;
            string sDireccion = Direccion.Text;
            string sTelefono = Telefono.Text;

            var form1 = (Sucursales.Sucursales_menu)Tag;
            form1.Enabled = true;
            form1.Show();
            form1.buscar_y_actualizar(sID,sDireccion,sTelefono);
            Close();
        }

        private void boton_cancelar_Click(object sender, EventArgs e)
        {
            var form1 = (Sucursales.Sucursales_menu)Tag;
            form1.Enabled = true;
            form1.Show();
            Close();
        }
    }
}
