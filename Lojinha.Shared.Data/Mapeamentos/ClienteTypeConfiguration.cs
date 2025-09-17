using Lojinha.Shared.Models;
using Lojinha.Shared.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lojinha.Shared.Data.Mapeamentos
{
    internal class ClienteTypeConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Nome).IsRequired().HasMaxLength(100);
            builder.Property(c => c.Cpf).IsRequired().HasMaxLength(11);
            builder.Property(c => c.Rg).IsRequired().HasMaxLength(9);
            builder.Property(c => c.Email).IsRequired().HasMaxLength(100);
            builder.Property(c => c.Telefone).IsRequired().HasMaxLength(11);
            builder.Property(c => c.DataNascimento).IsRequired(false);
            builder.Property(c => c.Endereco).IsRequired().HasMaxLength(200);
            builder.Property(c => c.Cep).IsRequired().HasMaxLength(8);
            builder.Property(c => c.Status).HasDefaultValue(Status.Ativo).IsRequired();

            builder
                .HasMany(c => c.Vendas)
                .WithOne(v => v.Cliente)
                .HasForeignKey(v => v.ClienteId)
                .OnDelete(DeleteBehavior.Cascade); // Se você apagar um Cliente, todas as Vendas dele também serão apagadas automaticamente no banco.
            builder
                .HasOne(c => c.Devedor)
                .WithOne(d => d.Cliente)
                .HasForeignKey<Devedor>(d => d.ClienteId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
