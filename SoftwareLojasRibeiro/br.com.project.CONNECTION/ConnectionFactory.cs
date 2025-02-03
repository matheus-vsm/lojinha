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
            string conecction = ConfigurationManager.ConnectionStrings["dblojasribeiro"].ConnectionString;
            
            return new MySqlConnection(conecction);
        }
    }
}
