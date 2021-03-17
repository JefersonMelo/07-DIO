using System;

namespace CadastroSeries
{
    public class Atualizar
    {
        //static SerierepositorioSeries repositorioSeries = new SerierepositorioSeries();
        //static RepositorioSeriesFilmes repFilmes = new RepositorioSeriesFilmes();

        private int EntradaGenero { get; set; }
        private string EntradaTitulo { get; set; }
        private int EntradaAno { get; set; }
        private string EntradaDescricao { get; set; }
        private int Indice { get; set; }

        // Manipulação Séries Opção 3
        public void AtualizarSerie( int indice)
        {
            SerierepositorioSeries repositorioSeries = new SerierepositorioSeries();
            Indice = indice;
            EntradaGenero = int.Parse(Console.ReadLine());
            Console.Write("\nDigite o Título da Série: ");
            EntradaTitulo = Console.ReadLine();
            Console.Write("\nDigite o Ano de Início da Série: ");
            EntradaAno = int.Parse(Console.ReadLine());
            Console.Write("\nDigite a Descrição da Série: ");
            EntradaDescricao = Console.ReadLine();

            Serie atualizaSerie = new Serie(id: Indice,
                                        genero: (Genero)EntradaGenero,
                                        titulo: EntradaTitulo,
                                        ano: EntradaAno,
                                        descricao: EntradaDescricao);

            repositorioSeries.Atualizar(Indice, atualizaSerie);
        }

        // Manipulação Filmes Opção 3
        public void AtualizarFilme( int indice )
        {
            RepositorioSeriesFilmes repFilmes = new RepositorioSeriesFilmes();

            Indice = indice;
            EntradaGenero = int.Parse(Console.ReadLine());
            Console.Write("\nDigite o Título da Série: ");
            EntradaTitulo = Console.ReadLine();
            Console.Write("\nDigite o Ano de Início da Série: ");
            EntradaAno = int.Parse(Console.ReadLine());
            Console.Write("\nDigite a Descrição da Série: ");
            EntradaDescricao = Console.ReadLine();

            Filme atualizaFilme = new Filme(id: Indice,
                                        genero: (Genero)EntradaGenero,
                                        titulo: EntradaTitulo,
                                        ano: EntradaAno,
                                        descricao: EntradaDescricao);

            repFilmes.Atualizar(Indice, atualizaFilme);
        }

    }
}
