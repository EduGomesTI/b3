using B3.DesafioTecnico.Domain.Base.Entities;

namespace B3.DesafioTecnico.Domain.Base.Interfaces;
public interface IQueryFindById<TEntity, TId> where TEntity : BaseEntity<TId>
{
    Task<TEntity> HandleAsync(TId id, CancellationToken cancellationToken);
}
