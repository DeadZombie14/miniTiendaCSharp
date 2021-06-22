using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Intento_proyecto_4.Clases
{
    class FuncionesCatalogo
    {
        Clases.Conexionado conexao = new Clases.Conexionado();
        public string id_producto { get; set; }
        public string precio { get; set; }
        public string descripcion { get; set; }
        public string cantidad_en_existencia { get; set; }

        public FuncionesCatalogo()
        {

        }

        public void AnadirProducto(  string Precio_producto, string desc_producto, string cantidad_en_existencia )
        {
            String query = "INSERT INTO productos (Precio,Descripcion,Cantidad_en_existencia) values (" +
                                                         Precio_producto + ",'" +
                                                         desc_producto + "'," +
                                                         cantidad_en_existencia +
                                                         ")";
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
                //  MessageBox.Show("' Error, comprueba los datos ingresados y verifica que no estén repetidos. '");
                MessageBox.Show(ex.Message);
            }
            
        }

        public void eliminarProducto(String id_producto)
        {
            string query = "DELETE FROM productos WHERE ID_producto="+ id_producto +"";
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
                MessageBox.Show("ERROR: Este producto es solicitado en una o más compras; porfavor, elimine esas compras para poder eliminar este producto de la lista");
            }
            
        }

        public IList<FuncionesCatalogo> BuscarProducto(string pIdProducto, string pPrecio, string pDescripcionProducto, string pCantidad)
        {
            conexao.AbrirConexion();
            string where = " WHERE ";
            string AND = " AND ";
            string tieneDescripcion = "Descripcion LIKE '" + pDescripcionProducto + "'";
            string tienePrecio = "Precio LIKE " + pPrecio + "";
            string tieneID = "ID_producto LIKE " + pIdProducto + "";
            string tieneCantidad = "Cantidad_en_existencia LIKE " + pCantidad + "";

            string query = "";
            if (pIdProducto == string.Empty)
            {
                if (pDescripcionProducto == string.Empty)
                {
                    if (pPrecio == string.Empty)
                    {
                        if (pCantidad == string.Empty)
                        {   //No hacer nada
                            //productos.Actualizar_productos();
                            query = "SELECT * FROM productos";
                        }
                        else
                        {
                            //Buscar por cantidad
                            query = "SELECT * FROM productos " + where + tieneCantidad + "";
                        }
                    }
                    else
                    {
                        if (pCantidad == string.Empty)
                        {
                            //Buscar por precio
                            query = "SELECT * FROM productos " + where + tienePrecio + "";
                        }
                        else
                        {
                            //Buscar por precio & cantidad
                            query = "SELECT * FROM productos " + where + tienePrecio + AND + tieneCantidad + "";
                        }
                            
                    }
                }
                else
                {
                    if (pPrecio == string.Empty)
                    {
                        if (pCantidad == string.Empty)
                        {
                            //Buscar por descripcion
                            query = "SELECT * FROM productos " + where + tieneDescripcion + "";
                        }
                        else
                        {
                            //Buscar por descripcion & cantidad
                            query = "SELECT * FROM productos " + where + tieneDescripcion + AND + tieneCantidad + "";
                        }
                    }
                    else
                    {
                        if (pCantidad == string.Empty)
                        {
                            //Buscar por descripcion & precio
                            query = "SELECT * FROM productos " + where + tieneDescripcion + AND + tienePrecio + "";
                        }
                        else
                        {
                            //Buscar por descripcion, precio & cantidad
                            query = "SELECT * FROM productos " + where + tieneDescripcion + AND + tienePrecio + AND + tieneCantidad + "";
                        }
                    }
                }
            }
            else
            {
                if (pDescripcionProducto == string.Empty)
                {
                    if (pPrecio == string.Empty)
                    {
                        if (pCantidad == string.Empty)
                        {
                            //Buscar por ID
                            query = "SELECT *  FROM productos " + where + tieneID + "";
                        }
                        else
                        {
                            //Buscar por ID & cantidad
                            query = "SELECT *  FROM productos " + where + tieneID + AND + tieneCantidad + "";
                        }
                    }
                    else
                    {
                        if (pCantidad == string.Empty)
                        {
                            //Buscar por ID & precio
                            query = "SELECT *  FROM productos " + where + tieneID + AND + tienePrecio + "";
                        }
                        else
                        {
                            //Buscar por ID & precio & cantidad
                            query = "SELECT *  FROM productos " + where + tieneID + AND + tienePrecio + AND + tieneCantidad + "";
                        }
                    }
                }
                else
                {
                    if (pPrecio == string.Empty)
                    {
                        if (pCantidad == string.Empty)
                        {
                            //Buscar por ID & descripcion
                            query = "SELECT * FROM productos " + where + tieneID + AND + tieneDescripcion + "";
                        }
                        else
                        {
                            //Buscar por ID, descripcion y cantidad
                            query = "SELECT * FROM productos " + where + tieneID + AND + tieneDescripcion + AND + tieneCantidad + "";
                        }
                    }
                    else
                    {
                        if (pCantidad == string.Empty)
                        {
                            //Buscar por ID, descripcion y precio
                            query = "SELECT * FROM productos " + where + tieneID + AND + tieneDescripcion + AND + tienePrecio + "";
                        }
                        else
                        {
                            //Buscar usando TODOS los campos
                            query = "SELECT * FROM productos " + where + tieneID + AND + tieneDescripcion + AND + tienePrecio + AND + tieneCantidad + "";
                        }
                    }
                }
            }

            List<FuncionesCatalogo> lista = new List<FuncionesCatalogo>();
            MySqlCommand comando = new MySqlCommand(query, conexao.ObtenerConexao());
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                FuncionesCatalogo pProductosTabla = new FuncionesCatalogo();
                pProductosTabla.id_producto = reader.GetString(0);
                pProductosTabla.precio = reader.GetString(1);
                pProductosTabla.descripcion = reader.GetString(2);
                pProductosTabla.cantidad_en_existencia = reader.GetString(3);

                lista.Add(pProductosTabla);
            }
            conexao.CerrarConexion();
            return lista;
        }


        public void EditarProducto(string id_producto, string id_nueva, string precio_nuevo, string desc_nueva, string cant_nueva)
        {
            //Editar un producto y guardarlo

            string query = "UPDATE productos SET ID_producto= "+ id_nueva +", Precio="+ precio_nuevo +", Descripcion='"+ desc_nueva + "', Cantidad_en_existencia=" + cant_nueva + "  WHERE ID_producto=" + id_producto + "";
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
    }
}
