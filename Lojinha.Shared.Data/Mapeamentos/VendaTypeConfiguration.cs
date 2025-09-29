using Lojinha.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lojinha.Shared.Data.Mapeamentos;

public class VendaTypeConfiguration : IEntityTypeConfiguration<Venda>
{
    public void Configure(EntityTypeBuilder<Venda> builder)
    {
        builder.HasKey(v => v.Id);
        builder.Property(v => v.DataVenda).IsRequired();
        builder.Property(v => v.TotalVenda).IsRequired().HasColumnType("decimal(18,2)");
        builder.Property(v => v.Desconto).HasColumnType("decimal(18,2)");
        builder.Property(v => v.ValorPago).IsRequired().HasColumnType("decimal(18,2)");
        builder.Property(v => v.Status).IsRequired();
        builder.Property(v => v.Observacoes).HasMaxLength(500);

        // Relacionamento 1:N -> Venda pertence a Cliente (obrigatório)
        builder
            .HasOne(v => v.Cliente)
            .WithMany(c => c.Vendas)
            .HasForeignKey(v => v.ClienteId)
            .OnDelete(DeleteBehavior.Restrict);

        // Relacionamento 1:N -> Venda pode ter um Devedor (opcional)
        builder
            .HasOne(v => v.Devedor)
            .WithMany(d => d.Vendas)
            .HasForeignKey(v => v.DevedorId)
            .OnDelete(DeleteBehavior.Restrict);

        // Relacionamento 1:N -> Venda pode ter um Funcionario (opcional)
        builder
            .HasOne(v => v.Funcionario)
            .WithMany(f => f.Vendas)
            .HasForeignKey(v => v.FuncionarioId)
            .OnDelete(DeleteBehavior.Restrict);

        // Relacionamento N:N -> Venda e Pagamentos
        builder
            .HasMany(v => v.Pagamentos)
            .WithMany(p => p.Vendas);
    }
}
