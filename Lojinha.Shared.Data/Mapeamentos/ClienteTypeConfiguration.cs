using Lojinha.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lojinha.Shared.Data.Mapeamentos
{
    internal class ClienteTypeConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> entity)
        {
            throw new NotImplementedException();
        }
    }
}
