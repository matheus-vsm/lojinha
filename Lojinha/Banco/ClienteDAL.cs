using Lojinha.Modelos;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lojinha.Banco
{
    public class ClienteDAL
    {
        private readonly LojinhaContext context; //para conseguir ser acessado pelas classes que herdam dela

        public ClienteDAL(LojinhaContext context)
        {
            this.context = new LojinhaContext(); // inicializa o contexto do banco de dados
        }

        public IEnumerable<Cliente> Listar()
        {
            return context.Clientes.ToList();
        }

        public void Adicionar(Cliente cliente)
        {
            context.Clientes.Add(cliente);
            context.SaveChanges();
        }

        public void Deletar(int id)
        {
            var cliente = context.Clientes.Find(id);
            if (cliente != null)
            {
                context.Clientes.Remove(cliente);
                context.SaveChanges();
            }
        }

        public void Atualizar(Cliente cliente)
        {
            context.Clientes.Update(cliente);
            context.SaveChanges();
        }
    }
}
