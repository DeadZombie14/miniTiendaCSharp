using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Intento_proyecto_4.Clases
{
    class FuncionesSucursales
    {
        Clases.Conexionado conexao = new Clases.Conexionado();
        public string id_sucursal { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }

        public FuncionesSucursales()
        {

        }

        public void AnadirSucursal(string id_sucursal, string direccion, string telefono)
        {
            String query = "INSERT INTO sucursales values (" +
                                                         id_sucursal + ",'" +
                                                         direccion + "'," +
                                                         telefono +
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
        public void AnadirSucursal(string direccion, string telefono)
        {
            String query = "INSERT INTO sucursales (Direccion,Telefono) values ('" +
                                                         direccion + "'," +
                                                         telefono +
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

        public void eliminarSucursal(String id_sucursal)
        {
            string query = "DELETE FROM sucursales WHERE ID_sucursal="+ id_sucursal+"";
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

        public IList<FuncionesSucursales> BuscarSucursal(string sID, string sDireccion, string sTelefono)
        {
            conexao.AbrirConexion();
            string where = " WHERE ";
            string AND = " AND ";
            string tieneID = "ID_sucursal LIKE " + sID + "";
            string tieneDireccion = "Direccion LIKE '" + sDireccion + "'";
            string tieneTelefono = "Telefono LIKE " + sTelefono + "";

            string query = "";
            if (sID == string.Empty)
            {
                if (sDireccion == string.Empty)
                {
                    if (sTelefono == string.Empty)
                    {
                        //No hacer nada
                        //sucursales.Actualizar_sucursales();
                        query = "SELECT * FROM sucursales";
                    }
                    else
                    {
                        query = "SELECT * FROM sucursales " + where + tieneTelefono + "";
                    }
                }
                else
                {

                    if (sTelefono == string.Empty)
                    {
                        query = "SELECT * FROM sucursales " + where + tieneDireccion + "";
                    }
                    else
                    {
                        query = "SELECT * FROM sucursales " + where + tieneDireccion + AND + tieneTelefono + "";
                    }
                }
            }
            else
            {
                if (sDireccion == string.Empty)
                {
                    if (sTelefono == string.Empty)
                    {
                        query = "SELECT * FROM sucursales " + where + tieneID + "";
                    }
                    else
                    {
                        query = "SELECT * FROM sucursales " + where + tieneID + AND + tieneTelefono + "";
                    }
                }
                else
                {
                    if (sTelefono == string.Empty)
                    {
                        query = "SELECT * FROM sucursales " + where + tieneID + AND + tieneDireccion + "";
                    }
                    else
                    {
                        query = "SELECT * FROM sucursales " + where + tieneID + AND + tieneDireccion + AND + tieneTelefono + "";
                    }
                }
            }

            List<FuncionesSucursales> lista = new List<FuncionesSucursales>();
            MySqlCommand comando = new MySqlCommand(query, conexao.ObtenerConexao());
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                FuncionesSucursales pProductosTabla = new FuncionesSucursales();
                pProductosTabla.id_sucursal = reader.GetString(0);
                pProductosTabla.direccion = reader.GetString(1);
                pProductosTabla.telefono = reader.GetString(2);

                lista.Add(pProductosTabla);
            }
            conexao.CerrarConexion();
            return lista;
        }


        public void EditarSucursal(string id_sucursal, string id_nueva, string direccion, string telefono)
        {
            //Editar una sucursal y guardarla

            string query = "UPDATE sucursales SET ID_sucursal= "+ id_nueva +", Direccion='"+ direccion +"', Telefono="+ telefono + "  WHERE ID_sucursal=" + id_sucursal + "";
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
