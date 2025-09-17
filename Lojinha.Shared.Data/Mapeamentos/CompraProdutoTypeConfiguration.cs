using Lojinha.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lojinha.Shared.Data.Mapeamentos
{
    public class CompraProdutoTypeConfiguration : IEntityTypeConfiguration<CompraProduto>
    {
        public void Configure(EntityTypeBuilder<CompraProduto> builder)
        {
            builder.HasKey(cp => cp.Id);
            builder.Property(cp => cp.Data).IsRequired();
            builder.Property(cp => cp.Total).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(cp => cp.Observacoes).HasMaxLength(500);

            builder
                .HasMany(cp => cp.Itens)
                .WithOne(i => i.CompraProduto)
                .HasForeignKey(i => i.CompraProdutoId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
