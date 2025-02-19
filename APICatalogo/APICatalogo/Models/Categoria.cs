using Microsoft.VisualBasic;
using System.Collections.ObjectModel;

namespace APICatalogo.Models
{
    public class Categoria
    {
        public Categoria() 
        {
            Produtos = new Collection<Produto>();
            //Inicializando a coleção de produtos dentro da categoria
        }

        public int CategoriaId { get; set; }
        public string? CategoriaNome { get; set; }
        public string? ImagemUrl { get; set; }

        public ICollection<Produto>? Produtos { get; set; }
        //Uma categoria pode ter uma coleção de produtos
    }
}
