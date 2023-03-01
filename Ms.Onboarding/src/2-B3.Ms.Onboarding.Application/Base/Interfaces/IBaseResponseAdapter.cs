using B3.Ms.Onboarding.Application.Base.Entities;
using B3.Ms.Onboarding.Domain.Base.Entities;

namespace B3.Ms.Onboarding.Application.Base.Interfaces;
internal interface IBaseResponseAdapter<TEntity, TId, TResponse>
    where TEntity : BaseEntity<TId>
    where TResponse : BaseResponse 
{
    TResponse Adapt(TEntity entity);
}
