using Lojinha.Shared.Models;
using Lojinha.Shared.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lojinha.Shared.Data.Mapeamentos
{
    public class CategoriaPublicoTypeConfiguration : IEntityTypeConfiguration<CategoriaPublico>
    {
        public void Configure(EntityTypeBuilder<CategoriaPublico> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Nome).IsRequired().HasMaxLength(100);
            builder.Property(e => e.Descricao).HasMaxLength(100);
            builder.Property(e => e.DataCadastro).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();
            builder.Property(e => e.Status).HasDefaultValue(Status.Ativo).IsRequired();

            builder
                .HasMany(e => e.Produtos)
                .WithOne(p => p.CategoriasPublicos)
                .HasForeignKey(p => p.CategoriaPublicoId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
