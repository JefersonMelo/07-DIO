using System;

namespace Api_Catalogo.Exceptions
{
    public class LivroJaCadastradoException : Exception
    {
        public LivroJaCadastradoException( )
            : base("Este já livro está cadastrado")
        { }
    }
}
