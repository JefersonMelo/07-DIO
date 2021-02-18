using System.Collections.Generic;

namespace CadastroSeries
{
    public interface IRepositorio<T>
    {
        // Padrão de Repositório, Design Patterns
        List<T> Lista( );
        T RetornarId( int id );
        void Inserir( T objeto );
        void Excluir( int id );
        void Atualizar( int id, T objeto );
        int ProximoId( );

    }
}
