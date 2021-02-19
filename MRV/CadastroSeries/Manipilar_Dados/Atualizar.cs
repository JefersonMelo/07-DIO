using System;

namespace CadastroSeries
{
    public class Atualizar
    {
        static SerierepositorioSeries repositorioSeries = new SerierepositorioSeries();
        static RepositorioSeriesFilmes repFilmes = new RepositorioSeriesFilmes();

        private int EntradaGenero { get; set; }
        private string EntradaTitulo { get; set; }
        private int EntradaAno { get; set; }
        private string EntradaDescricao { get; set; }
        private int Indice { get; set; }

        // Manipulação Séries Opção 3
        public void AtualizarSerie( int indiceSerie, int entradaGenero, string entradaTitulo, int entradaAno, string entradaDescricao )
        {
            this.EntradaGenero = entradaGenero;
            this.EntradaTitulo = entradaTitulo;
            this.EntradaAno = entradaAno;
            this.EntradaDescricao = entradaDescricao;
            this.Indice = indiceSerie;

            Serie atualizaSerie = new Serie(id: this.Indice,
                                        genero: (Genero)this.EntradaGenero,
                                        titulo: this.EntradaTitulo,
                                        ano: this.EntradaAno,
                                        descricao: this.EntradaDescricao);

            repositorioSeries.Atualizar(indiceSerie, atualizaSerie);
        }

        // Manipulação Filmes Opção 3
        public void AtualizarFilme( int indiceSerie, int entradaGenero, string entradaTitulo, int entradaAno, string entradaDescricao )
        {
            this.EntradaGenero = entradaGenero;
            this.EntradaTitulo = entradaTitulo;
            this.EntradaAno = entradaAno;
            this.EntradaDescricao = entradaDescricao;
            this.Indice = indiceSerie;

            Filme atualizaFilme = new Filme(id: this.Indice,
                                        genero: (Genero)this.EntradaGenero,
                                        titulo: this.EntradaTitulo,
                                        ano: this.EntradaAno,
                                        descricao: this.EntradaDescricao);

            repFilmes.Atualizar(indiceSerie, atualizaFilme);
        }

    }
}
