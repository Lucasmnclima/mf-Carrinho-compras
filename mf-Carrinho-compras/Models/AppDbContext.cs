using CarrinhoDeComprasGestaoSalao.Models;
using Microsoft.EntityFrameworkCore;

namespace mf_Carrinho_compras.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Salao> Saloes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}
