using System.Collections.Generic;

namespace CadastroSeries
{
    public class SerierepositorioSeries : IRepositorioSeries<Serie>// Tipos Genéricos --> List <--
    {
        private List<Serie> listaSerie = new List<Serie>();

        public void Atualizar( int id, Serie objeto )
        {
            listaSerie[id] = objeto;
        }

        public void Excluir( int id )
        {
            /*
             * Não usar o -->RemoveAt<--, para não mudar o indice do vetor.
             * Nunca se deve excluir o dado
             */
            listaSerie[id].Excluir();
        }

        public void Inserir( Serie objeto )
        {
            listaSerie.Add(objeto);
        }

        public List<Serie> Lista( )
        {
            return listaSerie;
        }

        public int ProximoId( )
        {
            return listaSerie.Count;
        }

        public Serie RetornarId( int id )
        {
            return listaSerie[id];
        }
    }
}
