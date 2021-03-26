using System.Collections.Generic;

namespace CadastroSeries
{
    public class RepositorioSeriesFilmes : IRepositorioSeries<Filme>
    {
        private List<Filme> listaFilmes = new List<Filme>();

        public void Atualizar( int id, Filme objeto )
        {
            listaFilmes[id] = objeto;
        }

        public void Excluir( int id )
        {
            listaFilmes[id].Excluir();
        }

        public void Inserir( Filme objeto )
        {
            listaFilmes.Add(objeto);
        }

        public List<Filme> Lista( )
        {
            return listaFilmes;
        }

        public int ProximoId( )
        {
            return listaFilmes.Count;
        }

        public Filme RetornarId( int id )
        {
            return listaFilmes[id];
        }
    }
}
