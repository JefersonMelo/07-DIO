using System;

namespace Api_Catalogo.Exceptions
{
    public class LivroNaoCadastradoException : Exception
    {
        public LivroNaoCadastradoException( )
            : base("Este livro não está cadastrado")
        { }
    }
}
