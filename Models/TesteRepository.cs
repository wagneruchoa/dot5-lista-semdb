using System.Collections.Generic;

namespace mvc1.Models
{
    public class TesteRepository : IRepository
    {
        private static Produto[] produtos = new Produto[]
        {
            new Produto { IdProduto=10, Nome="Caneta", Categoria="Material", Preco=2.0M},
            new Produto { IdProduto=20, Nome="Borracha", Categoria="Material", Preco=1.5M},
            new Produto { IdProduto=30, Nome="Estojo", Categoria="Material", Preco=3.0M}
        };

        public IEnumerable<Produto> Produtos { get => produtos; }
    }
}