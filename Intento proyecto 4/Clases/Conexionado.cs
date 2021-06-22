using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Intento_proyecto_4.Clases
{
    class Conexionado
    {
        MySqlConnection conexao;

        public Conexionado()
        {
            MySqlConnectionStringBuilder login = new MySqlConnectionStringBuilder();
            login.UserID = "root";
            login.Password = "1955";
            login.Server = "localhost";
            login.Database = "puntodeventas";

            conexao = new MySqlConnection(login.ToString());
        }

        public void AbrirConexion()
        {
            conexao.Open();
        }

        public void CerrarConexion()
        {
            conexao.Close();
        }

        public MySqlConnection ObtenerConexao()
        {
            return conexao;
        }
    }
}
