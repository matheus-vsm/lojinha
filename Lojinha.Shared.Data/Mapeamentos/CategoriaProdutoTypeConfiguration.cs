using Lojinha.Shared.Models;
using Lojinha.Shared.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lojinha.Shared.Data.Mapeamentos;

public class CategoriaProdutoTypeConfiguration : IEntityTypeConfiguration<CategoriaProduto>
{
    public void Configure(EntityTypeBuilder<CategoriaProduto> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Nome).IsRequired().HasMaxLength(100);
        builder.Property(e => e.Descricao).HasMaxLength(500);
        builder.Property(e => e.DataCadastro).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();
        builder.Property(e => e.Status).HasDefaultValue(Status.Ativo).IsRequired();
    }
}
