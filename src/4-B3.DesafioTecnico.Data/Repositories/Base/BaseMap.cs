using B3.DesafioTecnico.Domain.Base.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace B3.DesafioTecnico.Data.Repositories.Base
{
    internal abstract class BaseMap<TEntity, TId> : IEntityTypeConfiguration<TEntity>
    where TEntity : BaseEntity<TId>
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Ignore(e => e.Messages);
        }
    }
}
