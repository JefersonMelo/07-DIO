using System;

namespace Catalogo_Api.Exceptions
{
    public class LivroNaoCadastradoException : Exception
    {
        public LivroNaoCadastradoException( )
            : base("Este livro não está cadastrado")
        { }
    }
}
