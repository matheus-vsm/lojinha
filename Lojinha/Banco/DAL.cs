using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lojinha.Banco
{
    public class DAL<T> where T : class
    {
        private readonly LojinhaContext context;

        public DAL(LojinhaContext context)
        {
            this.context = context;
        }
    }
}
