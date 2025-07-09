using System.ComponentModel.DataAnnotations;

namespace LojaApi.Models
{
    public class Produto
    {
        public Produto()
        {
            DataCadastro = DateTime.Now;
        }
        [Key]
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "O nome do produto é obrigatório.")]
        [StringLength(80, ErrorMessage = "O nome do produto deve ter no máximo 80 caracteres.")]
        public string? Nome { get; set; }

        [Required]
        [StringLength(300, ErrorMessage = "Atingiu o tamanho máximo de caracteres.")]
        public string? Descricao { get; set; }
        public decimal Preco { get; set; }
        public string? ImagemUrl { get; set; }
        public int Estoque { get; set; }

        public int CategoriaId { get; set; }

        public Categoria? Categoria { get; set; }

        public DateTime DataCadastro { get; set; }

    }
}
