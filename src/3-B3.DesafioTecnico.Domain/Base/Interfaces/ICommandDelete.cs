using B3.DesafioTecnico.Domain.Base.Entities;

namespace B3.DesafioTecnico.Domain.Base.Interfaces;
public interface ICommandDelete<TEntity, TId> where TEntity : BaseEntity<TId> {
    void Handle(TEntity entity);
}
