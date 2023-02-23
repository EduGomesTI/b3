using B3.DesafioTecnico.Domain.Base.Entities;

namespace B3.DesafioTecnico.Domain.Base.Interfaces
{
    public interface IBaseRepository<TEntity, TId> where TEntity : BaseEntity<TId>
    {
        Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken);

        void Delete(TEntity entity);

        Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken);

        Task<TEntity> FindByIdAsync(TId id, CancellationToken cancellationToken);

        Task<IEnumerable<TEntity>> FindAllAsync(CancellationToken cancellationToken);
    }
}
