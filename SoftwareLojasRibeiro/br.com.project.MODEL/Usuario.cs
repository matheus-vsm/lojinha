using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareLojasRibeiro.br.com.project.MODEL
{
    public class Usuario
    {
        public static string User { get; set; }
        public static string Tipo { get; set; }

        public Usuario (Funcionario func)
        {
            User = func.Login;
            Tipo = func.Tipo;
        }
    }
}
