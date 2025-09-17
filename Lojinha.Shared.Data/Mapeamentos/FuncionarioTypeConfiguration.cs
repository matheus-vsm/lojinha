using Lojinha.Shared.Models;
using Lojinha.Shared.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lojinha.Shared.Data.Mapeamentos
{
    public class FuncionarioTypeConfiguration : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.HasKey(f => f.Id);
            builder.Property(f => f.Nome).IsRequired().HasMaxLength(100);
            builder.Property(f => f.Cpf).IsRequired().HasMaxLength(11);
            builder.Property(f => f.Rg).IsRequired().HasMaxLength(20);
            builder.Property(f => f.Email).IsRequired().HasMaxLength(100);
            builder.Property(f => f.Telefone).IsRequired().HasMaxLength(15);
            builder.Property(f => f.DataNascimento).IsRequired(false);
            builder.Property(f => f.Endereco).IsRequired().HasMaxLength(200);
            builder.Property(f => f.Cep).IsRequired().HasMaxLength(8);
            builder.Property(f => f.DataCadastro).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();
            builder.Property(f => f.Status).HasDefaultValue(Status.Ativo).IsRequired();

            builder
                .HasMany(f => f.Vendas)
                   .WithOne(v => v.Funcionario)
                   .HasForeignKey(v => v.FuncionarioId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
