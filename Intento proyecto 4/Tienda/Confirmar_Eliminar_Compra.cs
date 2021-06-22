using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intento_proyecto_4.Tienda
{
    public partial class Confirmar_Eliminar_Compra : Form
    {
        Clases.FuncionesTienda funciones = new Clases.FuncionesTienda();
        string ID_de_compra_a_eliminar { get; set; }

        public Confirmar_Eliminar_Compra(string ID_de_compra)
        {
            InitializeComponent();
            ID_de_compra_a_eliminar = ID_de_compra;
        }

        private void boton_aceptar_Click(object sender, EventArgs e)
        {
            //Eliminar compra seleccionada
            funciones.EliminarCompra(ID_de_compra_a_eliminar);

            var form1 = (Tienda.Tienda_seleccionar_compra)Tag;
            form1.Enabled = true;
            form1.Show();
            form1.CargarComboBox();
            form1.limpiarComboBox();
            Close();
        }

        private void boton_cancelar_Click(object sender, EventArgs e)
        {
            var form1 = (Tienda.Tienda_seleccionar_compra)Tag;
            form1.Enabled = true;
            form1.Show();
            Close();
        }

        private void Confirmar_Eliminar_Compra_Load(object sender, EventArgs e)
        {

        }
    }
}
