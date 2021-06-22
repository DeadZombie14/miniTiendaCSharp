using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Intento_proyecto_4.Clases
{
    class FuncionesVendedores
    {
        Clases.Conexionado conexao = new Clases.Conexionado();
        public string id_vendedor { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string direccion { get; set; }
        public string id_sucursal { get; set; }

        public FuncionesVendedores()
        {

        }

        public void AnadirVendedor(string nombres, string Apellidos, string Direccion, string sucursal)
        {
            String query = "INSERT INTO vendedores (Nombres,Apellidos,Direccion,Sucursales_ID_sucursal) VALUES ('" +
                                                         nombres + "','" +
                                                         Apellidos + "','" +
                                                         Direccion + "'," +
                                                         sucursal +
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

        public void AnadirVendedor(string ID_vendedor,string nombres, string Apellidos, string Direccion, string sucursal)
        {
            String query = "INSERT INTO vendedores values (" +
                                                         ID_vendedor + ",'" +
                                                         nombres + "','" +
                                                         Apellidos + "','" +
                                                         Direccion + "'," +
                                                         sucursal +
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

        public void eliminarVendedor(String id_vendedor)
        {
            string query = "DELETE FROM vendedores WHERE ID_vendedor="+ id_vendedor +"";
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

        public IList<FuncionesVendedores> BuscarVendedor(string vID, string vNombres, string vApellidos, string vDireccion, string vID_sucursal)
        {
            conexao.AbrirConexion();
            string where = " WHERE ";
            string AND = " AND ";
            string acomodarCampos = "SELECT ID_vendedor,Nombres,Apellidos,Direccion,Sucursales_ID_sucursal Sucursal FROM vendedores";
            string tieneID = "ID_vendedor LIKE " + vID + "";
            string tieneNombres = "Nombres LIKE " + vNombres + "";
            string tieneApellidos = "Apellidos LIKE " + vApellidos + "";
            string tieneDireccion = "Direccion LIKE '" + vDireccion + "'";
            string tieneIDSucursal = "Sucursales_ID_sucursal LIKE " + vID_sucursal + "";

            string query = "";
            if(vID == string.Empty && vNombres == string.Empty && vApellidos == string.Empty && vDireccion == string.Empty && vID_sucursal == string.Empty)
            {
                //No hacer nada, no hay campos a buscar
                query = acomodarCampos;
            }
            if (vID != string.Empty && vNombres == string.Empty && vApellidos == string.Empty && vDireccion == string.Empty && vID_sucursal == string.Empty)
            {
                //Buscar usando solo la ID
                query = "" + acomodarCampos + where + tieneID + "";
            }
            if (vID != string.Empty && vNombres != string.Empty && vApellidos == string.Empty && vDireccion == string.Empty && vID_sucursal == string.Empty)
            {
                //Buscar usando la ID & los nombres
                query = "" + acomodarCampos + where + tieneID + AND + tieneNombres + "";
            }
            if (vID != string.Empty && vNombres != string.Empty && vApellidos != string.Empty && vDireccion == string.Empty && vID_sucursal == string.Empty)
            {
                //Buscar usando la ID & los nombres & los apellidos
                query = "" + acomodarCampos + where + tieneID + AND + tieneNombres + AND + tieneApellidos + "";
            }
            if (vID != string.Empty && vNombres != string.Empty && vApellidos != string.Empty && vDireccion != string.Empty && vID_sucursal == string.Empty)
            {
                //Buscar usando la ID & los nombres & los apellidos & la direccion
                query = "" + acomodarCampos + where + tieneID + AND + tieneNombres + AND + tieneApellidos + AND + tieneDireccion + "";
            }
            if (vID != string.Empty && vNombres != string.Empty && vApellidos != string.Empty && vDireccion != string.Empty && vID_sucursal != string.Empty)
            {
                //Buscar usando TODOS los campos
                query = "" + acomodarCampos + where + tieneID + AND + tieneNombres + AND + tieneApellidos + AND + tieneDireccion + AND + tieneIDSucursal + "";
            }

            /***************************************************************/

            if (vID == string.Empty && vNombres != string.Empty && vApellidos == string.Empty && vDireccion == string.Empty && vID_sucursal == string.Empty)
            {
                //Buscar usando solo los nombres
                query = "" + acomodarCampos + where + tieneNombres + "";
            }
            if (vID == string.Empty && vNombres != string.Empty && vApellidos != string.Empty && vDireccion == string.Empty && vID_sucursal == string.Empty)
            {
                //Buscar usando los nombres & apellidos
                query = "" + acomodarCampos + where + tieneNombres + AND + tieneApellidos + "";
            }
            if (vID == string.Empty && vNombres != string.Empty && vApellidos != string.Empty && vDireccion != string.Empty && vID_sucursal == string.Empty)
            {
                //Buscar usando los nombres & apellidos & la direccion
                query = "" + acomodarCampos + where + tieneNombres + AND + tieneApellidos + AND + tieneDireccion + "";
            }
            if (vID == string.Empty && vNombres != string.Empty && vApellidos != string.Empty && vDireccion != string.Empty && vID_sucursal != string.Empty)
            {
                //Buscar usando los nombres & apellidos & la direccion & la ID de sucursal
                query = "" + acomodarCampos + where + tieneNombres + AND + tieneApellidos + AND + tieneDireccion + AND + tieneIDSucursal + "";
            }

            /***************************************************************/

            if (vID == string.Empty && vNombres == string.Empty && vApellidos != string.Empty && vDireccion == string.Empty && vID_sucursal == string.Empty)
            {
                //Buscar usando solo los apellidos
                query = "" + acomodarCampos + where + tieneApellidos + "";
            }
            if (vID == string.Empty && vNombres == string.Empty && vApellidos != string.Empty && vDireccion == string.Empty && vID_sucursal == string.Empty)
            {
                //Buscar usando los apellidos & la direccion
                query = "" + acomodarCampos + where + tieneApellidos + AND + tieneDireccion + "";
            }
            if (vID == string.Empty && vNombres == string.Empty && vApellidos != string.Empty && vDireccion == string.Empty && vID_sucursal != string.Empty)
            {
                //Buscar usando los apellidos & la direccion & la ID de sucursal
                query = "" + acomodarCampos + where + tieneApellidos + AND + tieneDireccion + AND + tieneIDSucursal + "";
            }

            /***************************************************************/

            if (vID == string.Empty && vNombres == string.Empty && vApellidos == string.Empty && vDireccion != string.Empty && vID_sucursal == string.Empty)
            {
                //Buscar usando solo la direccion
                query = "" + acomodarCampos + where + tieneDireccion + "";
            }
            if (vID == string.Empty && vNombres == string.Empty && vApellidos == string.Empty && vDireccion != string.Empty && vID_sucursal != string.Empty)
            {
                //Buscar usando la direccion & la ID de sucursal
                query = "" + acomodarCampos + where + tieneDireccion + AND + tieneIDSucursal + "";
            }

            /***************************************************************/

            if (vID == string.Empty && vNombres == string.Empty && vApellidos == string.Empty && vDireccion == string.Empty && vID_sucursal != string.Empty)
            {
                //Buscar usando solo la ID de sucursal
                query = "" + acomodarCampos + where + tieneIDSucursal + "";
            }


            List<FuncionesVendedores> lista = new List<FuncionesVendedores>();
            MySqlCommand comando = new MySqlCommand(query, conexao.ObtenerConexao());
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                FuncionesVendedores vVendedoresTabla = new FuncionesVendedores();
                vVendedoresTabla.id_vendedor = reader.GetString(0);
                vVendedoresTabla.nombres = reader.GetString(1);
                vVendedoresTabla.apellidos = reader.GetString(2);
                vVendedoresTabla.direccion = reader.GetString(3);
                vVendedoresTabla.id_sucursal = reader.GetString(4);

                lista.Add(vVendedoresTabla);
            }
            conexao.CerrarConexion();
            return lista;
        }


        public void EditarVendedor(string id_vendedor, string id_nueva, string nombres_nuevos, string apellidos_nuevos, string direccion_nueva, string id_sucursal_nueva)
        {
            //Editar una sucursal y guardarla

            string query = "UPDATE vendedores SET ID_vendedor= "+ id_nueva +",Nombres='"+ nombres_nuevos + "', Apellidos='" + apellidos_nuevos + "', Direccion='" + direccion_nueva + "', Sucursales_ID_sucursal=" + id_sucursal_nueva + "  WHERE ID_vendedor=" + id_vendedor + "";
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
