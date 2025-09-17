using Lojinha.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lojinha.Shared.Data.Mapeamentos
{
    public class ItemCompraProdutoTypeConfiguration : IEntityTypeConfiguration<ItemCompraProduto>
    {
        public void Configure(EntityTypeBuilder<ItemCompraProduto> builder)
        {
            builder.HasKey(icp => icp.Id);
            builder.Property(icp => icp.Quantidade).IsRequired();
            builder.Property(icp => icp.PrecoCusto).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(i => i.Subtotal)
                .HasColumnType("decimal(18,2)")
                .HasComputedColumnSql("[Quantidade] * [PrecoCusto]");

            // Relacionamento 1:N -> ItemCompraProduto pertence a um Produto
            builder
                .HasOne(i => i.Produto)
                .WithMany(p => p.ItensCompras)
                .HasForeignKey(i => i.ProdutoId)
                .OnDelete(DeleteBehavior.Restrict);

            // Relacionamento 1:N -> ItemCompraProduto pertence a uma CompraProduto
            builder
                .HasOne(i => i.CompraProduto)
                .WithMany(c => c.Itens)
                .HasForeignKey(i => i.CompraProdutoId)
                .OnDelete(DeleteBehavior.Cascade);

            // Relacionamento 1:N -> ItemCompraProduto pertence a um Fornecedor
            builder
                .HasOne(i => i.Fornecedor)
                .WithMany(f => f.Itens)
                .HasForeignKey(i => i.FornecedorId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
