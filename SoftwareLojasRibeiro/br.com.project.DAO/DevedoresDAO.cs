using MySql.Data.MySqlClient;
using SoftwareLojasRibeiro.br.com.project.CONNECTION;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareLojasRibeiro.br.com.project.DAO
{
    public class DevedoresDAO
    {
        private MySqlConnection connection;

        public DevedoresDAO()
        {
            this.connection = new ConnectionFactory().GetConnection();
        }
    }
}
