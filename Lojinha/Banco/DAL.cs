using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lojinha.Banco
{
    public abstract class DAL<T> where T : class
    {
        protected readonly LojinhaContext context;

        public DAL(LojinhaContext context)
        {
            this.context = context;
        }

        public IEnumerable<T> Listar()
        {
            return context.Set<T>().ToList();
        }
        public T? BuscarPorId(object id) // object é usado porque o EF permite vários tipos de chave. (int, string, etc.)
        {
            return context.Set<T>().Find(id);
        }
        public T? BuscarPor(Func<T, bool> condicao) // <Tipo, retorno>
        {
            return context.Set<T>().FirstOrDefault(condicao);
        }

        public void Adicionar(T objeto)
        {
            context.Set<T>().Add(objeto);
            context.SaveChanges();
        }
        public void Deletar(T objeto)
        {
            context.Set<T>().Remove(objeto);
            context.SaveChanges();

        }
        public void Atualizar(T entity)
        {
            context.Set<T>().Update(entity);
            context.SaveChanges();
        }
    }
}
