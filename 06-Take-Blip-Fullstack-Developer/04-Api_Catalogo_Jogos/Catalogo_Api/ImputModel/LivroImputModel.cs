using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Catalogo_Api.ImputModel
{
    public class LivroImputModel
    {
        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O Título do Livro deve conter no mínimo 3 e no máximo 100 catacteres")]
        public string Titulo { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O Nome do Autor deve conter no mínimo 3 e no máximo 100 catacteres")]
        public string Autor { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O Nome da Editora deve conter no mínimo 3 e no máximo 100 catacteres")]
        public string Editora { get; set; }

        [Required]
        [StringLength(500, MinimumLength = 3, ErrorMessage = "O Prefácio deve conter no mínimo 100 e no máximo 500 catacteres")]
        public string Prefacio { get; set; }

        [Required]
        [Range(1, 18, ErrorMessage = "A Classificação deve ser no mínimo 1 e máximo 18 anos")]
        public int Classificacao { get; set; }

        [Required]
        [Range(1, 1000, ErrorMessage = "O Preço deve ser no mínimo R$1,00 e no máximo R$1.000,00")]
        public double Preco { get; set; }
    }
}
