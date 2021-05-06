using System.ComponentModel.DataAnnotations;

namespace Api_Catalogo.InputModel
{
    public class LivroInputModel
    {
        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O NomeAutor do livro deve conter entre 3 e 100 caracteres")]
        public string NomeAutor { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "O Título do Livro deve conter entre 3 e 100 caracteres")]
        public string Titulo { get; set; }

        [Required]
        [StringLength(1000, MinimumLength = 1, ErrorMessage = "A Descrição do Livro deve conter entre 3 e 1000 caracteres")]
        public string Descricao { get; set; }

        [Required]
        [Range(1, 1000, ErrorMessage = "O preço deve ser de no mínimo 1 real e no máximo 1000 reais")]
        public double Preco { get; set; }
    }
}
