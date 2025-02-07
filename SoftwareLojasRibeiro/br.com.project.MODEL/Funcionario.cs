using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareLojasRibeiro.br.com.project.MODEL
{
    public class Funcionario : Cliente
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Tipo { get; set; }
    }
}
