using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroSeries
{
    public class RepositorioFilmes : IRepositorio<Filme>
    {
        private List<Filme> listaFilmes = new List<Filme>();

        public void Atualizar( int id, Filme objeto )
        {
            throw new NotImplementedException();
        }

        public void Excluir( int id )
        {
            throw new NotImplementedException();
        }

        public void Inserir( Filme objeto )
        {
            throw new NotImplementedException();
        }

        public List<Filme> Lista( )
        {
            throw new NotImplementedException();
        }

        public int ProximoId( )
        {
            throw new NotImplementedException();
        }

        public Filme RetornarId( int id )
        {
            throw new NotImplementedException();
        }
    }
}
