using B3.Ms.Onboarding.Domain.Base.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace B3.Ms.Onboarding.Data.Repositories.Base
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
