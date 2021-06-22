using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Intento_proyecto_4.Clases
{
    class FuncionesTienda
    {
        Clases.Conexionado conexao = new Clases.Conexionado();
        public string id_vendedor { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string direccion { get; set; }
        public string id_sucursal { get; set; }

        public FuncionesTienda()
        {

        }

        public void AnadirProductoAlCarrito(string ID_compra, string ID_producto, string cantidad_solicitada)
        {
            String query = "INSERT INTO detallescompra values (" +
                                                         ID_producto + "," + cantidad_solicitada + "," + ID_compra + ")";
            try
            {
                MySqlCommand cmd = conexao.ObtenerConexao().CreateCommand();
                cmd.CommandText = query;
                conexao.AbrirConexion();
                cmd.ExecuteNonQuery();
                conexao.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Ya habias ingresado este producto antes. Para ordenar mas, borre y a continuación reañada el producto.");
                //MessageBox.Show(ex.Message);
            }
            
        }

        public void QuitarProductoDelCarrito(String id_producto)
        {
            string query = "DELETE FROM detallescompra WHERE productos_ID_producto="+ id_producto +"";
            try
            {
                MySqlCommand cmd = conexao.ObtenerConexao().CreateCommand();
                cmd.CommandText = query;
                conexao.AbrirConexion();
                cmd.ExecuteNonQuery();
                conexao.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void EliminarCompra(string ID_de_compra_a_eliminar)
        {
            string query1 = "DELETE FROM detallescompra WHERE Compras_ID_compra=" + ID_de_compra_a_eliminar + "";
            string query2 = "DELETE FROM Compras WHERE ID_compra=" + ID_de_compra_a_eliminar + "";
            try
            {
                MySqlCommand cmd = conexao.ObtenerConexao().CreateCommand();
                cmd.CommandText = query1;
                conexao.AbrirConexion();
                cmd.ExecuteNonQuery();
                cmd.CommandText = query2;
                cmd.ExecuteNonQuery();
                conexao.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
