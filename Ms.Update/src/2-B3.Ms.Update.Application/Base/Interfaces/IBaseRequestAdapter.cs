using B3.Ms.Update.Application.Base.Entities;
using B3.Ms.Update.Domain.Base.Entities;

namespace B3.Ms.Update.Application.Base.Interfaces;
internal interface IBaseRequestAdapter<TEntity, TId, TRequest>
    where TEntity : BaseEntity<TId>
    where TRequest : BaseRequest
{
    TEntity Adapt(TRequest request);
}
