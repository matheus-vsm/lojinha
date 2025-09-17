using Lojinha.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lojinha.Shared.Data.Mapeamentos
{
    public class ItemVendaTypeConfiguration : IEntityTypeConfiguration<ItemVenda>
    {
        public void Configure(EntityTypeBuilder<ItemVenda> builder)
        {
            builder.HasKey(iv => iv.Id);
            builder.Property(iv => iv.Quantidade).IsRequired();
            builder.Property(iv => iv.PrecoUnitario).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(i => i.Subtotal)
                .HasColumnType("decimal(18,2)")
                .HasComputedColumnSql("[Quantidade] * [PrecoUnitario]");

            builder
                .HasOne(iv => iv.Produto)
                .WithMany(p => p.ItensVendas)
                .HasForeignKey(iv => iv.ProdutoId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(iv => iv.Venda)
                .WithMany(v => v.Itens)
                .HasForeignKey(iv => iv.VendaId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
