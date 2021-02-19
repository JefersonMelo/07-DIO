using System;

namespace CadastroSeries
{
    public class Listar
    {
        public Listar( ) { }

        static SerieRepositorio repositorio = new SerieRepositorio();
        static RepositorioFilmes repFilmes = new RepositorioFilmes();

        // Manipular Séries Opção 1 
        public void ListarSeries( )
        {
            Console.WriteLine("\nListar Séries");

            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("\nNenhuma Série Cadastrada.");
                return;
            }

            foreach (var serie in lista)
            {
                var excluido = serie.RetornarExcluido();

                //Console.WriteLine("#ID {0}: - {1} {2}", serie.RetornarId(), serie.RetornarTitulo(), (excluido ? "*Excluído*" : ""));

                Console.WriteLine($"#ID: {serie.RetornarId()}: - " +
                                  $"{serie.RetornarTitulo()} " +
                                  $"{(excluido ? "*Excluído*" : "")}");
            }
        }

        // Manipular Filmes Opção 1 
        public void ListarFilmes( )
        {
            Console.WriteLine("\nListar Filmes");

            var lista = repFilmes.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("\nNenhum Filme Cadastrado.");
                return;
            }

            foreach (var filme in lista)
            {
                var excluido = filme.RetornarExcluido();

                Console.WriteLine($"#ID: {filme.RetornarId()}: - " +
                                  $"{filme.RetornarTitulo()} " +
                                  $"{(excluido ? "*Excluído*" : "")}");
            }
        }
    }
}
