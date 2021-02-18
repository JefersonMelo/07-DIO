using System;
using System.Collections.Generic;
using System.Text;
using CadastroSeries.Interfaces;
using CadastroSeries.Enum;

namespace CadastroSeries.Classes
{
    public class SerieRepositorio : IRepositorio<Serie>// Tipos Genéricos --> List <--
    {
        private List<Serie> listaSerie = new List<Serie>();

        void IRepositorio<Serie>.Atualizar( int id, Serie objeto )
        {
            listaSerie[id] = objeto;
        }

        void IRepositorio<Serie>.Excuir( int id )
        {
            /*
             * Não usar o -->RemoveAt<--, para não mudar o indice do vetor.
             * Nunca se deve excluir o dado
             */
            listaSerie[id].Excluir();
        }

        void IRepositorio<Serie>.Inserir( Serie objeto )
        {
            listaSerie.Add(objeto);
        }

        List<Serie> IRepositorio<Serie>.Lista( )
        {
            return listaSerie;
        }

        int IRepositorio<Serie>.ProximoId( )
        {
            return listaSerie.Count;
        }

        Serie IRepositorio<Serie>.RetornarId( int id )
        {
            return listaSerie[id];
        }
    }
}
