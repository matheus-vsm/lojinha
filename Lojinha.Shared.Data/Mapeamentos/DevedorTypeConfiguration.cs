using Lojinha.Shared.Models;
using Lojinha.Shared.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lojinha.Shared.Data.Mapeamentos
{
    internal class DevedorTypeConfiguration : IEntityTypeConfiguration<Devedor>
    {
        public void Configure(EntityTypeBuilder<Devedor> builder)
        {
            builder.HasKey(d => d.Id);
            builder.Property(d => d.DividaInicial).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(d => d.DividaAtual).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(d => d.DataInicio).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();
            builder.Property(d => d.DataAtualizacao).IsRequired();
            builder.Property(d => d.DataFim).IsRequired();
            builder.Property(d => d.Status).HasDefaultValue(StatusDevedor.Devendo).IsRequired();

            builder
                .HasOne(d => d.Cliente)
                .WithOne(c => c.Devedor)
                .HasForeignKey<Devedor>(d => d.ClienteId)
                .OnDelete(DeleteBehavior.Restrict); // FK obrigatória no Devedor

            builder
                .HasMany(d => d.Vendas)
                   .WithOne(v => v.Devedor)
                   .HasForeignKey(d => d.DevedorId) // FK obrigatória no Devedor
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
