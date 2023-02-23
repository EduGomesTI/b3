using B3.DesafioTecnico.Domain.Base.Entities;

namespace B3.DesafioTecnico.Domain.Base.Interfaces;
public interface ICommandUpdate<TEntity, TId> where TEntity : BaseEntity<TId> {
    Task<TEntity> HandleAsync(TEntity entidade, CancellationToken cancellationToken);
}