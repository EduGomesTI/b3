using B3.DesafioTecnico.Domain.Base.Entities;

namespace B3.DesafioTecnico.Domain.Base.Interfaces;
public interface IQueryFindAll<TEntity, TId> where TEntity : BaseEntity<TId>
{
    Task<IEnumerable<TEntity>> HandleAsync(CancellationToken cancellationToken);
}
