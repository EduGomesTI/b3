using B3.Ms.Update.Domain.Base.Entities;

namespace B3.Ms.Update.Domain.Base.Interfaces
{
    public interface IBaseRepository<TEntity, TId> where TEntity : BaseEntity<TId>
    {        
        void Update(TEntity entity, CancellationToken cancellationToken);                
    }
}
