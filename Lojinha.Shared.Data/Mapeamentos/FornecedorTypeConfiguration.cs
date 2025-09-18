using Lojinha.Shared.Models;
using Lojinha.Shared.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lojinha.Shared.Data.Mapeamentos
{
    public class FornecedorTypeConfiguration : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.HasKey(f => f.Id);
            builder.Property(f => f.Nome).IsRequired().HasMaxLength(100);
            builder.Property(f => f.Cnpj).IsRequired().HasMaxLength(14);
            builder.Property(f => f.Email).IsRequired().HasMaxLength(100);
            builder.Property(f => f.Telefone).IsRequired().HasMaxLength(15);
            builder.Property(f => f.Celular).IsRequired().HasMaxLength(15);
            builder.Property(f => f.Cep).IsRequired().HasMaxLength(8);
            builder.Property(f => f.Endereco).IsRequired().HasMaxLength(200);
            builder.Property(f => f.Status).HasDefaultValue(Status.Ativo).IsRequired();
        }
    }
}
