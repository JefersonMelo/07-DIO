using System;

namespace Catalogo_Api.Exceptions
{
    public class LivroJaCadastradoException : Exception
    {
        public LivroJaCadastradoException( )
            : base("Este livro já está cadastrado")
        { }
    }
}
