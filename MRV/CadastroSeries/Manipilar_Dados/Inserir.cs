using System;

namespace CadastroSeries
{
    public class Inserir
    {
       //static SerierepositorioSeries repositorioSeries = new SerierepositorioSeries();
        static RepositorioSeriesFilmes repFilmes = new RepositorioSeriesFilmes();

        private int EntradaGenero { get; set; }
        private string EntradaTitulo { get; set; }
        private int EntradaAno { get; set; }
        private string EntradaDescricao { get; set; }

        // Manipular Séries Opção 2
        public void InserirSerie( )
        {
            SerierepositorioSeries repositorioSeries = new SerierepositorioSeries();
            //Console.Write("\nDigite o Gênero Entre as Opções Acima: ");
            EntradaGenero = int.Parse(Console.ReadLine());
            Console.Write("\nDigite o Título da Série: ");
            EntradaTitulo = Console.ReadLine();
            Console.Write("\nDigite o Ano de Início da Série: ");
            EntradaAno = int.Parse(Console.ReadLine());
            Console.Write("\nDigite a Descrição da Série: ");
            EntradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie(id: repositorioSeries.ProximoId(),
                                        genero: (Genero)EntradaGenero,
                                        titulo: EntradaTitulo,
                                        ano: EntradaAno,
                                        descricao: EntradaDescricao);

            repositorioSeries.Inserir(novaSerie);
        }

        // Manipular Filmes Opção 2
        public void InserirFilme( int entradaGenero, string entradaTitulo, int entradaAno, string entradaDescricao )
        {
            this.EntradaGenero = entradaGenero;
            this.EntradaTitulo = entradaTitulo;
            this.EntradaAno = entradaAno;
            this.EntradaDescricao = entradaDescricao;

            Filme novoFilme = new Filme(id: repFilmes.ProximoId(),
                                        genero: (Genero)this.EntradaGenero,
                                        titulo: this.EntradaTitulo,
                                        ano: this.EntradaAno,
                                        descricao: this.EntradaDescricao);

            repFilmes.Inserir(novoFilme);
        }
    }
}
