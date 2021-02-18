using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroSeries.Interfaces
{
    public interface IRepositorio<T>
    {
        // Padrão de Repositório, Design Patterns
        List<T> Lista( );
        T RetornarId(int id);
        void Inserir( T objeto );
        void Excuir( int id );
        void Atualizar( int id, T objeto );
        int ProximoId( );

    }
}
