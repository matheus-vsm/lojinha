using Lojinha.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lojinha.Shared.Data.Mapeamentos;

public class PagamentoTypeConfiguration : IEntityTypeConfiguration<Pagamento>
{
    public void Configure(EntityTypeBuilder<Pagamento> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.FormaPagamento).IsRequired();
        builder.Property(p => p.ValorPago).IsRequired().HasColumnType("decimal(18,2)");
    }
}
