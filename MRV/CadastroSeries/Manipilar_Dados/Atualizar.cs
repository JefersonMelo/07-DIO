using System;

namespace CadastroSeries
{
    public class Atualizar
    {
        //static SerierepositorioSeries repositorioSeries = new SerierepositorioSeries();
        static RepositorioSeriesFilmes repFilmes = new RepositorioSeriesFilmes();

        private int EntradaGenero { get; set; }
        private string EntradaTitulo { get; set; }
        private int EntradaAno { get; set; }
        private string EntradaDescricao { get; set; }
        private int Indice { get; set; }

        // Manipulação Séries Opção 3
        public void AtualizarSerie( )
        {
            SerierepositorioSeries repositorioSeries = new SerierepositorioSeries();
            //Console.Write("\nDigite o Gênero Entre as Opções Acima: ");
            EntradaGenero = int.Parse(Console.ReadLine());
            Console.Write("\nDigite o Id da Série: ");
            Indice = int.Parse(Console.ReadLine());
            Console.Write("\nDigite o Título da Série: ");
            EntradaTitulo = Console.ReadLine();
            Console.Write("\nDigite o Ano de Início da Série: ");
            EntradaAno = int.Parse(Console.ReadLine());
            Console.Write("\nDigite a Descrição da Série: ");
            EntradaDescricao = Console.ReadLine();
            //this.EntradaGenero = entradaGenero;
            //this.EntradaTitulo = entradaTitulo;
            //this.EntradaAno = entradaAno;
            //this.EntradaDescricao = entradaDescricao;
            //this.Indice = indice;

            Serie atualizaSerie = new Serie(id: Indice,
                                        genero: (Genero)EntradaGenero,
                                        titulo: EntradaTitulo,
                                        ano: EntradaAno,
                                        descricao: EntradaDescricao);

            repositorioSeries.Atualizar(this.Indice, atualizaSerie);
        }

        // Manipulação Filmes Opção 3
        public void AtualizarFilme( int indice, int entradaGenero, string entradaTitulo, int entradaAno, string entradaDescricao )
        {
            this.EntradaGenero = entradaGenero;
            this.EntradaTitulo = entradaTitulo;
            this.EntradaAno = entradaAno;
            this.EntradaDescricao = entradaDescricao;
            this.Indice = indice;

            Filme atualizaFilme = new Filme(id: this.Indice,
                                        genero: (Genero)this.EntradaGenero,
                                        titulo: this.EntradaTitulo,
                                        ano: this.EntradaAno,
                                        descricao: this.EntradaDescricao);

            repFilmes.Atualizar(this.Indice, atualizaFilme);
        }

    }
}
