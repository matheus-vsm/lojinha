using Lojinha.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Lojinha.Banco
{
    public class LojinhaContext : DbContext
    {
        public DbSet<CategoriaProduto> CategoriaProdutos { get; set; }
        public DbSet<CategoriaPublico> CategoriaPublicos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<CompraProduto> ComprasProdutos { get; set; }
        public DbSet<Devedor> Devedores { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<ItemCompraProduto> ItensComprasProdutos { get; set; }
        public DbSet<ItemVenda> ItensVendas { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Venda> Vendas { get; set; }

        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Lojinha2;Integrated Security=True;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public LojinhaContext() { }

        public LojinhaContext(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configura o EF Core para usar o SQL Server como provedor de banco de dados e passa a string de conexão definida na variável 'connectionString'
            optionsBuilder
                .UseSqlServer(connectionString)
                .UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Esse comando faz o Entity Framework Core procurar automaticamentetodas as classes de configuração de entidades (que implementamIEntityTypeConfiguration<T>) dentro do mesmo assembly do LojinhaContext, aplicando essas configurações no modelo sem precisar registrar uma por uma.
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(LojinhaContext).Assembly);
        }
    }
}
