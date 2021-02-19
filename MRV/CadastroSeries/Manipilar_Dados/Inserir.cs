namespace CadastroSeries
{
    public class Inserir
    {
        static SerierepositorioSeries repositorioSeries = new SerierepositorioSeries();
        static RepositorioSeriesFilmes repFilmes = new RepositorioSeriesFilmes();

        private int EntradaGenero { get; set; }
        private string EntradaTitulo { get; set; }
        private int EntradaAno { get; set; }
        private string EntradaDescricao { get; set; }

        // Manipular Séries Opção 2
        public void InserirSerie( int entradaGenero, string entradaTitulo, int entradaAno, string entradaDescricao )
        {
            this.EntradaGenero = entradaGenero;
            this.EntradaTitulo = entradaTitulo;
            this.EntradaAno = entradaAno;
            this.EntradaDescricao = entradaDescricao;

            Serie novaSerie = new Serie(id: repositorioSeries.ProximoId(),
                                        genero: (Genero)this.EntradaGenero,
                                        titulo: this.EntradaTitulo,
                                        ano: this.EntradaAno,
                                        descricao: this.EntradaDescricao);

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
