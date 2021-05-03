using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalogo_Api.Exceptions
{
    public class LivroNaoCadastradoException : Exception
    {
        public LivroNaoCadastradoException( )
            : base("Este livro não está cadastrado")
        { }
    }
}
