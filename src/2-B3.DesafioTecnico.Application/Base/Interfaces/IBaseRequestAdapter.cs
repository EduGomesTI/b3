using B3.DesafioTecnico.Application.Base.Entities;
using B3.DesafioTecnico.Domain.Base.Entities;

namespace B3.DesafioTecnico.Application.Base.Interfaces;
internal interface IBaseRequestAdapter<TEntity, TId, TRequest>
    where TEntity : BaseEntity<TId>
    where TRequest : BaseRequest
{
    TEntity Adapt(TRequest request);
}
