using Lojinha.Shared.Models;
using Lojinha.Shared.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lojinha.Shared.Data.Mapeamentos
{
    public class ProdutoTypeConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Nome).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Marca).IsRequired().HasMaxLength(50);
            builder.Property(p => p.Cor).IsRequired().HasMaxLength(30);
            builder.Property(p => p.Tamanho).IsRequired().HasMaxLength(10);
            builder.Property(p => p.Descricao).HasMaxLength(500);
            builder.Property(p => p.Preco).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(p => p.Estoque).IsRequired();
            builder.Property(p => p.Status).HasDefaultValue(Status.Ativo).IsRequired();

            builder
                .HasOne(p => p.CategoriasProdutos)
                .WithMany(cp => cp.Produtos)
                .HasForeignKey(p => p.CategoriaProdutoId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(p => p.CategoriasPublicos)
                .WithMany(cp => cp.Produtos)
                .HasForeignKey(p => p.CategoriaPublicoId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
