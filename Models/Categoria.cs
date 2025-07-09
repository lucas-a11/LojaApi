namespace LojaApi.Models
{
    public class Categoria
    {
        public Categoria()
        {
            Produtos = new List<Produto>();
        }
        public int CategoriaId { get; set; }
        public string? Nome { get; set; }
        public string? ImagemUrl { get; set; }

        public List<Produto>? Produtos { get; set; } = new List<Produto>();
    }

    

}
