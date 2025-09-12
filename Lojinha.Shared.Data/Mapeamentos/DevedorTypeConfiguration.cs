using Lojinha.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lojinha.Shared.Data.Mapeamentos
{
    internal class DevedorTypeConfiguration : IEntityTypeConfiguration<Devedor>
    {
        public void Configure(EntityTypeBuilder<Devedor> entity)
        {
            // Relacionamento: Venda (1:0..1)
            entity.HasOne(d => d.Venda)
                   .WithOne(v => v.Devedor) // Venda pode ter 0 ou 1 dívida
                   .HasForeignKey<Devedor>(d => d.VendaId) // FK obrigatória no Devedor
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
