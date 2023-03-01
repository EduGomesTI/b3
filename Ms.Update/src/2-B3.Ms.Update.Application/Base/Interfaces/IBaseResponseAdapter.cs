using B3.Ms.Update.Application.Base.Entities;
using B3.Ms.Update.Domain.Base.Entities;

namespace B3.Ms.Update.Application.Base.Interfaces;
internal interface IBaseResponseAdapter<TEntity, TId, TResponse>
    where TEntity : BaseEntity<TId>
    where TResponse : BaseResponse 
{
    TResponse Adapt(TEntity entity);
}
