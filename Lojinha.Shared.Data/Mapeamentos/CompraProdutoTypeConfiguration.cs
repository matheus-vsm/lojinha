using Lojinha.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lojinha.Shared.Data.Mapeamentos
{
    public class CompraProdutoTypeConfiguration : IEntityTypeConfiguration<CompraProduto>
    {
        public void Configure(EntityTypeBuilder<CompraProduto> builder)
        {
            throw new NotImplementedException();
        }
    }
}
