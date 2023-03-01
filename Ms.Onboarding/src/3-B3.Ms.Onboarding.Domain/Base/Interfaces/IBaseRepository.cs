using B3.Ms.Onboarding.Domain.Base.Entities;

namespace B3.Ms.Onboarding.Domain.Base.Interfaces
{
    public interface IBaseRepository<TEntity, TId> where TEntity : BaseEntity<TId>
    {
        Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken);

        void Delete(TEntity entity);    

        Task<TEntity> FindByIdAsync(TId id, CancellationToken cancellationToken);

        Task<IEnumerable<TEntity>> FindAllAsync(CancellationToken cancellationToken);
    }
}
