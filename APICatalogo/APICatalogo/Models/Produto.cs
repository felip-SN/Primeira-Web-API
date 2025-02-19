namespace APICatalogo.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string? ProdutoNome { get; set; }
        public string? ProdutoDescricao { get; set; }
        public decimal Preco { get; set; }
        public string? ImagemUrl { get; set; }
        public float Estoque { get; set; }
        public DateTime DataCadastro { get; set; }
        public int CategoriaId { get; set; }
        //O produto vai ter uma categoria
        public Categoria? Categoria { get; set; }
        //O produto vai ser mapeado pela categoria
    }
}
