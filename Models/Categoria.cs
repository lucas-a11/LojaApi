using System.ComponentModel.DataAnnotations;

namespace LojaApi.Models
{
    public class Categoria
    {
        public Categoria()
        {
            Produtos = new List<Produto>();
        }
        [Key]
        public int CategoriaId { get; set; }
        [Required(ErrorMessage = "O nome da categoria é obrigatório.")]
        [StringLength(80, ErrorMessage = "O nome da categoria deve ter no máximo 80 caracteres.")]
        public string? Nome { get; set; }
        [Required]
        [StringLength(300, ErrorMessage = "Atingiu o tamanho maximo de caractares.")]
        public string? ImagemUrl { get; set; }

        public List<Produto>? Produtos { get; set; } = new List<Produto>();
    }

    

}
