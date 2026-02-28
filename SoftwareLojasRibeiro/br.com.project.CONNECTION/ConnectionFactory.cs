using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SoftwareLojasRibeiro.br.com.project.CONNECTION
{
    public class ConnectionFactory
    {
        //Metodo que conecta o Banco de Dados
        public MySqlConnection GetConnection()
        {
            //Acesso ao App.config
            string baseConnection = ConfigurationManager.ConnectionStrings["DB_LOJA"].ConnectionString;

            string server = Environment.GetEnvironmentVariable("DB_SERVER_MYSQL") ?? "localhost";
            string user = Environment.GetEnvironmentVariable("DB_USER_MYSQL") ?? "root";
            string password = Environment.GetEnvironmentVariable("DB_PASSWORD_MYSQL") ?? "root";

            string finalConnection = $"{baseConnection};server={server};user ID={user};password={password}";
            
            return new MySqlConnection(finalConnection);
        }
    }
}
